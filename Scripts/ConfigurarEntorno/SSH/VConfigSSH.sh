#!/bin/bash

. "/Scripts/InterfazGrafica/Control/inicio.sh" 


pantallaSSH() {
    local usuarios=""
    local root="no"
    local continuar=true
    local pathBanner="/Scripts/ConfigurarEntorno/SSH/bannerDefectoSSH.txt"

    colorBgDefecto=0
    iniciarPantallaNueva
    
    dibujarRectangulo 11 4 80 40 7 0
    dibujarTxt "CONFIGURANDO SSH" 44 7 0 7
    dibujarTxt "Ejemplo: /Scripts/ConfigurarEntorno/SSH/bannerDefectoSSH.txt" 20 8 0 7 

    dibujarTxt "USUARIOS PERMITIDOS (USER1,USER2...)" 36 11 0 7
    dibujarEntradaTxt 36 12 31 false

    dibujarTxt "PERMITIR USUARIOS ROOT" 40 16 0 7
    dibujarSwitch 36 17 30 3 $root

    dibujarTxt "PATH DEL BANNER (none y no agrega el banner)" 30 20 0 7
    dibujarEntradaTxt 11 21 80 false "$pathBanner"

    dibujarBoton "CONFIGURAR" 27 24 50 3

    while $continuar; 
    do
        siguientePos

        case $posDeEsteElemento in

            "0")
                if $modificado;
				then 
                    usuarios=$respuestaGestor
                fi 
                ;;

            "1")
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
            "2") #PATH DEL BANNER
                if $modificado;
				then             
                    pathBanner=$respuestaGestor
                fi
                ;;
            "3") 
                if $respuestaGestor;
                then
                    cp "$pathBanner" "/etc/bannerSSH.txt"
                    pathBanner="/etc/bannerSSH.txt"
                    chmod 755 "$pathBanner"

                    configurarSSH $root $pathBanner
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

configurarSSH () {
    # $1 : root
    # $2 : pathBanner
    root=$1
    pathBanner=$2

    if [ -z $usuarios ]; 
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
    if [ "$pathBanner" ];
    then
        echo "Banner $pathBanner">>/etc/ssh/sshd_config
    fi
    semanage port -a -t ssh_port_t -p tcp 2022 > /dev/null 2>&1
    systemctl restart sshd > /dev/null 2>&1
}
