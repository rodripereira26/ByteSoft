#!/bin/bash

#
# Obligatorio ejecutar con root
#

. "/Scripts/InterfazGrafica/Grafica/disenoVentana.sh" 
. "/Scripts/InterfazGrafica/Logica/logicaVentana.sh" 
. "/Scripts/Computos/computos.sh"
. "/Scripts/ConfigurarEntorno/VPrincipalMenuConfigEntorno.sh"
. "/Scripts/ConfigurarEntorno/Logica/funciones.sh" 


Principal() {

    colorBgDefecto=7
    iniciarPantallaNueva

    dibujarTxt "MENU PRINCIPAL" 43 5 0

    dibujarTxt "4 -> ARRIBA" 11 7 0
    dibujarTxt "5 -> ENTER " 11 8 0
    dibujarTxt "6 -> ABAJO" 11 9 0
    
    dibujarBoton "CENTRO DE COMPUTOS" 11 10 80 3
    dibujarBoton "CONFIGURACIÓN DEL ENTORNO" 11 13 80 3
    dibujarBoton "DESINSTALAR ENTORNO" 11 16 80 3
    dibujarBoton "SALIR" 11 19 80 3
    
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

ejecutarMain() {

    local continuarCiclo=true

    while $continuarCiclo; 
    do
        Principal
        case $posDeEsteElemento in 

            "0")
                ejecutarComputos
                ;;

            "1")
                preguntaInstalacion
                colorBgDefecto=7
                ;;

            "2")
                preguntaDesinstalar
                ;;

            "3")
                continuarCiclo=false
                ;;

            *)
                ;;
        esac
        cerrarPantalla

    done

}

main() {

    tput sgr0
    clear
    tput civis
    animacionTitulo "InterfazGrafica/tituloByteSoft.txt" 10 10
    ejecutarMain
    clear

}

main