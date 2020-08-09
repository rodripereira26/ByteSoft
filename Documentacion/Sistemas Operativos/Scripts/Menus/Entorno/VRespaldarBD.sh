#!/bin/bash

VRespaldarBD(){

    iniciarPantallaNueva
    dibujarTxt "Respaldar base de datos" 50 2

    dibujarTxt "¿Desea usar la ruta predeterminada?" 20 5
    dibujarSwitch 20 6 20 1 true
    dibujarTxt "O" 20 8

    dibujarTxt "Ruta respaldo" 20 10
    dibujarEntradaTxt 20 11 50 false
    dibujarTxt "" 20 12

    dibujarTxt "Usuario MySQL" 20 13
    dibujarEntradaTxt 20 14 50 false
    dibujarTxt "" 20 15

    dibujarBoton "Aceptar" 20 18 40 3
    dibujarBoton "Volver" 60 18 40 3

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
            VAvisoRegistrado "Respaldo realizado con éxito" 2 3
            VAvisoRegistrado "Se ha realizado $CANTB backup" 2
        else
            VAvisoRegistrado "Error al realizar el respaldo" 1
        fi    
    fi

    cerrarPantalla

}