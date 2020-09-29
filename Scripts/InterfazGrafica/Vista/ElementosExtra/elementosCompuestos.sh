#!/bin/bash

pregunta() {
    #region [rgba(47, 0, 255, 0.10)] args
    # -Hace una pregunta y da por respueta si-no-
    # $1: Texto
    # $2: ColorBG
    # $3: Posición en x del texto
    # $4: Posición en y del texto
    # $5: Sleep
    # $6: ColorFG
    # $7: ColorBG texto
    #endregion

    colorBgDefecto=0
    iniciarPantallaNueva                      
    dibujarRectangulo 11 8 80 20 "$2" "$6"
    dibujarTxt "$1" "$3" "$4" 0 "$7"
    dibujarBoton "SÍ" 25 22 20 3
    dibujarBoton "NO" 58 22 20 3

}

mensajeError() {
    #region [rgba(47, 0, 255, 0.10)] args
    # -Muestra un mensaje de error por x tiempo-
    # $1: Texto
    # $2: ColorBG
    # $3: Posición en x del texto
    # $4: Posición en y del texto
    # $5: Sleep
    # $6: ColorFG
    # $7: ColorBG texto
    #endregion

    dibujarRectangulo 31 32 40 4 "$2" "$6"
    dibujarTxt "$1" "$3" "$4" 0 "$7"

    if [ "$5" ]; 
    then
        sleep $5
    else
        sleep 2
    fi

}

