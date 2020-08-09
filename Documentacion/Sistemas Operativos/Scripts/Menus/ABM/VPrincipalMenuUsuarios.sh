#!/bin/bash

. "Menus/ABM/VAvisoRegistrado.sh"
. "Menus/ABM/VEligeGrupo.sh"
. "Menus/ABM/VEliminarUsuario.sh"
. "Menus/ABM/VAgregarUsuario.sh"
. "Menus/ABM/VModificarUsuario.sh"

VMenuUsuarios(){
    iniciarPantallaNueva
    dibujarTxt "¿QUÉ DESEA HACER?" 50 2
    dibujarBoton "AGREGAR USUARIO" 20 4 80 3
    dibujarBoton "MODIFICAR USUARIO" 20 7 80 3
    dibujarBoton "ELIMINAR USUARIO" 20 10 80 3
    dibujarBoton "VOLVER" 20 13 80 3

    local continuar=true
    while $continuar; do
        siguientePos
        if $respuestaGestor; then
            continuar=false
        fi 
    done
}
ejecutarUsuario(){
    local continuarCiclo=true
    while $continuarCiclo; do
        VMenuUsuarios
        case $posDeEsteElemento in 
            "0")
                ejecutarVAgregarUsuario
                ;;
            "1")
                ejecutarModificarUsuario
                ;;
            "2")
                ejecutarEliminarUsuario
                ;;
            "3")
                continuarCiclo=false
                ;;
            *)
                ;;
        esac
        cerrarPantalla
    done
}