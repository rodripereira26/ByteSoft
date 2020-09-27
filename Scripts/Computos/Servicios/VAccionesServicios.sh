#!/bin/bash

. "/Scripts/InterfazGrafica/Control/inicio.sh" 
#necesita root
activarServicio() {
    local nombre=""
    local continuar=true

	colorBgDefecto=0
    iniciarPantallaNueva
    

    dibujarRectangulo 11 4 80 31 7 0
    dibujarTxt "ACTIVAR SERVICIO" 44 7 0 7

    dibujarTxt "NOMBRE DEL SERVICIO" 36 11 0 7
    dibujarEntradaTxt 36 12 31 false

    dibujarBoton "ACTIVAR" 28 20 25 3
    dibujarBoton "VOLVER" 52 20 25 3



    while $continuar; 
    do
        siguientePos

        case $posDeEsteElemento in

            "0")
                if $modificado; then 
                    nombre=$respuestaGestor
                fi 
                ;;

            "1")
                if $respuestaGestor; 
                then
                    if [ -n "$nombre" ]; 
                    then
                        respuestaComando=$(systemctl start $nombre 2>&1)
                   
                        if [ "$respuestaComando" = "Failed to start $nombre.service: Unit not found." ]; then
                                mensajeError "SERVICIO NO INSTALADO EN CENTOS" 1 37 33 2 2 1 1 
                        else
                            activo=$(systemctl is-active $nombre)
                            if [ "$activo" = "active" ]; then
                                mensajeError "SERVICIO ACTIVADO" 2 42 33 2 2 2 2
                            else
                                mensajeError "ERROR AL ACTIVAR EL SERVICIO" 1 37 33 2 2 1 1      
                            fi
                        fi
                    else 
                        mensajeError "NO INGRESÓ NINGÚN SERVICIO" 1 37 33 2 3 1 1
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

desactivarServicio() {
    local nombre=""
    local continuar=true
	colorBgDefecto=0
    
    iniciarPantallaNueva
    

    dibujarRectangulo 11 4 80 31 7 0
    dibujarTxt "DESACTIVAR SERVICIO" 44 7 0 7

    dibujarTxt "NOMBRE DEL SERVICIO" 36 11 0 7
    dibujarEntradaTxt 36 12 31 false

    dibujarBoton "DESACTIVAR" 28 20 25 3
    dibujarBoton "VOLVER" 52 20 25 3



    while $continuar; 
    do
        siguientePos

        case $posDeEsteElemento in

            "0")
                if $modificado; then 
                    nombre=$respuestaGestor
                fi 
                ;;

            "1")
                if $respuestaGestor; 
                then
                    if [ -n "$nombre" ]; 
                    then
                        respuestaComando=$(systemctl stop $nombre 2>&1)
                        if [ "$respuestaComando" = "Failed to stop $nombre.service: Unit mysqld.service not loaded." ]; then
                                mensajeError "SERVICIO NO INSTALADO EN CENTOS" 1 37 33 2 2 1 1 
                        else
                            activo=$(systemctl is-active $nombre)
                            if [ "$activo" = "inactive" ]; then
                                mensajeError "SERVICIO DESACTIVADO" 2 42 33 2 2 2 2
                            else
                                mensajeError "ERROR AL DESACTIVAR EL SERVICIO" 1 37 33 2 2 1 1      
                            fi
                        fi
                    
                    else 
                        mensajeError "NO INGRESÓ NINGÚN SERVICIO" 1 37 33 2 3 1 1
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
