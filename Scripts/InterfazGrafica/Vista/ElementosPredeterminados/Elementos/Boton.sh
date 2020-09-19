#!/bin/bash

gestorDeBoton() {

    respuestaGestor=false
    codigoRespuesta=""

    let BGplus=5
    let FGplus=$colorFg

    cargarBoton "$texto" $posX $posY $largo $ancho $BGplus $FGplus
    codigoRespuesta=$(hizoClick "4 5 6")

    actualizarPosActual $codigoRespuesta
    cargarBoton "$texto" $posX $posY $largo $ancho $colorBg $colorFg


    if [ "$codigoRespuesta" = "5" ]; 
    then
        respuestaGestor=true
    fi
}

cargarBoton() {
    #region args
    # $1 el texto del boton
    # $2 es el inicio de la entrada de texto en x
    # $3 es el inicio de la entrada de texto en y
    # $4 largo del boton
    # $5 ancho del boton
    # $6 color background 
    # $7 color foreground
    #endregion

    declare -i mitadDeBotonAncho=($5+2*$3)/2
    declare -i mitadDeBotonLargo=($4-${#1}+2*$2)/2
    dibujarRectangulo $2 $3 $4 $5 $6 $7 
    tput cup $mitadDeBotonAncho $mitadDeBotonLargo 1>&2
    echo $1 1>&2
}