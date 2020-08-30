#!/bin/bash

cargarSwitch() {
    # $1 : es el inicio de la entrada de texto en x
    # $2 : es el inicio de la entrada de texto en y
    # $3 : largo del switch
    # $4 : ancho del switch
    # $5 : color parte encendido 
    # $6 : color parte apagada 
    # $7 : estado de switch (true o false)

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

    let BGplus=5 # 18
    let FGplus=5 # 254

    codigoRespuesta=""
    respuestaGestor=false


    cargarSwitch $posX $posY $largo $ancho $BGplus $FGplus $texto

    codigoRespuesta=$(hizoClick "4 5 6")
    actualizarPosActual $codigoRespuesta
    
    cargarSwitch $posX $posY $largo $ancho $colorBg $colorFg $texto

    if [ "$codigoRespuesta" = "5" ]; 
    then
        if [ "${historialPos[$posDeEsteElemento,1]}" = "true" ]; 
        then
            historialPos[$posDeEsteElemento,1]="false"
            texto=false
        else
            historialPos[$posDeEsteElemento,1]="true"
            texto=true
        fi

        cargarSwitch $posX $posY $largo $ancho $colorBg $colorFg $texto

    fi

    if [ "$texto" = "true" ]; 
    then
        respuestaGestor=true
    fi
}
