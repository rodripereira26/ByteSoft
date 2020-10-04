#!/bin/bash

. "/Scripts/InterfazGrafica/Control/inicio.sh"

VBloquearIP(){
    local continuar=true
    local ip=""
    local tipoRegla=""


    iniciarPantallaNueva
    dibujarTxt "BLOQUEAR IP" 43 3 0

    dibujarTxt "4 -> ARRIBA" 11 3 0
    dibujarTxt "5 -> ENTER " 11 4 0
    dibujarTxt "6 -> ABAJO" 11 5 0
    
    dibujarTxt "INGRESA TIPO DE REGLA" 11 11 0
    dibujarEntradaTxt 11 12 20 false

    dibujarTxt "INGRESA IP" 11 14 0
    dibujarEntradaTxt 11 15 20 false

    dibujarBoton "BLOQUEAR" 11 20 40 3
    dibujarBoton "VOLVER" 50 20 40 3

    while $continuar; do
        siguientePos

        case $posDeEsteElemento in
        
            "0")
                if $modificado; then 
                    tipoRegla=$respuestaGestor
                fi             
                ;;

            "1")
                if $modificado; then 
                    ip=$respuestaGestor
                fi             
                ;;
                
            "2")
                if $respuestaGestor; then
                    iptables -I $tipoRegla -s $ip -j DROP  > /dev/null 2>&1
                    if [ $? -eq 0 ]; then
                        mensajeError "EJECUTADO CORRECTAMENTE" 2 37 33 2 2 2
                    else
                        mensajeError "IP INVALIDA O TIPO DE REGLA INVALIDA" 1 37 33 2 1 2
                    fi
                fi 
                ;;
            "3")
                if $respuestaGestor; then
                    continuar=false  
                fi
                ;;
            *)
                ;;
        esac
    done
    
}
ejecutarBloquearIP(){
    VBloquearIP
    cerrarPantalla
}