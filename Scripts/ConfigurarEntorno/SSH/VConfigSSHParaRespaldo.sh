#!/bin/bash

. "/Scripts/InterfazGrafica/Control/inicio.sh" 


pantallaSSHRespaldos() {
    local usuarios=""
    local root="no"
    local continuar=true
    local pathBanner="/Scripts/ConfigurarEntorno/SSH/bannerDefectoSSH.txt"
    local contrasenaBytesoft=""

    colorBgDefecto=0
    iniciarPantallaNueva
    
    dibujarRectangulo 11 4 80 40 7 0
    dibujarTxt "CONFIGURANDO SSH RESPALDO" 44 7 0 7

    dibujarTxt "USUARIOS PERMITIDOS (USER1,USER2...)" 36 11 0 7
    dibujarEntradaTxt 36 12 31 false #0

    dibujarTxt "PERMITIR USUARIOS ROOT" 40 16 0 7
    dibujarSwitch 36 17 30 3 $root #1

    dibujarTxt "USUARIO" 47 22 0 7
    dibujarTxt "bytesoftRespaldo" 40 23 0 7

    dibujarTxt "CONTRASEÑA" 45 25 0 7
    dibujarEntradaTxt 36 26 31 true #2

    dibujarTxt "PATH DEL BANNER (none y no agrega el banner)" 30 28 0 7
    dibujarTxt "Ejemplo: /Scripts/ConfigurarEntorno/SSH/bannerDefectoSSH.txt" 20 29 0 7 
    dibujarEntradaTxt 11 30 80 false "$pathBanner" #3

    dibujarBoton "CONFIGURAR" 27 32 50 3 #4

    while $continuar; 
    do
        siguientePos

        case $posDeEsteElemento in

            "0") #USUARIOS PERMITIDOS (USER1,USER2...)
                if $modificado;
				then 
                    usuarios=$respuestaGestor
                fi 
                ;;

            "1") #PERMITIR USUARIOS ROOT
                if $modificado; 
                then          
                    if [[ "$root" == "yes" ]];
				    then
                        root="no"
                    else
                        root="yes"
                    fi
                fi
                ;;
            "2") #CONTRASEÑA
                if $modificado;
				then             
                    contrasenaBytesoft=$respuestaGestor
                fi
                ;;
            "3") #PATH DEL BANNER
                if $modificado;
				then             
                    pathBanner=$respuestaGestor
                fi
                ;;
            "4") #CONFIGURAR
                if $respuestaGestor;
                then
                    if [ $(verificarUsuarioYContrasena \"$contrasenaBytesoft\") = "true" ];
                    then
                        cp "$pathBanner" "/etc/bannerSSH.txt"
                        pathBanner="/etc/bannerSSH.txt"
                        chmod 755 "$pathBanner"

                        configurarSSHRespaldos $root $pathBanner "$usuarios" "$contrasenaBytesoft"
                        mensajeError "EL PUERTO POR DEFECTO SERÁ EL 2022" 2 34 33 5 5 2 2
                        continuar=false
                    else
                        mensajeError "CONTRASEÑA INVALIDA" 1 37 33 2 1 2
                    fi   
                fi   
                ;;  
            *)
                ;;
        esac
    done
    cerrarPantalla
}
configurarSSHRespaldos () {
    # $1 : root
    # $2 : pathBanner
    # $3 : usuarios
    # $4 : contrasena bytesoftRespaldo usuario

    local root=$1
    local pathBanner=$2
    local usuarios="$3 bytesoftRespaldo"
    local pw=$4

    ## crea el usuario
    useradd -m -s /bin/bash \
        -d /home/bytesoftRespaldo -g 0 bytesoftRespaldo
    chown bytesoftRespaldo:bytesoftRespaldo -R /home/bytesoftRespaldo
    chmod 755 -R /home/bytesoftRespaldo
	echo -e "$pw\n$pw\n" | passwd bytesoftRespaldo
    
    #permisos root
    if [ $(grep -Ec "^bytesoftRespaldo    ALL=(ALL:ALL) ALL$"  /etc/sudoers) = "0" ]; 
    then
        echo "bytesoftRespaldo    ALL=(ALL) ALL" >> /etc/sudoers
    fi


    if [ -z "$usuarios" ]; 
    then
        cp -a /etc/ssh/sshd_config /var/bytesoft/.sshd_config
        sed -i 's/#Port 22/Port 2022/' /etc/ssh/sshd_config # Cambio el puerto por defecto al 7222
        sed -i "s/#PermitRootLogin yes/PermitRootLogin "$root"/" /etc/ssh/sshd_config
    else
        cp -a /etc/ssh/sshd_config /var/bytesoft/.sshd_config
        sed -i 's/#Port 22/Port 2022/' /etc/ssh/sshd_config # Cambio el puerto por defecto al 7222
        echo "AllowUsers ${usuarios/,/ }">>/etc/ssh/sshd_config
        sed -i "s/#PermitRootLogin yes/PermitRootLogin "$root"/" /etc/ssh/sshd_config
    fi

    
    if [ -e "$pathBanner" ];
    then
        echo "Banner $pathBanner">>/etc/ssh/sshd_config
    fi
    semanage port -a -t ssh_port_t -p tcp 2022 > /dev/null 2>&1
    systemctl restart sshd > /dev/null 2>&1
}

verificarUsuarioYContrasena(){
    # $1 : contraseña
    local pw=$1
    local -a listaPalabras
    local -i posEnLista=0
    local agregarALaLista=true
    local contrasenaValida=false
    for ((n=0;n<${#pw};n++)) 
    do
        lpw=${pw:$n:1}
        agregarALaLista=true

        for i in ${listaPalabras[@]}; 
        do
            if [ $lpw = $i ]; 
            then
                agregarALaLista=false
            fi
        done

        if $agregarALaLista; 
        then
            listaPalabras[$posEnLista]="$lpw"
            ((posEnLista++))
        fi
    done

    listaPalabras=()
    agregarALaLista=false

    if [ -n "$pw" -a ${#pw} -gt 7 -a $posEnLista -gt 4 ];
    then
        contrasenaValida=true
    fi
    echo -n $contrasenaValida
}

