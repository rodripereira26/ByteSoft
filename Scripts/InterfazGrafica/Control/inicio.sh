#!/bin/bash

declare -i proxPos=0
declare -i posActual=0

. "/Scripts/InterfazGrafica/Control/registroElementos.sh"
. "/Scripts/InterfazGrafica/datosElementos.sh"



#region funciones relacionadas con variables
reiniciarDatos() {
    posActual=0
    proxPos=0
    historialPos=()
}

moverAdelante() {

    if [ $(($posActual+1)) -lt $proxPos ]; 
    then
        posActual=$posActual+1
    else
        posActual=0
    fi

}

moverAtras() {
    if [ $posActual -gt 0 ]; 
    then
        posActual=$posActual-1
    else
        posActual=$((proxPos-1))
    fi
}

actualizarPosActual() {
    # $1 : tecla presionada
    # $2 : anterior 
    # $3 : siguiente

    if [ "$1" = "$2" ]; 
    then # ir atras
        moverAtras
    elif [ "$1" = "$3" ]; 
    then # ir adelante
        moverAdelante
    fi
}
#endregion

iniciarPantallaNueva() {
    cerrarPantalla
    tput civis
}

cerrarPantalla() {

    # -Borra los datos guardados y reinicia pantalla-
    reiniciarDatos
    tput setab $colorBgDefecto
    tput clear
    tput cnorm
    tput sgr0
}

siguientePos() {
    # -Se mueve hacia el siguiente elemento-
    tomarDelProximoElemento $posActual

    case $tipo in 

        "BTN")
            gestorDeBoton "4" "5" "6"
            ;;

        "INPTXT")
            gestorDeEntradaTexto "4" "5" "6" 0
            ;;

        "PWTXT")
            gestorDeEntradaTexto "4" "5" "6" 1
            ;;

        "SWITCH")
            gestorDeSwitch "4" "5" "6"
            ;;
        *)
            ;;
    esac
}
probarFuncionEjecucionLocal(){
    #region descripcion
    # cada vez que se ejecuta un archivo 
    # en terminal o en vscode lo ejecuta
    # solo a ese archivo ignorando las otras 
    # $1 : nombre de la funcion
    # $2 : nombre del archivo actual
    #endregion
    
    if [ "$1" ]; then
        if [ -z "$BASH_ARGV0" ]; then 
            BASH_ARGV0=$0
        fi
        if [ $(basename "$BASH_ARGV0") = "$2" ]; then # para ejecutar script actual se pasa por parametro ejecutar
            $1
        fi
    fi
}