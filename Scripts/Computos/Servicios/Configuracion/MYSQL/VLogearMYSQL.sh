#!/bin/bash

logearMySQL() {
    local usuario=""
    local contrasena=""
    local continuar=true

    iniciarPantallaNueva

    dibujarTxt "LOGUEARSE MYSQL" 44 7 0 7

    dibujarTxt "USUARIO:" 36 11 0 7
    dibujarEntradaTxt 36 12 31 false

    dibujarTxt "CONTRASEÑA:" 36 14 0 7
    dibujarEntradaTxt 36 15 31 true

    dibujarBoton "LOGUEARSE" 11 20 40 3
    dibujarBoton "VOLVER" 50 20 40 3

    while $continuar; 
    do
        siguientePos

        case $posDeEsteElemento in

            "0")
                usuario=$respuestaGestor
                ;;
            "1")
                contrasena=$respuestaGestor
                ;;

            "2")
                if $respuestaGestor;
                then
                    tput sgr0 
                    clear
                    mysql -u$usuario -p$contrasena 2> /dev/null
                    if [ $? -eq 1 ]; then
                        mensajeError "Usuario o contraseña equivocados" 1 37 33 2 3 1 1
                        logearMySQL
                    fi
                    continuar=false
                fi   
                ;;

            "3") 
                if $respuestaGestor;
                then
                    continuar=false
                fi   
                ;;  
        esac
    done

}