#!/bin/bash
VRespaldarDirectorios(){
    iniciarPantallaNueva
    dibujarTxt "CONFIGURACION DEL ENTORNO" 80 2

    dibujarTxt "DESEA USAR LA RUTA PREDETERMIDA?" 20 5
    dibujarSwitch 20 6 20 1 true

    dibujarTxt "O" 20 8
    dibujarTxt "RUTA RESPALDO" 20 10
    dibujarEntradaTxt 20 11 50 false
    dibujarTxt "" 20 12


    dibujarBoton "ACEPTAR" 20 14 40 3
    dibujarBoton "VOLVER" 60 14 40 3
 
    continuar=true
    usarPredeterminada=true
    guardarRespaldo=false
    ruta=""
    while $continuar; do
        siguientePos
        case $posDeEsteElemento in
            "0")
                usarPredeterminada=$respuestaGestor
                ;;
            "1")
                ruta=$respuestaGestor
                tput setab $colorBgDefecto
                borrarLinea 12
                dibujarTxt "'$ruta'" 20 12
                ;;
            "2")
                if $respuestaGestor; then 
                    if [ $ruta ] ||  $usarPredeterminada ; then
                        guardarRespaldo=true
                        continuar=false
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
ejecutarRespaldarDirectorio(){
    VRespaldarDirectorios
    if $guardarRespaldo; then
        if $usarPredeterminada;then
            respaldoResp=$(respaldarDirectorios)
        else
            respaldoResp=$(respaldarDirectorios $ruta)
        fi
        if [ $respaldoResp = "0" ]; then 
            VAvisoRegistrado "RESPALDO REALIZADO CON ÉXITO" 10
        else
            VAvisoRegistrado "ERROR AL REALIZAR EL RESPALDO" 9
        fi
    
    fi
    cerrarPantalla
}