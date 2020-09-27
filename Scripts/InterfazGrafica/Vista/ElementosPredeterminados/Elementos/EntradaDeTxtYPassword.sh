#!/bin/bash

cargarEntradaTxt() {
    #region [rgba(47, 0, 255, 0.10)] args
    # $1 : posicion en x
    # $2 : posicion en y
    # $3 : largo
    # $4 : ancho
    # $5 : BG
    # $6 : FG
    # $7 : texto

    #endregion
    dibujarRectangulo $1 $2 $3 $4 $5 $6

    if [ "$7" ]; 
    then
        echo -n "$7" 1>&2
    fi
}

cargarEntradaTxtYPassword() {
    # $1 int imprimir texto

    if [ $1 -eq 0 ]; 
    then
        cargarEntradaTxt $posX $posY $largo $ancho $colorBg $colorFg $texto
    else
        cargarEntradaTxt $posX $posY $largo $ancho $colorBg $colorFg 
    fi  
}

gestorDeEntradaTexto() {
    # $1 : anterior
    # $2 : enter
    # $3 : siguiente
    # $4 :  int es password

    modificado=false
    respuestaGestor=""
    codigoRespuesta=""

    invertirColoresEntradaTxt $4 1>&2

    codigoRespuesta=$(hizoClick "$1 $2 $3")
    actualizarPosActual $codigoRespuesta $1 $3

    if [ "$codigoRespuesta" = "$2" ]; 
    then
        cargarEntradaTxtYPassword 1
        respuestaGestor=$(tomarDatoEntradaTxt $4)
        modificarElemento $posDeEsteElemento 1 $respuestaGestor
        moverAdelante
        modificado=true
    else 
        cargarEntradaTxtYPassword $4 1>&2
    fi
}

invertirColoresEntradaTxt() {
    # $1 int imprimir texto

    if [ $1 -eq 0 ] ; 
    then
        cargarEntradaTxt $posX $posY $largo $ancho $colorFg $colorBg $texto
    else
        cargarEntradaTxt $posX $posY $largo $ancho $colorFg $colorBg
    fi  
} 

tomarDatoEntradaTxt() {
    # $1 : int mostrarTextoAnterior
    local continuarLeyendo=true
    local entradaTXT=""

    while $continuarLeyendo ; 
    do
        read -rsn1 press

        if [ "$press" = $'\e' ]; then
            continuarLeyendo=false

        elif [ "$press" = $'\177' ]; then
            if [ "$entradaTXT" ]; then
                entradaTXT=${entradaTXT::-1}
            fi
        else
            entradaTXT="$entradaTXT$press"
        fi

        tput cup $posY $posX 1>&2
        printf "%${largo}s" 1>&2

        if [ "$1" = 0 ]; then
            tput cup $posY $posX 1>&2
            echo -n "$entradaTXT" 1>&2
        fi
    done
    echo -n $(echo -n "$entradaTXT") 
}
