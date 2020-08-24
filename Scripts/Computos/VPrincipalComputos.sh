#!/bin/bash

. "/Scripts/InterfazGrafica/Grafica/disenoVentana.sh"

. "/Scripts/ABM/Menus/VPrincipalMenuUsuarios.sh"
. "/Scripts/Computos/Respaldo/VPrincipalRespaldos.sh"
. "/Scripts/Computos/Logs/VLogs.sh"
. "/Scripts/Computos/Procesos/VAccionesProcesos.sh"
. "/Scripts/Computos/Servicios/VPrincipalMenuServicios.sh"
. "/Scripts/Computos/Servicios/VConexiones.sh"

PrincipalComputos() {

    iniciarPantallaNueva
    dibujarTxt "CENTRO DE COMPUTOS" 43 3 0

    dibujarTxt "4 -> ARRIBA" 11 3 0
    dibujarTxt "5 -> ENTER " 11 4 0
    dibujarTxt "6 -> ABAJO" 11 5 0
    
    dibujarBoton "USUARIOS" 11 6 80 3
    dibujarBoton "SERVICIOS" 11 9 80 3
    dibujarBoton "PROCESOS" 11 12 80 3
    dibujarBoton "COMPROBAR RED" 11 15 80 3
    dibujarBoton "LOGS" 11 18 80 3
    dibujarBoton "RESPALDOS" 11 21 80 3
    dibujarBoton "VOLVER" 11 24 80 3

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

ejecutarComputos() {

    local continuarCiclo=true

    while $continuarCiclo; 
    do
        PrincipalComputos
        case $posDeEsteElemento in 

            "0")
                ejecutarUsuario
                ;;

            "1")
                ejecutarMenuPrincipalServicios 
                ;;
                
            "2")
                ejecutarProcesos
                ;;

            "3")
                comprobarRed
                ;;

            "4")
                ejecutarLogs
                ;;

            "5") 
                ejecutarRespaldos
                ;;

            "6")
                continuarCiclo=false
                ;;
                  
            *)
                ;;
        esac
        cerrarPantalla

    done

}