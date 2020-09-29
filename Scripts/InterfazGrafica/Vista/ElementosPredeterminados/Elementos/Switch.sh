#!/bin/bash

cargarSwitch() {
    #region [rgba(47, 0, 255, 0.10)] args
    # $1 : es el inicio de la entrada de texto en x
    # $2 : es el inicio de la entrada de texto en y
    # $3 : largo del switch
    # $4 : ancho del switch
    # $5 : color parte encendido 
    # $6 : color parte apagada 
    # $7 : estado de switch (true o false)
    #endregion

    let mitadLargoSwitch=$3/2
    let posXSegundoRectangulo=$1+$mitadLargoSwitch

    if [ "$7" = "true" ]; 
    then
        dibujarRectangulo $1 $2 $mitadLargoSwitch $4 0 2
        dibujarRectangulo $posXSegundoRectangulo $2 $mitadLargoSwitch $4 $5 0
    else 
        dibujarRectangulo $1 $2 $mitadLargoSwitch $4 $6 2 
        dibujarRectangulo $posXSegundoRectangulo $2 $mitadLargoSwitch $4 0 15
    fi
}

gestorDeSwitch() {
    # $1 : anterior
    # $2 : enter
    # $3 : siguiente

    let BGplus=5 # 18
    let FGplus=5 # 254
    codigoRespuesta=""
    respuestaGestor=false
    modificado=false

    cargarSwitch $posX $posY $largo $ancho $BGplus $FGplus $texto

    codigoRespuesta=$(hizoClick "$1 $2 $3")
    actualizarPosActual $codigoRespuesta $1 $3
    
    cargarSwitch $posX $posY $largo $ancho $colorBg $colorFg $texto

    if [ "$codigoRespuesta" = "$2" ]; 
    then
        if [ "$(tomarElemento $posDeEsteElemento 1)" = "true" ];
        then
            texto=false
        else
            texto=true
        fi
        modificarElemento $posDeEsteElemento 1 "$texto"
        modificado=true
        cargarSwitch $posX $posY $largo $ancho $colorBg $colorFg $texto

    fi
    if [ "$texto" = "true" ]; 
    then
        respuestaGestor=true
    fi
}
