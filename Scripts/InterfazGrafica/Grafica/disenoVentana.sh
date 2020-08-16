#!/bin/bash

. "InterfazGrafica/Logica/logicaVentana.sh"

declare -i colorBgDefecto=7

borrarLinea() {

    # $1 : nro de linea

    nroCols=$(tput cols)
    tput cup $1 0

    for ((n=0;n<$nroCols;n++)); 
    do
        echo -n " "
    done
}
animacionTitulo() {

    # $1 : archivo de texto
    # $2 : posX
    # #3 : posY

    numeroDeLineas=$(cat $1 | wc -l)

    let numeroDeLineas=$numeroDeLineas+1
    let limiteSuperior=$numeroDeLineas-3
    let numeroDeBugeos=31
    
    for ((x=0;x<$numeroDeBugeos;x++));
    do
        let nroRandomLinea=$(shuf -i 1-$numeroDeLineas -n 1)
        let nroRandomEjeX=$(shuf -i 1-3 -n 1)
        tiempoRandom=$(shuf -i 0-10 -n 1)
        tiempoRandom=$(echo $tiempoRandom/60 | bc -l)
        let lugarTPUT=$nroRandomLinea+$3-1

        if [ $nroRandomLinea -lt 2 -o $nroRandomLinea -gt $limiteSuperior ]; 
        then
            tput setaf 4
        else
            tput setaf 5
        fi
        
        borrarLinea $lugarTPUT
        tput cup $lugarTPUT $nroRandomEjeX
        head -$nroRandomLinea  $1 | tail -1
        sleep $tiempoRandom

        borrarLinea $lugarTPUT
        tput cup $lugarTPUT $2
        head -$nroRandomLinea  $1 | tail -1
    done

    sleep 1
}

animacionTitulo1() { 

    # $1 : archivo de texto
    # $2 : posX
    # #3 : posY

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

    # $1 : archivo de texto
    # $2 : posX
    # #3 : posY

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

iniciarPantallaNueva() {

    cerrarPantalla
    tput civis
}

cerrarPantalla() {

    reiniciarDatos
    tput setab $colorBgDefecto
    tput clear
    tput cnorm
    tput sgr0
}

dibujarTxt() {

    # $1 el texto a imprimir
    # $2 es el inicio de la entrada de texto en x
    # $3 es el inicio de la entrada de texto en y 
    # $4 color foreground (opcional)
    # $5 color background (opcional)

    let colorFg=7
    let colorBg=$colorBgDefecto

    if [ "$4" ]; 
    then 
        colorFg=$4
    fi

    if [ "$5" ]; 
    then
        colorBg=$5
    fi

    tput cup $3 $2
    tput setaf $colorFg
    tput setab $colorBg
    echo -n $1

}

dibujarEntradaTxt() { 

    # $1 : es el inicio de la entrada de texto en x 
    # $2 : es el inicio de la entrada de texto en y 
    # $3 : es el largo de la entrada 
    # $4 : int es password

    let colorBg=0 
    let colorFg=5
            
    dibujarRectangulo $1 $2 $3 1 $colorBg $colorFg

    if $4; 
    then
        agregarUbicacion "PWTXT" "" $1 $2 $3 1 $colorBg $colorFg 
    else
        agregarUbicacion "INPTXT" "" $1 $2 $3 1 $colorBg $colorFg 
    fi
}

dibujarSwitch() {

    # $1 : es el inicio de la entrada de texto en x
    # $2 : es el inicio de la entrada de texto en y
    # $3 : largo del switch
    # $4 : ancho del switch
    # $5 : estado inicial (true o false)
    # $6 : color encendido (opcional)
    # $7 : color apagada  (opcional)
    
    let colorEncendido=2
    let colorApagado=1

    if [ "$6" ]; 
    then
        colorEncendido=2
    fi

    if [ "$7" ]; 
    then
        colorApagado=1
    fi

    cargarSwitch "$1" $2 $3 $4 $colorEncendido $colorApagado "$5" # color FG pasa a ser color cuando se apaga
    agregarUbicacion "SWITCH" "$5" $1 $2 $3 $4 $colorEncendido $colorApagado 
}

dibujarBoton(){
    # $1 : el texto del boton
    # $2 : es el inicio de la entrada de texto en x
    # $3 : es el inicio de la entrada de texto en y
    # $4 : lar5go del boton
    # $5 : ancho del boton
    # $6 : color background 
    # $7 : color foreground
    
    let colorBg=4      
    let colorFg=7   

    if [ "$6" ]; 
    then
        colorBg=$6
    fi

    if [ "$7" ]; 
    then 
        colorFg=$7
    fi

    cargarBoton "$1" $2 $3 $4 $5 $6 $colorBg $colorFg 
    agregarUbicacion "BTN" "$1" $2 $3 $4 $5 $colorBg $colorFg
}

siguientePos() {

    tomarDelProximoElemento $posActual

    case  $tipo in 

        "BTN")
            gestorDeBoton
            ;;

        "INPTXT")
            gestorDeEntradaTexto 0
            ;;

        "PWTXT")
            gestorDeEntradaTexto 1
            ;;

        "SWITCH")
            gestorDeSwitch
            ;;
        *)
            ;;
    esac
}

mensajeError() {

    # $1: Texto
    # $2: ColorBG
    # $3: Posición en x del texto
    # $4: Posición en y del texto
    # $5: Sleep
    # $6: ColorFG
    # $7: ColorBG texto

    dibujarRectangulo 31 32 40 4 "$2" "$6"
    dibujarTxt "$1" "$3" "$4" 0 "$7"

    if [ "$5" ]; 
    then
        sleep $5
    else
        sleep 2
    fi

}

pregunta() {

    # $1: Texto
    # $2: ColorBG
    # $3: Posición en x del texto
    # $4: Posición en y del texto
    # $5: Sleep
    # $6: ColorFG
    # $7: ColorBG texto

    colorBgDefecto=0
    iniciarPantallaNueva                      
    dibujarRectangulo 11 8 80 20 "$2" "$6"
    dibujarTxt "$1" "$3" "$4" 0 "$7"
    dibujarBoton "SÍ" 25 22 20 3
    dibujarBoton "NO" 58 22 20 3

}