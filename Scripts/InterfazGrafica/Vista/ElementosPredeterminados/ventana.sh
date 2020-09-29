#!/bin/bash

declare -i colorBgDefecto=7

#region imports
. "/Scripts/InterfazGrafica/Vista/ElementosPredeterminados/elementosImports.sh"
. "/Scripts/InterfazGrafica/Vista/ElementosExtra/elementosExtraImports.sh"
. "/Scripts/InterfazGrafica/Vista/ElementosPredeterminados/eventos.sh"
#endregion

dibujarRectangulo() {
    #region [rgba(47, 0, 255, 0.10)] args
    # $1 posicion en x
    # $2 posicion en y
    # $3 largo
    # $4 ancho
    # $5 BG
    # $6 FG
    #endregion

    tput setab $5
    tput setaf $6

    cargarRectangulo $1 $2 $3 $4
    tput cup $2 $1
}

cargarRectangulo(){
    #region [rgba(47, 0, 255, 0.10)] args
    # $1 posicion en x
    # $2 posicion en y
    # $3 largo
    # $4 ancho
    #endregion

    tput cup $2 $1 1>&2
    printf "%-$3s" " " 1>&2
    if (( $4 > 1 )); then
        cargarRectangulo $1 $(($2 + 1)) $3 $(($4 - 1))
    fi
}
