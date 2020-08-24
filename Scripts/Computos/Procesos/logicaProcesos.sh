#!/bin/bash

. "/Scripts/InterfazGrafica/Grafica/disenoVentana.sh" 

matarProcesoPID() {

	colorBgDefecto=0
    iniciarPantallaNueva
    

    dibujarRectangulo 11 4 80 31 7
    dibujarTxt "MATAR PROCESO POR PID" 42 7 0 7

    dibujarTxt "PID del proceso" 36 11 0 7
    dibujarEntradaTxt 36 12 31 false

    dibujarBoton "MATAR" 28 20 25 3
    dibujarBoton "VOLVER" 52 20 25 3

    local pid=""
    local continuar=true

        while $continuar; 
        do
            siguientePos

            case $posDeEsteElemento in

                "0")
                    pid=$respuestaGestor
                    ;;

                "1")
					if [ $codigoRespuesta = "5" ]; 
                    then
                    	if [ -n "$pid" ]; 
                    	then
                    		kill -9 $pid
                    		colorBgDefecto=7
                    		continuar=false
                    	else 
                    		mensajeError "NO INGRESÓ NINGÚN PID" 1 37 33 2 3 1 1
                    		colorBgDefecto=7
                    		continuar=false
                    	fi                  
                    fi 
                    ;;

                 "2") 
                    if $respuestaGestor;
                    then
                    	colorBgDefecto=7
                        continuar=false
                    fi   
                    ;;  

            esac
        done

}

matarProcesoNombre() {

	colorBgDefecto=0
    iniciarPantallaNueva
    

    dibujarRectangulo 11 4 80 31 7
    dibujarTxt "MATAR PROCESO POR NOMBRE" 44 7 0 7

    dibujarTxt "Nombre del proceso" 36 11 0 7
    dibujarEntradaTxt 36 12 31 false

    dibujarBoton "MATAR" 28 20 25 3
    dibujarBoton "VOLVER" 52 20 25 3

    local nombre=""
    local continuar=true

        while $continuar; 
        do
            siguientePos

            case $posDeEsteElemento in

                "0")
                    nombre=$respuestaGestor
                    ;;

                "1")
					if [ $codigoRespuesta = "5" ]; 
                    then
                    	if [ -n "$nombre" ]; 
                    	then
                    		killall $nombre
                    		colorBgDefecto=7
                    		continuar=false
                    	else 
                    		mensajeError "NO INGRESÓ NINGÚN NOMBRE" 1 37 33 2 3 1 1
                    		colorBgDefecto=7
                    		continuar=false
                    	fi                  
                    fi 
                    ;;

                 "2") 
                    if $respuestaGestor;
                    then
                    	colorBgDefecto=7
                        continuar=false
                    fi   
                    ;;  

            esac
        done

}