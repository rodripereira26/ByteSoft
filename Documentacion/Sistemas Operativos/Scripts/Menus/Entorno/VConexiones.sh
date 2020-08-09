#!/bin/bash

VConexiones(){
    iniciarPantallaNueva
    dibujarTxt "CONEXIONES" 50 2

    dibujarTxt "MYSQL" 20 5
    dibujarSwitch 40 4 60 3 $estadoMYSQL

    dibujarTxt "SSH" 20 8
    dibujarSwitch 40 7 60 3 $estadoSSH

    dibujarBoton "VOLVER" 20 13 80 3

    local continuar=true
    while $continuar; do
        actualizarEstadoServicios
        siguientePos

        case $posDeEsteElemento in 
            "0")
                if [ $codigoRespuesta = "5" ]; then
                    if $estadoMYSQL; then
                        tput cup 0 0 
                        service mysqld stop
                    else
                        tput cup 0 0
                        service mysqld start                    
                    fi
                    actualizarEstadoServicios
                fi
                ;;
            "1")
                if [ $codigoRespuesta = "5" ]; then
                    tput cup 0 0
                    if $estadoSSH; then
                        service sshd stop
                    else
                        service sshd start
                    fi
                    actualizarEstadoServicios
                fi
                ;;
            "2")
                if $respuestaGestor; then
                    continuar=false
                fi
                ;;
            *)
                ;;
        esac
    done
}

ejecutarVConexiones(){
    actualizarEstadoServicios
    VConexiones
}

actualizarEstadoServicios(){
    estadoMYSQL=false
    estadoSSH=false


    tput cup 0 0
    comandoMYSQL=$(service mysqld status | grep "Active" | cut -d: -f2 | cut -d" " -f2)

    tput cup 0 0
    comandoSSH=$(service sshd status | grep "Active" | cut -d: -f2 | cut -d" " -f2) 

    if [ "$comandoMYSQL" = "active" ];then
        estadoMYSQL=true
    fi

    if [ "$comandoSSH" = "active" ];then
        estadoSSH=true
    fi
    historialPos[0,1]=$estadoMYSQL
    historialPos[1,1]=$estadoSSH
}