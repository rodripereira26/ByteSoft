#!/bin/bash

. "/Scripts/InterfazGrafica/Control/inicio.sh"

. "/Scripts/Computos/Logica/Respaldar.sh"
. "/Scripts/ABM/Menus/VAvisoRegistrado.sh"

#necesita root depende del caso de la direccion

VRespaldarDirectorios() {

    iniciarPantallaNueva
    dibujarTxt "RESPALDAR DIRECTORIOS" 41 4 0

    dibujarTxt "¿DESEA USAR LA RUTA PREDETERMINADA?" 20 10 0
    dibujarSwitch 20 11 20 1 true
    dibujarTxt "O" 20 12

    dibujarTxt "RUTA RESPALDO" 20 16 0
    dibujarEntradaTxt 20 17 50 false
    dibujarTxt "" 20 18


    dibujarBoton "GUARDAR" 11 21 40 3
    dibujarBoton "VOLVER" 50 21 40 3

    continuar=true
    usarPredeterminada=true
    guardarRespaldo=false
    ruta=""
    
    while $continuar; 
    do
        siguientePos

        case $posDeEsteElemento in

            "0")
                if $modificado; then 
                    usarPredeterminada=$respuestaGestor
                fi 
                ;;

            "1")
                if $modificado; then 
                    ruta=$respuestaGestor
                fi 
                ;;

            "2")
                if $respuestaGestor; 
                then 
                    if [ $ruta ] ||  $usarPredeterminada; 
                    then
                        guardarRespaldo=true
                        continuar=false
                    fi
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

ejecutarRespaldarDirectorio() {

    VRespaldarDirectorios

    if $guardarRespaldo; 
    then
        if $usarPredeterminada;
        then
            respaldoResp=$(respaldarDirectorios)
        else
            respaldoResp=$(respaldarDirectorios $ruta)
        fi

        if [ $respaldoResp = "0" ]; 
        then 
            mensajeError "RESPALDO REALIZADO CON ÉXITO" 2 37 33 2 3 2
        else
            mensajeError "ERROR AL REALIZAR EL RESPALDO" 1 37 33 2 3 1 1
        fi 
    
    fi
    cerrarPantalla
    
}