#!/bin/bash

declare -i colorBgDefecto=7

. "/Scripts/InterfazGrafica/Vista/ElementosPredeterminados/elementosImports.sh"
. "/Scripts/InterfazGrafica/Vista/ElementosExtra/elementosExtraImports.sh"
. "/Scripts/InterfazGrafica/Vista/ElementosPredeterminados/eventos.sh"

dibujarRectangulo() {

    # $1 posicion en x
    # $2 posicion en y
    # $3 largo
    # $4 ancho
    # $5 BG
    # $6 FG
    
    tput setab $5
    tput setaf $6

    for ((y=0;y<$4;y++)); 
    do
        let yPos=$2+$y
        tput cup $yPos $1 1>&2
        printf "%-$3s" " " 1>&2
    done

    tput cup $2 $1
}