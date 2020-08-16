#!/bin/bash

. "/Scripts/InterfazGrafica/Grafica/disenoVentana.sh" 
. "/Scripts/InterfazGrafica/Logica/logicaVentana.sh" 

activarServicio() {

	colorBgDefecto=0
    iniciarPantallaNueva
    

    dibujarRectangulo 11 4 80 31 7
    dibujarTxt "ACTIVAR SERVICIO" 44 7 0 7

    dibujarTxt "Nombre del servicio" 36 11 0 7
    dibujarEntradaTxt 36 12 31 false

    dibujarBoton "ACTIVAR" 28 20 25 3
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
                    		systemctl start $nombre>/dev/null 2>&1
                    		activo=$(systemctl status $nombre | grep Active | cut -f1 -d"(" | cut -f2 -d":")

                    		if [ $activo = "active" ];
                    		then
                    			mensajeError "SERVICIO ACTIVADO" 2 42 33 2 2 2 2
                    			colorBgDefecto=7
                    			continuar=false
                    		else
                    			mensajeError "ERROR AL ACTIVAR EL SERVICIO" 1 37 33 2 2 1 1
                    			colorBgDefecto=7
                    			continuar=false
                    		fi

                    	else 
                    		mensajeError "NO INGRESÓ NINGÚN SERVICIO" 1 37 33 2 3 1 1
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

desactivarServicio() {

	colorBgDefecto=0
    iniciarPantallaNueva
    

    dibujarRectangulo 11 4 80 31 7
    dibujarTxt "DESACTIVAR SERVICIO" 44 7 0 7

    dibujarTxt "Nombre del servicio" 36 11 0 7
    dibujarEntradaTxt 36 12 31 false

    dibujarBoton "DESACTIVAR" 28 20 25 3
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
                    		systemctl stop $nombre>/dev/null 2>&1
                    		activo=$(systemctl status $nombre | grep Active | cut -f1 -d"(" | cut -f2 -d":")

                    		if [ $activo = "inactive" ];
                    		then
                    			mensajeError "SERVICIO DESACTIVADO" 2 42 33 2 2 2 2
                    			colorBgDefecto=7
                    			continuar=false
                    		else
                    			mensajeError "ERROR AL DESACTIVAR EL SERVICIO" 1 37 33 2 2 1 1
                    			colorBgDefecto=7
                    			continuar=false
                    		fi

                    	else 
                    		mensajeError "NO INGRESÓ NINGÚN SERVICIO" 1 37 33 2 3 1 1
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


