#!/bin/bash

. "/Scripts/InterfazGrafica/Control/inicio.sh" 

. "/Scripts/Computos/Procesos/logicaProcesos.sh"

menuProcesos(){
    local continuar=true

    iniciarPantallaNueva
    dibujarTxt "PROCESOS" 46 3 0

    dibujarTxt "4 -> ARRIBA" 11 6 0
    dibujarTxt "5 -> ENTER " 11 7 0
    dibujarTxt "6 -> ABAJO" 11 8 0
    
    dibujarBoton "VER PROCESOS ACTIVOS (Q PARA SALIR)" 11 9 80 3
    dibujarBoton "MATAR PROCESO USANDO EL PID" 11 12 80 3
    dibujarBoton "MATAR PROCESO USANDO EL NOMBRE" 11 15 80 3
    dibujarBoton "VOLVER" 11 18 80 3


    while $continuar; 
    do
        siguientePos

        if $respuestaGestor; 
        then
            continuar=false
        fi 
    done

}

ejecutarProcesos(){

    local continuarCiclo=true

    while $continuarCiclo; 
    do
        menuProcesos

        case $posDeEsteElemento in 

        	"0")
				tput sgr0
				clear
				top
				;;

			"1")
            	matarProcesoPID
				;;

			"2")
				matarProcesoNombre
				;;

            "3")
                continuarCiclo=false
                ;;
        esac
        cerrarPantalla
        
    done
}

