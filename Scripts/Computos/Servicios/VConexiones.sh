#!/bin/bash

. "/Scripts/InterfazGrafica/Control/inicio.sh" 
#
# solo root
#

VConexiones(){
    local continuar=true
    #region [rgba(27, 173, 192, 0.10)] tui 
    iniciarPantallaNueva
    dibujarTxt "CONEXIONES" 42 6 0

    dibujarTxt "MYSQL" 25 13 0
    dibujarSwitch 40 12 50 3 $estadoMYSQL

    dibujarTxt "SSH" 25 16 0
    dibujarSwitch 40 15 50 3 $estadoSSH

    dibujarTxt "VSFTP" 25 19 0
    dibujarSwitch 40 18 50 3 $estadoFTP

    dibujarBoton "VOLVER" 11 22 80 3

    #endregion

    while $continuar; 
    do
        actualizarEstadoServiciosSSHyMYSQL
        siguientePos

        case $posDeEsteElemento in 

            "0")
                if $modificado; 
                then
                    if $estadoMYSQL; 
                    then
                        systemctl stop mysqld
                    else 
                        systemctl start mysqld
                    fi
                fi
                ;;

            "1")
                if $modificado; 
                then
                    if $estadoSSH; 
                    then
                        systemctl stop sshd
                    else
                        systemctl start sshd
                    fi
                fi
                ;;
            "2")
                if $modificado; 
                then
                    if $estadoFTP; 
                    then
                        systemctl stop vsftpd
                    else
                        systemctl start vsftpd
                    fi
                fi
                ;;
            "3")
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
    cerrarPantalla
}

actualizarEstadoServiciosSSHyMYSQL() {

    estadoMYSQL=false
    estadoSSH=false
    estadoFTP=false

    comandoMYSQL=$(systemctl is-active mysqld)
    comandoSSH=$(systemctl is-active sshd)
    comandoFTP=$(systemctl is-active vsftpd)

    if [ "$comandoMYSQL" = "active" ] || [ "$comandoMYSQL" = "activating" ];
    then
        estadoMYSQL=true
    fi

    if [ "$comandoSSH" = "active" ] || [ "$comandoSSH" = "activating" ];
    then
        estadoSSH=true
    fi
    if [ "$comandoFTP" = "active" ] || [ "$comandoFTP" = "activating" ];
    then
        estadoFTP=true
    fi

    
    modificarElemento 0 1 $estadoMYSQL
    modificarElemento 1 1 $estadoSSH
    modificarElemento 2 1 $estadoFTP
    
}
