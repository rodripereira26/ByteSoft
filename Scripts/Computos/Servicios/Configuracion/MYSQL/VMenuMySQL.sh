#!/bin/bash

. "/Scripts/InterfazGrafica/Control/inicio.sh" 

. "/Scripts/Computos/Servicios/Configuracion/MYSQL/VLogearMYSQL.sh"

VMenuMySQL(){

    iniciarPantallaNueva
    dibujarTxt "MYSQL (EN CONSTRUCCIÓN)" 42 3 0

    dibujarTxt "4 -> ARRIBA" 11 6 0
    dibujarTxt "5 -> ENTER " 11 7 0
    dibujarTxt "6 -> ABAJO" 11 8 0

    dibujarBoton "LOGEAR" 11 9 80 3
    dibujarBoton "-----" 11 12 80 3
    dibujarBoton "Volver" 11 15 80 3

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

ejercutarMenuMySQL() {

    local continuarCiclo=true

    while $continuarCiclo; 
    do
        VMenuMySQL

        case $posDeEsteElemento in 
            
            "0")
                logearMySQL
                ;;

            "1")
                mensajeError "Seccion en construccion" 1 37 33 2 3 1 1
                ;;

            "2")
                continuarCiclo=false
                ;;
            *)
                ;;
        esac
        
        cerrarPantalla
    done

}