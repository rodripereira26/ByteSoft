#!/bin/bash

. "/Scripts/InterfazGrafica/Control/inicio.sh" 


pantallaSSHServidor() {
    local usuarios=""
    local root="no"
    local continuar=true
    local pathBanner="/Scripts/ConfigurarEntorno/SSH/bannerDefectoSSH.txt"
    local contrasenaBytesoft=""
    local fraseContrasena=""

    colorBgDefecto=0
    iniciarPantallaNueva
    
    dibujarRectangulo 11 4 80 54 7 0
    dibujarTxt "CONFIGURANDO SSH SERVIDOR" 38 7 0 7

    dibujarTxt "USUARIOS PERMITIDOS (USER1,USER2...)" 33 11 0 7
    dibujarEntradaTxt 36 12 31 false #0

    dibujarTxt "PERMITIR USUARIOS ROOT" 40 14 0 7
    dibujarSwitch 36 15 30 3 $root #1

    dibujarTxt "FRASE CONTRASEÑA (PUBLIC KEY SSH)" 35 19 0 7
    dibujarEntradaTxt 36 20 31 false #2

    dibujarTxt "PATH DEL BANNER (none y no agrega el banner)" 30 22 0 7
    dibujarTxt "Ejemplo: /Scripts/ConfigurarEntorno/SSH/bannerDefectoSSH.txt" 20 23 0 7 
    dibujarEntradaTxt 11 24 80 false "$pathBanner" #3

    dibujarBoton "CONFIGURAR" 27 29 50 3 #4

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
            "2") #FRASE CONTRASEÑA
                if $modificado;
				then 
                    fraseContrasena=$respuestaGestor
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
                    mensajeError "" 1 34 33 0 2 1
                    clear
                    cp "$pathBanner" "/etc/bannerSSH.txt"
                    pathBanner="/etc/bannerSSH.txt"
                    chmod 755 "$pathBanner"

                    configurarSSHServidor "$root" "$pathBanner" "$usuarios" "$fraseContrasena"
                    mensajeError "EL PUERTO POR DEFECTO SERÁ EL 2022" 2 34 33 5 5 2 2
                    continuar=false
                fi   
                ;;  
            *)
                ;;
        esac
    done
    cerrarPantalla
}

configurarSSHServidor () {
    #region descripcion y args
    # $1 : root
    # $2 : pathBanner
    # $3 : usuarios
    # $4 : contrasena ssh keygen
    local root=$1
    local pathBanner=$2
    local usuarios=$3
    local pwKeygen=$4
    #endregion
    
    #config SSH
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
    if [ -e "$pathBanner" ] && [ -z "$(grep -E ^Banner /etc/ssh/sshd_config)" ];
    then
        echo "Banner $pathBanner">>/etc/ssh/sshd_config
    fi

    #configurar SSH public key con el usuario ya instalado
    rm /home/bytesoft/.ssh/id_rsa 
    echo -e "\n$pwKeygen\n$pwKeygen\n" | ssh-keygen
    chmod 700 /home/bytesoft/.ssh/id_rsa
    touch /home/bytesoft/.ssh/known_hosts
 

    clear
    semanage port -a -t ssh_port_t -p tcp 2022 > /dev/null 2>&1
    systemctl restart sshd > /dev/null 2>&1
}
