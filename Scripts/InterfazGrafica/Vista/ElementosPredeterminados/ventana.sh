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
    cargarRectangulo $1 $2 $3 $4
    tput cup $2 $1
}

cargarRectangulo(){
    # $1 posicion en x
    # $2 posicion en y
    # $3 largo
    # $4 ancho

    tput cup $2 $1 1>&2
    printf "%-$3s" " " 1>&2
    if (( $4 > 1 )); then
        cargarRectangulo $1 $(($2 + 1)) $3 $(($4 - 1))
    fi
}
