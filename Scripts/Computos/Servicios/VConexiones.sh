#!/bin/bash

. "/Scripts/InterfazGrafica/Control/inicio.sh" 
#
# solo root
#

VConexiones(){
    local continuar=true
    
    iniciarPantallaNueva
    dibujarTxt "CONEXIONES" 42 6 0

    dibujarTxt "MYSQL" 25 13 0
    dibujarSwitch 40 12 50 3 $estadoMYSQL

    dibujarTxt "SSH" 25 16 0
    dibujarSwitch 40 15 50 3 $estadoSSH
    
    dibujarTxt "DHCP" 25 19 0
    dibujarSwitch 40 18 50 3 $estadoDHCP

    dibujarBoton "VOLVER" 11 22 80 3



    while $continuar; 
    do
        actualizarEstadoServiciosSSHyMYSQL
        siguientePos

        case $posDeEsteElemento in 

            "0")
                if [ $codigoRespuesta = "5" ]; 
                then
                    if $estadoMYSQL; 
                    then
                        systemctl stop mysqld 2> /dev/null
                    else 
                        systemctl start mysqld 2> /dev/null
                    fi
                    actualizarEstadoServiciosSSHyMYSQL
                fi
                ;;

            "1")
                if [ $codigoRespuesta = "5" ]; 
                then
                    if $estadoSSH; 
                    then
                        systemctl stop sshd 2> /dev/null
                    else
                        systemctl start sshd 2> /dev/null
                    fi
                    actualizarEstadoServiciosSSHyMYSQL
                fi
                ;;
            "3")
                if [ $codigoRespuesta = "5" ]; 
                then
                    if $estadoSSH; 
                    then
                        systemctl stop dhcpd 2> /dev/null
                    else
                        systemctl start dhcpd 2> /dev/null
                    fi
                    actualizarEstadoServiciosSSHyMYSQL
                fi

                ;;
            "4")
                if $respuestaGestor; 
                then
                    continuar=false
                fi
                ;;
        esac
    done
}

ejecutarVConexiones() {

    actualizarEstadoServiciosSSHyMYSQL
    VConexiones

}

actualizarEstadoServiciosSSHyMYSQL() {

    estadoMYSQL=false
    estadoSSH=false
    estadoDHCP=false

    comandoMYSQL=$(systemctl is-active mysqld)
    comandoSSH=$(systemctl is-active sshd)
    comandoDHCP=$(systemctl is-active dhcpd)

    if [ "$comandoMYSQL" = "active" ];
    then
        estadoMYSQL=true
    fi

    if [ "$comandoSSH" = "active" ];
    then
        estadoSSH=true
    fi
    if [ "$comandoDHCP" = "active" ];
    then
        estadoDHCP=true
    fi
    
    modificarElemento 0 1 $estadoMYSQL
    modificarElemento 1 1 $estadoSSH
    modificarElemento 2 1 $estadoDHCP
    
}
