#!/bin/bash
VRespaldarDirectorios(){
    iniciarPantallaNueva
    dibujarTxt "Respaldar directorios" 50 2

    dibujarTxt "¿Desea usar la ruta predeterminada?" 20 5
    dibujarSwitch 20 6 20 1 true

    dibujarTxt "O" 20 8
    dibujarTxt "Ruta respaldo" 20 10
    dibujarEntradaTxt 20 11 50 false
    dibujarTxt "" 20 12


    dibujarBoton "Aceptar" 20 14 40 3
    dibujarBoton "Volver" 60 14 40 3
 
    continuar=true
    usarPredeterminada=true
    guardarRespaldo=false
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
                tput setab $colorBgDefecto
                borrarLinea 12
                dibujarTxt "'$ruta'" 20 12
                ;;

            "2")
                if $respuestaGestor; 
                then 
                    if [ $ruta ] ||  $usarPredeterminada ; 
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

            *)
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
            VAvisoRegistrado "Respaldo realizado con éxito" 2 3
        else
            VAvisoRegistrado "Error al realizar el respaldo" 1
        fi
    
    fi
    cerrarPantalla
    
}