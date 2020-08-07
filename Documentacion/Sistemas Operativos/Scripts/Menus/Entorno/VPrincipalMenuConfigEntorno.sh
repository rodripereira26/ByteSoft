#!/bin/bash

. "Menus/OpcionesMenuConfigEntorno/VRespaldarDirectorios.sh"
. "Menus/OpcionesMenuConfigEntorno/VRespaldarBD.sh"

VMenuConfigEntorno(){
    iniciarPantallaNueva
    dibujarTxt "CONFIGURACION DEL ENTORNO" 80 2
    dibujarBoton "CREAR DIRECTORIOS Y VARIABLES" 20 4 80 3
    dibujarBoton "RESPALDAR DIRECTORIOS" 20 7 80 3
    dibujarBoton "RESPALDAR BASE DE DATOS" 20 10 80 3
    dibujarBoton "VOLVER" 20 13 80 3

    local continuar=true
    while $continuar; do
        siguientePos
        if $respuestaGestor; then
            continuar=false
        fi 
    done
}
ejecutarConfigEntorno(){
    local continuarCiclo=true
    while $continuarCiclo; do
        VMenuConfigEntorno
        case $posDeEsteElemento in 
            "0")
                variablesEntorno
                case $(crearCarpetasIniciales) in 
                    "0")
                        VAvisoRegistrado "Los directorios ya han sido creados" 10
                        ;;
                    "1")
                        VAvisoRegistrado "Creando directorios..." 11 2
                        VAvisoRegistrado "Directorios creados" 10 1
                        ;;
                    *)
                        VAvisoRegistrado "Error desconocido" 9
                        ;;
                esac
                ;;
            "1")
                ejecutarRespaldarDirectorio
                ;;
            "2")
                ejecutarRespaldarBD
                ;;
            "3")
                continuarCiclo=false
                ;;
            *)
                ;;
        esac
        cerrarPantalla
    done
}