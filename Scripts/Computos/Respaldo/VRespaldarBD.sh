#!/bin/bash

. "/Scripts/InterfazGrafica/Control/inicio.sh"

. "/Scripts/Computos/Logica/Respaldar.sh"

#necesita root

VRespaldarBD() {
    #region [rgba(170, 160, 26, 0.10)] variables 
    local continuar=true
    user=""
    guardarRespaldo=false
    usarPredeterminada=true
    ruta=""
    #endregion
    
    iniciarPantallaNueva
    dibujarTxt "RESPALDAR BASE DE DATOS" 42 3 0

    dibujarTxt "¿DESEA USAR LA RUTA PREDETERMINADA?" 20 9 0
    dibujarSwitch 20 10 20 1 true
    dibujarTxt "O" 20 11 

    dibujarTxt "RUTA RESPALDO" 20 13 0
    dibujarEntradaTxt 20 14 50 false
    dibujarTxt "" 20 15

    dibujarTxt "USUARIO MYSQL" 20 17 0
    dibujarEntradaTxt 20 18 50 false
    dibujarTxt "" 20 19

    dibujarBoton "GUARDAR" 11 23 40 3
    dibujarBoton "VOLVER" 50 23 40 3


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
                if $modificado; then 
                    user=$respuestaGestor
                fi 
                ;;

            "3") 
                if $respuestaGestor; 
                then 
                    if [ $ruta ] ||  $usarPredeterminada; 
                    then
                        tput cup 27 11
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
        esac
    done

}

ejecutarRespaldarBD() {

    VRespaldarBD

    if $guardarRespaldo;
    then 
        if $usarPredeterminada;
        then
            respaldoBDResp=$(respaldarBD $user)
        else
            respaldoBDResp=$(respaldarBD $user $ruta)
        fi

        case $respaldoBDResp in 

            "0")
                mensajeError "RESPALDO REALIZADO CON ÉXITO" 2 37 33 2 3 2
                ;;
            "1")
                mensajeError "ERROR AL REALIZAR EL RESPALDO" 1 37 33 2 3 1 1
                ;;
        esac
 
    fi

    cerrarPantalla
}