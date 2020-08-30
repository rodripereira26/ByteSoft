#!/bin/bash

. "/Scripts/InterfazGrafica/Control/inicio.sh" 

VElegirGrupo(){
    local continuar=true
    grupoPerteneciente=""
    
    iniciarPantallaNueva
    dibujarTxt "Ingresar cargo" 80 2
    dibujarBoton "Administracion" 20 7 80 3
    dibujarBoton "Medico" 20 10 80 3 
    


    while $continuar;
    do
        siguientePos

        case $posDeEsteElemento in

            "0")
                if $respuestaGestor; 
                then
                    grupoPerteneciente="ADMINISTRADORES"
                    continuar=false
                fi
                ;;

            "1")
                if $respuestaGestor; 
                then
                    grupoPerteneciente="MEDICOS"
                    continuar=false
                fi
                ;;
        esac
    done
}

ejecutarElegirGrupo() {

    VElegirGrupo
    cerrarPantalla
    
}