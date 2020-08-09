#!/bin/bash

VRespaldarBD(){

    iniciarPantallaNueva
    dibujarTxt "RESPALDAR BASE DE DATOS" 50 2

    dibujarTxt "¿DESEA USAR LA RUTA PREDETERMINADA?" 20 5
    dibujarSwitch 20 6 20 1 true
    dibujarTxt "O" 20 8

    dibujarTxt "RUTA RESPALDO" 20 10
    dibujarEntradaTxt 20 11 50 false
    dibujarTxt "" 20 12

    dibujarTxt "USUARIO MYSQL" 20 13
    dibujarEntradaTxt 20 14 50 false
    dibujarTxt "" 20 15

    dibujarBoton "ACEPTAR" 20 18 40 3
    dibujarBoton "VOLVER" 60 18 40 3

    user=""
    guardarRespaldo=false
    usarPredeterminada=true
    continuar=true
    ruta=""

    while $continuar; 
    do
        siguientePos

        case $posDeEsteElemento in

            "0")
                usarPredeterminada=$respuestaGestor
                ;;

            "1")
                ruta=$respuestaGestor
                ;;

            "2")
                user=$respuestaGestor
                ;;

            "3") 
                if $respuestaGestor; 
                then 
                    if [ $ruta ] ||  $usarPredeterminada ; 
                    then
                        guardarRespaldo=true
                        continuar=false

                    fi
                fi
                ;;

            "4")
                if $respuestaGestor; 
                then
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

    if $guardarRespaldo;
    then 
        if $usarPredeterminada;
        then
            respaldoBDResp=$(respaldarBD $user)
        else
            respaldoBDResp=$(respaldarBD $user $ruta)
        fi

        if [ $respaldoBDResp = "0" ]; 
        then 
            VAvisoRegistrado "RESPALDO REALIZADO CON ÉXITO" 2 3
            VAvisoRegistrado "SE HAN REALIZADO $CANTB BACKUP" 2
        else
            VAvisoRegistrado "ERROR AL REALIZAR EL RESPALDO" 1
        fi    
    fi

    cerrarPantalla

}