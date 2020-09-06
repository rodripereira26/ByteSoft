#!/bin/bash

hizoClick(){

    # $1 : lista de opciones
    
    # indica si se presionó alguna tecla
    local seguirLeyendo=true
    local codigoRespuesta=""

    while $seguirLeyendo ; 
    do
        read -rsn1 -d: press
        for x in $1; 
        do
            if [ "$press" = "$x" ]; 
            then
                seguirLeyendo=false
            fi
        done

        codigoRespuesta=$press

    done

    echo $codigoRespuesta
}