#!/bin/bash

animacionTitulo() {
    #region [rgba(47, 0, 255, 0.10)] args y variables 
    # $1 : archivo de texto
    # $2 : posX
    # #3 : posY

    numeroDeLineas=$(cat $1 | wc -l)
    let numeroDeLineas=$numeroDeLineas+1
    let limiteSuperior=$numeroDeLineas-3
    let numeroDeBugeos=31
    #endregion
    for ((x=0;x<$numeroDeBugeos;x++));
    do
        #region for variables
        let nroRandomLinea=$(shuf -i 1-$numeroDeLineas -n 1)
        let nroRandomEjeX=$(shuf -i 1-3 -n 1)
        tiempoRandom=$(shuf -i 0-10 -n 1)
        tiempoRandom=$(echo $tiempoRandom/60 | bc -l)
        let lugarTPUT=$nroRandomLinea+$3-1
        #endregion
        
        if [ $nroRandomLinea -lt 2 -o $nroRandomLinea -gt $limiteSuperior ]; 
        then
            tput setaf 4
        else
            tput setaf 5
        fi
        #region mover linea a un lado
        cargarRectangulo 0 $lugarTPUT $(tput cols) 1
        tput cup $lugarTPUT $nroRandomEjeX
        head -$nroRandomLinea  $1 | tail -1
        sleep $tiempoRandom
        #endregion 
        #region mover linea a su posicion normal
        cargarRectangulo 0 $lugarTPUT $(tput cols) 1
        tput cup $lugarTPUT $2
        head -$nroRandomLinea  $1 | tail -1
        #endregion
    done

    sleep 1
}