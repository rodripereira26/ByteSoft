#!/bin/bash

. "/Scripts/InterfazGrafica/Grafica/disenoVentana.sh" 

. "/Scripts/Computos/Servicios/Configuracion/VConfigMySQL.sh"

VMenuServicioConf(){

    iniciarPantallaNueva
    dibujarTxt "CONFIGURACIÓN DE SERVICIOS (EN CONSTRUCCIÓN)" 42 3 0

    dibujarTxt "4 -> ARRIBA" 11 6 0
    dibujarTxt "5 -> ENTER " 11 7 0
    dibujarTxt "6 -> ABAJO" 11 8 0

    dibujarBoton "SSH" 11 9 80 3
    dibujarBoton "MYSQL" 11 12 80 3
    dibujarBoton "Volver" 11 15 80 3

    local continuar=true

    while $continuar; 
    do
        siguientePos

        if $respuestaGestor; 
        then
            continuar=false
        fi 
    done
}

ejecutarMenuServicioConf() {

    local continuarCiclo=true

    while $continuarCiclo; 
    do
        VMenuServicioConf

        case $posDeEsteElemento in 
            
            "0")
                
                ;;

            "1")
                ;;

            "2")

                continuarCiclo=false
                ;;
            *)
                ;;
        esac
        
        cerrarPantalla
    done

}