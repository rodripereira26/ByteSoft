#!/bin/bash

. "/Scripts/InterfazGrafica/Control/inicio.sh" 
. "/Scripts/ABM/Logica/Usuarios.sh"


pantallaSSHRespaldos() {
    local usuarios=""
    local root="no"
    local continuar=true
    local pathBanner="/Scripts/ConfigurarEntorno/SSH/bannerDefectoSSH.txt"
    local contrasenaBytesoft=""
    local fraseContrasena=""
    
    colorBgDefecto=0
    iniciarPantallaNueva
    
    dibujarRectangulo 11 4 80 54 7 0
    dibujarTxt "CONFIGURANDO SSH" 44 7 0 7

    dibujarTxt "USUARIOS PERMITIDOS (USER1,USER2...)" 33 11 0 7
    dibujarEntradaTxt 36 12 31 false

    dibujarTxt "PERMITIR USUARIOS ROOT" 40 14 0 7
    dibujarSwitch 36 15 30 3 $root

    dibujarTxt "USUARIO" 47 18 0 7
    dibujarTxt "bytesoftRespaldoEntrada" 40 19 0 7

    dibujarTxt "CONTRASEÑA" 45 21 0 7
    dibujarEntradaTxt 36 22 31 true

    dibujarTxt "FRASE CONTRASEÑA" 43 24 0 7
    dibujarEntradaTxt 36 25 31 false

    dibujarTxt "PATH DEL BANNER (none y no agrega el banner)" 30 27 0 7
    dibujarTxt "Ejemplo: /Scripts/ConfigurarEntorno/SSH/bannerDefectoSSH.txt" 20 28 0 7 
    dibujarEntradaTxt 11 29 80 false "$pathBanner"

    dibujarBoton "CONFIGURAR" 27 32 50 3

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
            "3") #FRASE CONTRASEÑA
                if $modificado;
				then 
                    fraseContrasena=$respuestaGestor
                fi 
                ;;
            "2") #PATH DEL BANNER
                if $modificado;
				then             
                    pathBanner=$respuestaGestor
                fi
                ;;
            "3") #configurar
                if $respuestaGestor;
                then
                    if [ $(verificarUsuarioYContrasena "$contrasena") = "true" ];
                    then
                        cp "$pathBanner" "/etc/bannerSSH.txt"
                        pathBanner="/etc/bannerSSH.txt"
                        chmod 755 "$pathBanner"

                        configurarSSHRespaldos "$root" "$pathBanner" "$contrasenaBytesoft" "$fraseContrasena"
                        mensajeError "EL PUERTO POR DEFECTO SERÁ EL 2022" 2 34 33 5 5 2 2
                        continuar=false
                    fi
                fi   
                ;;  
            *)
                ;;
        esac
    done
    cerrarPantalla
}
pantallaSSHRespaldos
configurarSSHRespaldos () {
    #region descripcion y args
    # $1 : root
    # $2 : pathBanner
    # $3 : contrasena bytesoftRespaldoEntrada usuario
    # $4 : contrasena ssh keygen
    local root=$1
    local pathBanner=$2
    local pw=$3
    local pwKeygen=$4  
    #endregion
    
    ## crea el usuario
    useradd -m -s /bin/bash \
        -d /home/bytesoftRespaldoEntrada -g 0 bytesoftRespaldoEntrada
    chown bytesoftRespaldoEntrada:bytesoftRespaldoEntrada -R /home/bytesoftRespaldoEntrada
    chmod 755 -R /home/bytesoftRespaldoEntrada
	echo -e "$pw\n$pw\n" | passwd bytesoftRespaldoEntrada
    
    if [ -e "$pathBanner" ];
    then
        echo "Banner $pathBanner">>/etc/ssh/sshd_config
    fi

    #configurar SSH public key
    su bytesoftRespaldoEntrada -c "rm /home/bytesoftRespaldoEntrada/.ssh/id_rsa" 
    su bytesoftRespaldoEntrada -c "echo -e \"\n$pwKeygen\n$pwKeygen\n\" | ssh-keygen"
    su bytesoftRespaldoEntrada -c "chmod 700 /home/bytesoftRespaldoEntrada/.ssh/id_rsa"
    su bytesoftRespaldoEntrada -c "touch /home/bytesoftRespaldoEntrada/.ssh/known_hosts"
 
    #root 
    if [ $(grep -Ec "^bytesoftRespaldoEntrada    ALL=(ALL:ALL) ALL$"  /etc/sudoers) = "0" ]; 
    then
        echo "bytesoftRespaldoEntrada    ALL=(ALL:ALL) ALL" >> /etc/sudoers
    fi

    semanage port -a -t ssh_port_t -p tcp 2022 > /dev/null 2>&1
    systemctl restart sshd > /dev/null 2>&1
}
verificarUsuarioYContrasena(){
    # $1 : contraseña
    local pw=$1
    local -a listaPalabras
    local -i posEnLista=0
    local contrasenaValida=false
    local agregarALaLista=true

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
