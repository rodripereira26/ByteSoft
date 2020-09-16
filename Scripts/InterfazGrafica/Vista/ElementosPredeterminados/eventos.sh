#!/bin/bash

hizoClick(){
    # $1 : lista de opciones[]    
    # indica si se presionó alguna tecla
    local seguirLeyendo=true
    local codigoRespuesta=""

    while $seguirLeyendo ; 
    do
        read -rsn1 press
        if [[ "$1" =~ "$press" ]]; then
            seguirLeyendo=false
        fi
    
        codigoRespuesta=$press

    done

    echo $codigoRespuesta
}
