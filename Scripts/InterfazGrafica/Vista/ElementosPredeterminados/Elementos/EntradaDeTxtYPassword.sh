#!/bin/bash

cargarEntradaTxt() {

    # $1 posicion en x
    # $2 posicion en y
    # $3 largo
    # $4 ancho
    # $5 BG
    # $6 FG
    # $7 posActual # si se pasa por argumento se imprime el texto

    dibujarRectangulo $1 $2 $3 $4 $5 $6

    if [ $7 ]; 
    then
        echo -n $(tomarElemento $7 1) 1>&2
    fi
}

cargarEntradaTxtYPassword() {

    # $1 int imprimir texto

    if [ $1 -eq 0 ]; 
    then
        cargarEntradaTxt $posX $posY $largo $ancho $colorBg $colorFg $posDeEsteElemento
    else
        cargarEntradaTxt $posX $posY $largo $ancho $colorBg $colorFg 
    fi  
}

gestorDeEntradaTexto() {

    # $1 int es password
    modificado=false
    respuestaGestor=""
    codigoRespuesta=""

    invertirColoresEntradaTxt $1 1>&2

    codigoRespuesta=$(hizoClick "4 5 6")
    actualizarPosActual $codigoRespuesta

    if [ "$codigoRespuesta" = "5" ]; 
    then
        cargarEntradaTxtYPassword 1
        tomarDatoEntradaTxt $1
        respuestaGestor=$inputTXT
        modificarElemento $posDeEsteElemento 1 $inputTXT
        moverAdelante
        modificado=true
    else 
        cargarEntradaTxtYPassword $1 1>&2
    fi
}

invertirColoresEntradaTxt() {

    # $1 int imprimir texto

    if [ $1 -eq 0 ] ; 
    then
        cargarEntradaTxt $posX $posY $largo $ancho 5 0 $posDeEsteElemento
    else
        cargarEntradaTxt $posX $posY $largo $ancho 5 0 
    fi  
} 

tomarDatoEntradaTxt() {

    # $1 int mostrarTextoAnterior
    continuarLeyendo=true
    inputTXT=""

    while $continuarLeyendo ; 
    do
        read -rn1 press

        if [ "$press" = "5" ]; then
            continuarLeyendo=false

        elif [ "$press" = $'\177' ]; then
            if [ "$inputTXT" ]; then
                inputTXT=${inputTXT::-1}
            fi
        else
            inputTXT="$inputTXT$press"
        fi

        tput cup $posY $posX
        printf "%${largo}s"

        if [ $1 -eq 0 ]; then
            tput cup $posY $posX
            echo -n $inputTXT
        fi
    done
}
