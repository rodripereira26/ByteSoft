#!/bin/bash

. "Menus/ABM/VAvisoRegistrado.sh"
. "Menus/ABM/VEligeGrupo.sh"
. "Menus/ABM/VEliminarUsuario.sh"
. "Menus/ABM/VAgregarUsuario.sh"
. "Menus/ABM/VModificarUsuario.sh"

VMenuUsuarios(){
    iniciarPantallaNueva
    dibujarTxt "¿Qué desea hacer?" 50 2
    dibujarBoton "Agregar usuario" 20 4 80 3
    dibujarBoton "Modificar usuario" 20 7 80 3
    dibujarBoton "Eliminar usuario" 20 10 80 3
    dibujarBoton "Listar usuarios" 20 13 80 3
    dibujarBoton "Volver" 20 16 80 3

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
                clear
                ( echo "name:pswd:UID:GID:Comment:dir:shell" && egrep ".+:.+:.+:.+:.?:/home/USUARIOS" /etc/passwd ) | less
                
                ;;
            "4")
                continuarCiclo=false
                ;;
            *)
                ;;
        esac
        cerrarPantalla
    done
}