#!/bin/bash

. "/Scripts/InterfazGrafica/Grafica/disenoVentana.sh" 

#
# solo root
#

VConexiones(){
    iniciarPantallaNueva
    dibujarTxt "CONEXIONES" 42 6 0

    dibujarTxt "MYSQL" 25 13 0
    dibujarSwitch 40 12 50 3 $estadoMYSQL

    dibujarTxt "SSH" 25 16 0
    dibujarSwitch 40 15 50 3 $estadoSSH

    dibujarBoton "VOLVER" 11 22 80 3

    local continuar=true

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
                        systemctl stop mysqld 
                    else
                        systemctl start mysqld              
                    fi
                    actualizarEstadoServiciosSSHyMYSQL
                fi
                ;;

            "1")
                if [ $codigoRespuesta = "5" ]; 
                then
                    if $estadoSSH; 
                    then
                        systemctl stop sshd 
                    else
                        systemctl start sshd
                    fi
                    actualizarEstadoServiciosSSHyMYSQL
                fi
                ;;

            "2")
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


    comandoMYSQL=$(service mysqld status | grep "Active" | cut -d: -f2 | cut -d" " -f2)

    comandoSSH=$(systemctl status sshd | grep "Active" | cut -d" " -f5) 

    if [ "$comandoMYSQL" = "active" ];
    then
        estadoMYSQL=true
    fi

    if [ "$comandoSSH" = "active" ];
    then
        estadoSSH=true
    fi
    
    historialPos[0,1]=$estadoMYSQL
    historialPos[1,1]=$estadoSSH
}

comprobarRed () {

    if ping -c1 8.8.8.8 &>/dev/null;
    then
        mensajeError "Se detectó conexión a internet" 2 37 33 2 2 2
    else
        mensajeError "No Se detectó conexión a internet" 1 37 33 2 1 2
    fi

}