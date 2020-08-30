#!/bin/bash

crearUsuarioMYSQL() {
    local puerto=""
    local continuar=true

    iniciarPantallaNueva

    dibujarTxt "CONFIGURANDO MYSQL (construccion)" 44 7 0 7

    dibujarTxt "Usuario:" 36 11 0 7
    dibujarEntradaTxt 36 12 31 false

    dibujarTxt "Contraseña:" 36 11 0 7
    dibujarEntradaTxt 36 12 31 false

    dibujarBoton "AGREGAR" 11 20 40 3
    dibujarBoton "VOLVER" 50 20 40 3

    while $continuar; 
    do
        siguientePos

        case $posDeEsteElemento in

            "0")
                usuarios=$respuestaGestor
                ;;

            "1")
                if $respuestaGestor;
                then
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

}