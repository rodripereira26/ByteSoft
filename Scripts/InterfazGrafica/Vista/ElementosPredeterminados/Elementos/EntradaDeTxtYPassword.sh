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
        echo -n ${historialPos[$7,1]} 1>&2
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

    respuestaGestor=""
    codigoRespuesta=""

    invertirColoresEntradaTxt $1 1>&2

    codigoRespuesta=$(hizoClick "4 5 6")
    actualizarPosActual $codigoRespuesta

    cargarEntradaTxtYPassword $1 1>&2
    
    if [ "$codigoRespuesta" = "5" ]; 
    then
        cargarEntradaTxtYPassword 1
        tomarDatoEntradaTxt $1
        respuestaGestor=$inputTXT
        historialPos[$posDeEsteElemento,1]=$inputTXT

        if [ $datoTomado ]; 
        then
            historialPos[$posDeEsteElemento,1]=$datoTomado # guarda la entrada en la lista
        fi

        moverAdelante
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

        if [ "$press" = "5" ]; 
        then
            continuarLeyendo=false

        elif [ "$press" = $'\177' ]; 
            then
            if [ $inputTXT ]; 
            then
                inputTXT=${inputTXT::-1}
            fi
        else
            inputTXT="$inputTXT$press"
        fi

        cargarEntradaTxtYPassword 1

        if [ $1 -eq 0 ]; 
        then
            echo -n $inputTXT
        fi
    done
}