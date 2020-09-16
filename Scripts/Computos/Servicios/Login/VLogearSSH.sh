#!/bin/bash

. "/Scripts/InterfazGrafica/Control/inicio.sh"

logearSSH() {
    local usuario=""
    local continuar=true

    iniciarPantallaNueva

    dibujarTxt "LOGUEARSE SSH" 44 7 0 7

    dibujarTxt "USUARIO:" 36 11 0 7
    dibujarEntradaTxt 36 12 31 false

    dibujarBoton "LOGUEARSE" 11 20 40 3
    dibujarBoton "VOLVER" 50 20 40 3

    while $continuar; 
    do
        siguientePos

        case $posDeEsteElemento in

            "0")
                if $modificado; then 
                    usuario=$respuestaGestor
                fi 
                ;;
            "1")
                if $respuestaGestor;
                then
                    tput sgr0 
                    clear
                    su $usuario
                    if [ $? -eq 1 ]; then
                        mensajeError "Usuario o contraseña incorrectos" 1 37 33 2 3 1 1
                        logearSSH
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

}
