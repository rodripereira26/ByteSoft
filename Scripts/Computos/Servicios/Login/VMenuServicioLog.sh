#!/bin/bash


. "/Scripts/InterfazGrafica/Control/inicio.sh" 

. "/Scripts/Computos/Servicios/Login/VLogearMYSQL.sh"
. "/Scripts/Computos/Servicios/Login/VLogearSSH.sh"

VMenuServicioConf(){

    iniciarPantallaNueva
    dibujarTxt "LOGIN SERVICIOS" 42 3 0

    dibujarTxt "4 -> ARRIBA" 11 6 0
    dibujarTxt "5 -> ENTER " 11 7 0
    dibujarTxt "6 -> ABAJO" 11 8 0


    dibujarBoton "LOGUEAR MYSQL" 11 9 80 3
    if [ $EUID -ne 0 ];then 
        dibujarBoton "LOGUEAR SSH" 11 12 80 3 #solo no root
        dibujarBoton "VOLVER" 11 15 80 3
    else
        dibujarBoton "VOLVER" 11 12 80 3
    fi

    local continuar=true

    while $continuar; 
    do
        siguientePos

        if $respuestaGestor; 
        then
            continuar=false
        fi 
    done
}

ejecutarMenuServicioConf() {

    local continuarCiclo=true

    while $continuarCiclo; 
    do
        VMenuServicioConf

        case $texto in 
            
            "LOGUEAR MYSQL")
                logearMySQL
                ;;

            "LOGUEAR SSH")
                logearSSH
                ;;

            "VOLVER")
                continuarCiclo=false
                ;;
            *)
                ;;
        esac
        
        cerrarPantalla
    done

}