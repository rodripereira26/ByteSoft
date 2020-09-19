#!/bin/bash

declare -i proxPos=0
declare -i posActual=0

. "/Scripts/InterfazGrafica/Control/registroElementos.sh"
. "/Scripts/InterfazGrafica/datosElementos.sh"



#region funciones relacionadas con variables
reiniciarDatos() {
    posActual=0
    proxPos=0
    historialPos=()
}

moverAdelante() {

    if [ $(($posActual+1)) -lt $proxPos ]; 
    then
        posActual=$posActual+1
    else
        posActual=0
    fi

}

moverAtras() {
    if [ $posActual -gt 0 ]; 
    then
        posActual=$posActual-1
    else
        posActual=$((proxPos-1))
    fi
}

actualizarPosActual() {

    # $1 : tecla presionada

    if [ "$1" = "4" ]; 
    then # ir atras
        moverAtras
    elif [ "$1" = "6" ]; 
    then # ir adelante
        moverAdelante
    fi
}
#endregion

iniciarPantallaNueva() {
    cerrarPantalla
    tput civis
}

cerrarPantalla() {

    # -Borra los datos guardados y reinicia pantalla-
    reiniciarDatos
    tput setab $colorBgDefecto
    tput clear
    tput cnorm
    tput sgr0
}

siguientePos() {
    # -Se mueve hacia el siguiente elemento-
    tomarDelProximoElemento $posActual

    case $tipo in 

        "BTN")
            gestorDeBoton
            ;;

        "INPTXT")
            gestorDeEntradaTexto 0
            ;;

        "PWTXT")
            gestorDeEntradaTexto 1
            ;;

        "SWITCH")
            gestorDeSwitch
            ;;
        *)
            ;;
    esac

}