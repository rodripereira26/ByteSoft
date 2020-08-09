#!/bin/bash

. "Menus/Entorno/VRespaldarDirectorios.sh"
. "Menus/Entorno/VRespaldarBD.sh"
. "Menus/Entorno/VConexiones.sh"
  
VMenuConfigEntorno(){
    iniciarPantallaNueva
    dibujarTxt "CONFIGURACIÓN DEL ENTORNO" 48 2
    dibujarBoton "CREAR DIRECTORIOS Y VARIABLES" 20 4 80 3
    dibujarBoton "RESPALDAR DIRECTORIOS" 20 7 80 3
    dibujarBoton "RESPALDAR BASE DE DATOS" 20 10 80 3
    dibujarBoton "CONEXIONES (SQL, SSH)" 20 13 80 3
    dibujarBoton "VOLVER" 20 16 80 3

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
ejecutarConfigEntorno() {

    local continuarCiclo=true

    while $continuarCiclo; 
    do
        VMenuConfigEntorno

        case $posDeEsteElemento in 

            "0")
                
                case $(crearCarpetasIniciales) in 

                    "0")
                        variablesEntorno
                        VAvisoRegistrado "Creando directorios y variables..." 2 3
                        VAvisoRegistrado "Directorios creados" 2 2
                        ;;

                    "1")
                        VAvisoRegistrado "Los directorios ya han sido creados" 2
                        ;;

                    *)
                        VAvisoRegistrado "Error desconocido" 1
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
                ejecutarVConexiones
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