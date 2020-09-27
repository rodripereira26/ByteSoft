#!/bin/bash

declare -A historialPos

agregarUbicacion(){
    #region [rgba(47, 0, 255, 0.10)] args
    # $1 tipo de elemento 
    # $2 texto
    # $3 inicio en x
    # $4 inicio en y
    # $5 largo
    # $6 ancho
    # $7 color Bg
    # $8 color Fg
    #endregion
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
modificarElemento(){
    #region [rgba(47, 0, 255, 0.10)] args
    # $1 : posElemento 
    # $2 : caracteristicaPos
    # $3 : valor a modificar
    #endregion
    historialPos[$1,$2]=$3
}
tomarElemento(){
    #region [rgba(47, 0, 255, 0.10)] args
    # $1 : posElemento
    # $2 : caracteristica
    #endregion
    echo -n ${historialPos[$1,$2]}
}
