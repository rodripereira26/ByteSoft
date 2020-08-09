#!/bin/bash

declare -A historialPos
declare -i proxPos=0
declare -i posActual=0

#
# funciones relacionadas con posActual
#

reiniciarDatos(){
    posActual=0
    proxPos=0
}
actualizarPosActual(){
    # $1 : tecla presionada

    if [ "$1" = "4" ]; then # ir atras
        moverAtras
    elif [ "$1" = "6" ]; then # ir adelante
        moverAdelante
    fi
}
moverAdelante(){
    if [ $(($posActual+1)) -lt $proxPos ]; then
        posActual=$posActual+1
    else
        posActual=0
    fi
}
moverAtras(){
    if [ $posActual -gt 0 ]; then
        posActual=$posActual-1
    else
        posActual=$((proxPos-1))
    fi
}
tomarPosActual(){
    echo -n $posActual
}
#
# Funciones relacionadas con historialPos
#
agregarUbicacion(){
    # $1 tipo de elemento 
    # $2 texto
    # $3 inicio en x
    # $4 inicio en y
    # $5 largo
    # $6 ancho
    # $7 color Bg
    # $8 color Fg
    
    historialPos[$proxPos,0]=$1
    historialPos[$proxPos,1]=$2
    historialPos[$proxPos,2]=$3
    historialPos[$proxPos,3]=$4
    historialPos[$proxPos,4]=$5
    historialPos[$proxPos,5]=$6
    historialPos[$proxPos,6]=$7
    historialPos[$proxPos,7]=$8
    ((proxPos++))
}   
tomarDelProximoElemento(){
    # $1 numero del elemento
    posDeEsteElemento=$1
    tipo=${historialPos[$1,0]}
    texto=${historialPos[$1,1]}
    posX=${historialPos[$1,2]}
    posY=${historialPos[$1,3]}
    largo=${historialPos[$1,4]}
    ancho=${historialPos[$1,5]}
    colorBg=${historialPos[$1,6]}
    colorFg=${historialPos[$1,7]}
}
gestorDeBoton(){
    respuestaGestor=false
    codigoRespuesta=""
    let BGplus=5
    let FGplus=$colorFg

    cargarBoton "$texto" $posX $posY $largo $ancho $BGplus $FGplus
    codigoRespuesta=$(hizoClick "4 5 6")
    actualizarPosActual $codigoRespuesta
    cargarBoton "$texto" $posX $posY $largo $ancho $colorBg $colorFg


    if [ "$codigoRespuesta" = "5" ]; then
        respuestaGestor=true
    fi
}
gestorDeEntradaTexto(){
    # $1 int es password

    respuestaGestor=""
    codigoRespuesta=""

    invertirColoresEntradaTxt $1 1>&2

    codigoRespuesta=$(hizoClick "4 5 6")
    actualizarPosActual $codigoRespuesta

    cargarEntradaTxtYPassword $1 1>&2
    
    if [ "$codigoRespuesta" = "5" ]; then
        cargarEntradaTxtYPassword 1
        tomarDatoEntradaTxt $1
        respuestaGestor=$inputTXT
        historialPos[$posDeEsteElemento,1]=$inputTXT

        if [ $datoTomado ]; then
            historialPos[$posDeEsteElemento,1]=$datoTomado # guarda la entrada en la lista
        fi
        moverAdelante
    fi
}
gestorDeSwitch(){
    let BGplus=5 # 18
    let FGplus=5 # 254

    codigoRespuesta=""
    respuestaGestor=false


    cargarSwitch $posX $posY $largo $ancho $BGplus $FGplus $texto

    codigoRespuesta=$(hizoClick "4 5 6")
    actualizarPosActual $codigoRespuesta
    
    cargarSwitch $posX $posY $largo $ancho $colorBg $colorFg $texto

    if [ "$codigoRespuesta" = "5" ]; then
        if [ "${historialPos[$posDeEsteElemento,1]}" = "true" ]; then
            historialPos[$posDeEsteElemento,1]="false"
            texto=false
        else
            historialPos[$posDeEsteElemento,1]="true"
            texto=true
        fi
        cargarSwitch $posX $posY $largo $ancho $colorBg $colorFg $texto
    fi

    if [ "$texto" = "true" ]; then
        respuestaGestor=true
    fi
}
invertirColoresEntradaTxt(){
    # $1 int imprimir texto
    if [ $1 -eq 0 ] ; then
        cargarEntradaTxt $posX $posY $largo $ancho $colorFg $colorBg $posDeEsteElemento
    else
        cargarEntradaTxt $posX $posY $largo $ancho $colorFg $colorBg 
    fi  
}
cargarEntradaTxtYPassword(){
    # $1 int imprimir texto
    if [ $1 -eq 0 ]; then
        cargarEntradaTxt $posX $posY $largo $ancho $colorBg $colorFg $posDeEsteElemento
    else
        cargarEntradaTxt $posX $posY $largo $ancho $colorBg $colorFg 
    fi  
}
dibujarRectangulo(){
    # $1 posicion en x
    # $2 posicion en y
    # $3 largo
    # $4 ancho
    # $5 BG
    # $6 FG
    
    tput setab $5 1>&2
    tput setaf $6 1>&2
    for ((y=0;y<$4;y++)); do
        let yPos=$2+$y
        tput cup $yPos $1 1>&2
        printf "%-$3s" " " 1>&2
        #for ((x=0;x<$3;x++)); do
        #   echo -n " "
        #done
    done
    tput cup $2 $1
}
tomarDatoEntradaTxt(){
    # $1 int mostrarTextoAnterior
    continuarLeyendo=true
    inputTXT=""
    while $continuarLeyendo ; do
        read -rn1 press
        if [ "$press" = "5" ]; then
            continuarLeyendo=false
        elif [ "$press" = $'\177' ]; then
            if [ $inputTXT ]; then
                inputTXT=${inputTXT::-1}
            fi
        else
            inputTXT="$inputTXT$press"
        fi
        cargarEntradaTxtYPassword 1
        if [ $1 -eq 0 ]; then
            echo -n $inputTXT
        fi
    done
}
hizoClick(){
    # $1 : lista de opciones
    
    # indica si se presionó alguna tecla
    local seguirLeyendo=true
    local codigoRespuesta=""

    while $seguirLeyendo ; do
        read -rsn1 -d: press
        for x in $1; do
            if [ "$press" = "$x" ]; then
                seguirLeyendo=false
            fi
        done
        codigoRespuesta=$press
    done
    echo $codigoRespuesta
}
cargarEntradaTxt(){
    # $1 posicion en x
    # $2 posicion en y
    # $3 largo
    # $4 ancho
    # $5 BG
    # $6 FG
    # $7 posActual # si se pasa por argumento se imprime el texto

    dibujarRectangulo $1 $2 $3 $4 $5 $6
    if [ $7 ]; then
        echo -n ${historialPos[$7,1]} 1>&2
    fi
}
cargarBoton(){
    # $1 el texto del boton
    # $2 es el inicio de la entrada de texto en x
    # $3 es el inicio de la entrada de texto en y
    # $4 largo del boton
    # $5 ancho del boton
    # $6 color background 
    # $7 color foreground
    
    declare -i mitadDeBotonAncho=($5+2*$3)/2
    declare -i mitadDeBotonLargo=($4-${#1}+2*$2)/2

    dibujarRectangulo $2 $3 $4 $5 $6 $7 
    tput cup $mitadDeBotonAncho $mitadDeBotonLargo 1>&2
    echo $1 1>&2
}
cargarSwitch(){
    # $1 : es el inicio de la entrada de texto en x
    # $2 : es el inicio de la entrada de texto en y
    # $3 : largo del switch
    # $4 : ancho del switch
    # $5 : color parte encendido 
    # $6 : color parte apagada 
    # $7 : estado de switch (true o false)

     # $1 posicion en x
    # $2 posicion en y
    # $3 largo
    # $4 ancho
    # $5 BG
    # $6 FG

    let mitadLargoSwitch=$3/2
    let posXSegundoRectangulo=$1+$mitadLargoSwitch

    if [ "$7" = "true" ]; then
        dibujarRectangulo $1 $2 $mitadLargoSwitch $4 7 2
        dibujarRectangulo $posXSegundoRectangulo $2 $mitadLargoSwitch $4 $5 7
    else 
        dibujarRectangulo $1 $2 $mitadLargoSwitch $4 $6 2 
        dibujarRectangulo $posXSegundoRectangulo $2 $mitadLargoSwitch $4 7 15
    fi

}