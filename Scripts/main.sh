#!/bin/bash

#
# Para acceder a OTROS privilegios, ejecutar con root
# hay opciones que solo estan para usuarios no root
#

. "/Scripts/InterfazGrafica/Control/inicio.sh" 
. "/Scripts/Computos/VPrincipalComputos.sh"
. "/Scripts/ConfigurarEntorno/VPrincipalMenuConfigEntorno.sh"
. "/Scripts/ConfigurarEntorno/Logica/funciones.sh" 

Principal() {
    iniciarPantallaNueva 
    dibujarTxt "MENU PRINCIPAL" 43 5 0

    dibujarTxt "4 -> ARRIBA" 11 7 0
    dibujarTxt "5 -> ENTER " 11 8 0
    dibujarTxt "6 -> ABAJO" 11 9 0
    
    dibujarBoton "CENTRO DE COMPUTOS" 11 10 80 3

    if [ $EUID -eq 0 ];
    then
        dibujarBoton "CONFIGURACIÓN DEL ENTORNO" 11 13 80 3 #necesita root 
        dibujarBoton "DESINSTALAR ENTORNO" 11 16 80 3 #necesita root 
        dibujarBoton "SALIR" 11 19 80 3
    else

        dibujarBoton "SALIR" 11 13 80 3
    fi

    
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
        case $texto in 

            "CENTRO DE COMPUTOS")
                ejecutarComputos
                ;;

            "CONFIGURACIÓN DEL ENTORNO")
                preguntaInstalacion
                colorBgDefecto=7
                ;;

            "DESINSTALAR ENTORNO")
                preguntaDesinstalar
                ;;

            "SALIR")
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
    tput civis
    #animacionTitulo "/Scripts/InterfazGrafica/Vista/ElementosExtra/tituloByteSoft.txt" 10 10
    ejecutarMain
}

main