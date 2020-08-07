#!/bin/bash

VRespaldarBD(){
    iniciarPantallaNueva
    dibujarTxt "RESPALDAR BASE DE DATOS" 80 2

    dibujarTxt "USUARIO MYSQL" 20 5
    dibujarEntradaTxt 20 6 20 false

    dibujarBoton "SIGUIENTE" 20 13 40 3
    dibujarBoton "VOLVER" 60 13 40 3

    user=""
    guardarRespaldo=false
    continuar=true
    while $continuar; do
        siguientePos
        case $posDeEsteElemento in
            "0")
                user=$respuestaGestor
                ;;
            "1")
                if $respuestaGestor && [ $user ]; then 
                    guardarRespaldo=true
                    continuar=false
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
ejecutarRespaldarBD(){
    VRespaldarBD
    if $guardarRespaldo; then
        if $usarPredeterminada;then
            ruta=$PATHB
        fi
    fi
    VRespaldarBD
    if $guardarRespaldo;then 
        respaldoBDResp=$(respaldarBD $user $ruta)
        if [ $respaldoBDResp = "0" ]; then 
            VAvisoRegistrado "RESPALDO REALIZADO CON ÉXITO" 10
        else
            VAvisoRegistrado "SE HAN REALIZADO $CANTB BACKUP" 11
        fi
    fi
    cerrarPantalla
}