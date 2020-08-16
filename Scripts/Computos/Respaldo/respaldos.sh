#!/bin/bash

#
# Obligatorio ejecutar con root
#

. "/Scripts/InterfazGrafica/Grafica/disenoVentana.sh" 
. "/Scripts/Computos/Respaldo/VRespaldarBD.sh"
. "/Scripts/Computos/Respaldo/VRespaldarDirectorios.sh"

PrincipalRespaldos() {

    iniciarPantallaNueva
    dibujarTxt "RESPALDOS" 46 3 0

    dibujarTxt "4 -> ARRIBA" 11 5 0
    dibujarTxt "5 -> ENTER " 11 6 0
    dibujarTxt "6 -> ABAJO" 11 7 0
    
    dibujarBoton "BASE DE DATOS" 11 8 80 3
    dibujarBoton "DIRECTORIOS" 11 11 80 3
    dibujarBoton "RESTAURAR BD" 11 14 80 3
    dibujarBoton "RESTAURAR DIRECTORIOS" 11 17 80 3
    dibujarBoton "VOLVER" 11 20 80 3

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

ejecutarRespaldos() {

    local continuarCiclo=true

    while $continuarCiclo; 
    do
        PrincipalRespaldos
        
        case $posDeEsteElemento in 

            "0")
                ejecutarRespaldarBD
                ;;

            "1")
                ejecutarRespaldarDirectorio
                ;;

            "2")
                # En construcción
                ;;

            "3")
                # En construcción
                ;;
                
            "4")
                continuarCiclo=false
                ;;

            *)
                ;;
        esac
        cerrarPantalla

    done

}
