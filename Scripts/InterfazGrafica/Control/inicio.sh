#!/bin/bash


declare -i proxPos=0
declare -i posActual=0


. "/Scripts/InterfazGrafica/Control/registroElementos.sh"
. "/Scripts/InterfazGrafica/datosElementos.sh"
reiniciarDatos() {
    
    posActual=0
    proxPos=0
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

siguientePos() {
    tomarDelProximoElemento $posActual

    case  $tipo in 

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

borrarLinea() {

    # $1 : nro de linea

    nroCols=$(tput cols)
    tput cup $1 0

    for ((n=0;n<$nroCols;n++)); 
    do
        echo -n " "
    done
}

cerrarPantalla() {

    reiniciarDatos
    tput setab $colorBgDefecto
    tput clear
    tput cnorm
    tput sgr0
}
