#!/bin/bash

. "/Scripts/InterfazGrafica/Grafica/disenoVentana.sh" 

. "/Scripts/Computos/Respaldo/VRespaldarBD.sh"
. "/Scripts/Computos/Respaldo/VRespaldarDirectorios.sh"

#necesita root
PrincipalRespaldos() {

    iniciarPantallaNueva
    dibujarTxt "RESPALDOS" 46 3 0

    dibujarTxt "4 -> ARRIBA" 11 5 0
    dibujarTxt "5 -> ENTER " 11 6 0
    dibujarTxt "6 -> ABAJO" 11 7 0

    if [ $EUID -eq 0 ]; then #root
        dibujarBoton "BASE DE DATOS" 11 8 80 3 #root
        dibujarBoton "DIRECTORIOS" 11 11 80 3 #root
        dibujarBoton "RESTAURAR BD" 11 14 80 3 #????
        dibujarBoton "RESTAURAR DIRECTORIOS" 11 17 80 3 #????
        dibujarBoton "VOLVER" 11 20 80 3
    else
        dibujarBoton "RESTAURAR BD" 11 8 80 3 #????
        dibujarBoton "RESTAURAR DIRECTORIOS" 11 11 80 3 #????
        dibujarBoton "VOLVER" 11 14 80 3
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

ejecutarRespaldos() {

    local continuarCiclo=true

    while $continuarCiclo; 
    do
        PrincipalRespaldos
        
        case $codigoElemento in 

            "BTN:BASE DE DATOS:11:8:80:3")
                ejecutarRespaldarBD
                ;;

            "BTN:DIRECTORIOS:11:11:80:3")
                ejecutarRespaldarDirectorio
                ;;

            "BTN:RESTAURAR BD:11:14:80:3"|"BTN:RESTAURAR BD:11:8:80:3")
                # En construcción
                mensajeError "SECCION RESTAURAR BD EN CONSTRUCCION" 1 37 33 2 3 1 1
                ;;

            "BTN:RESTAURAR DIRECTORIOS:11:17:80:3"|"BTN:RESTAURAR DIRECTORIOS:11:11:80:3")
                # En construcción
                mensajeError "SECCION RESTAURAR DIRECTORIOS EN CONSTRUCCION" 1 37 33 2 3 1 1
                ;;
                
            "BTN:VOLVER:11:20:80:3"|"BTN:VOLVER:11:14:80:3")
                continuarCiclo=false
                ;;

            *)
                ;;
        esac
        cerrarPantalla

    done

}