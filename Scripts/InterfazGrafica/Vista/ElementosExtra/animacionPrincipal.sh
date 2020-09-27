#!/bin/bash

animacionTitulo() {
    #region [rgba(47, 0, 255, 0.10)] args
    # $1 : archivo de texto
    # $2 : posX
    # #3 : posY
    #endregion
    #region [rgba(170, 160, 26, 0.10)] variables 
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
# REVIEW - decidir si borrar
#region deprecated
animacionTitulo1() { 
    #region [rgba(47, 0, 255, 0.10)] args
    # $1 : archivo de texto
    # $2 : posX
    # #3 : posY
    #endregion

    numeroDeLineas=$(cat $1 | wc -l)
    let limiteSuperior=$numeroDeLineas-3
    let numeroDeBugeos=$numeroDeLineas*4

    for ((y=0;y<=$numeroDeLineas;y++)); 
    do
        let posY=$3+$y
        let posArchivo=$y+1
        tput cup $posY $2

        if [ $y -lt 2 -o $y -gt $limiteSuperior ]; 
        then
            tput setaf 4
        else
            tput setaf 5
        fi

        head -$posArchivo  $1 | tail -1

    done

    for ((x=0;x<$numeroDeBugeos;x++));
    do
        nroRandomLinea=$(shuf -i 1-$numeroDeLineas -n 1)
        nroRandomEjeX=$(shuf -i 1-6 -n 1)
        let tiempoRandom=$(shuf -i 0-100)
        let tiempoRandom=$tiempoRandom/75

        tput cup $nroRandomLinea $nroRandomEjeX

        if [ $y -lt 2 -o $y -gt $limiteSuperior ] ; 
        then
            tput setaf 4
        else
            tput setaf 5
        fi

        head -$nroRandomLinea  $1 | tail -1
        sleep $tiempoRandom
        tput cup $nroRandomLinea $2
        head -$nroRandomLinea  $1 | tail -1

    done
}

animacionTitulo2() {   
    #region [rgba(47, 0, 255, 0.10)] args

    # $1 : archivo de texto
    # $2 : posX
    # #3 : posY
    #endregion

    numeroDeLineas=$(cat $1 | wc -l)
    let limiteSuperior=$numeroDeLineas-3
    let numeroDeBugeos=$numeroDeLineas*3

    for ((y=0;y<=$numeroDeLineas;y++)); 
    do
        let posY=$3+$y
        let posArchivo=$y+1
        tput cup $posY $2

        if [ $y -lt 2 -o $y -gt $limiteSuperior ] ; 
        then
            tput setaf 28
        else
            tput setaf 5
        fi

        head -$posArchivo  $1 | tail -1

    done

    for ((x=0;x<$numeroDeBugeos;x++));
    do
        nroRandomLinea=$(shuf -i 1-$numeroDeLineas -n 1)
        nroRandomEjeX=$(shuf -i 1-6 -n 1)
        tiempoRandom=$(shuf -i 0-100)
        tiempoRandom=$tiempoRandom/100

        tput cup $nroRandomLinea $nroRandomEjeX

        if [ $y -lt 2 -o $y -gt $limiteSuperior ]; 
        then
            tput setaf 4
        else
            tput setaf 5
        fi

        head -$nroRandomLinea  $1 | tail -1
        sleep $tiempoRandom
        tput cup $nroRandomLinea $2
        head -$nroRandomLinea  $1 | tail -1

    done
}
#endregion