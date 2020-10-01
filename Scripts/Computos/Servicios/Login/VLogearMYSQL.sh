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

    dibujarBoton "INGRESAR" 11 20 40 3
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
                if $modificado; then 
                    contrasena=$respuestaGestor
                fi 
                ;;

            "2")
                if $respuestaGestor;
                then
                    tput sgr0 
                    clear
                    mysql -u$usuario -p$contrasena 2> /dev/null
                    if [ $? -eq 1 ]; then
                        mensajeError "USUARIO O CONTRASEÑA INCORRECTOS" 1 37 33 2 3 1 1
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