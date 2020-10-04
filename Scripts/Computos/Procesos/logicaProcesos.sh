#!/bin/bash

. "/Scripts/InterfazGrafica/Control/inicio.sh" 

matarProcesoPID() {
    local pid=""
    local continuar=true

	colorBgDefecto=0
    iniciarPantallaNueva

    dibujarRectangulo 11 4 80 31 7 0
    dibujarTxt "MATAR PROCESO POR PID" 42 7 0 7

    dibujarTxt "PID del proceso" 36 11 0 7
    dibujarEntradaTxt 36 12 31 false

    dibujarBoton "MATAR" 28 20 25 3
    dibujarBoton "VOLVER" 52 20 25 3



    while $continuar; 
    do
        siguientePos

        case $posDeEsteElemento in

            "0")
                if $modificado;
				then 
                    pid=$respuestaGestor
                fi             
                ;;

            "1")
                if $respuestaGestor; 
                then
                    if [ -n "$pid" ]; 
                    then
                        kill -9 $pid  > /dev/null 2>&1
                    else 
                        mensajeError "NO INGRESÓ NINGÚN PID" 1 37 33 2 3 1 1
                    fi     
                    continuar=false             
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
    colorBgDefecto=7

}

matarProcesoNombre() {
    local nombre=""
    local continuar=true

	colorBgDefecto=0
    iniciarPantallaNueva
    
    dibujarRectangulo 11 4 80 31 7 0
    dibujarTxt "MATAR PROCESO POR NOMBRE" 44 7 0 7

    dibujarTxt "NOMBRE DEL PROCESO" 36 11 0 7
    dibujarEntradaTxt 36 12 31 false

    dibujarBoton "MATAR" 28 20 25 3
    dibujarBoton "VOLVER" 52 20 25 3

    while $continuar; 
    do
        siguientePos

        case $posDeEsteElemento in

            "0")
                if $modificado;
				then 
                    nombre=$respuestaGestor
                fi             
                ;;

            "1")
                if $respuestaGestor; 
                then
                    if [ -n "$nombre" ]; 
                    then
                        killall $nombre
                    else 
                        mensajeError "NO INGRESÓ NINGÚN NOMBRE" 1 37 33 2 3 1 1
                    fi
                    continuar=false
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
    colorBgDefecto=7

}