#!/bin/bash

VMenuEliminarUsuario(){
    iniciarPantallaNueva
    dibujarTxt "Elimina usuario" 80 2

    dibujarTxt "Ingresa el usuario" 20 5
    dibujarEntradaTxt 20 6 20 false

    dibujarBoton "Siguiente" 20 13 40 3
    dibujarBoton "Volver" 60 13 40 3

    local continuar=true
    usuarioAEliminar=""
    abrirSeleccionarGrupo=false
    
    while $continuar; do
        siguientePos
        case $posDeEsteElemento in 
            "0")
                usuarioAEliminar=$respuestaGestor
                ;;
            "1")
                if $respuestaGestor; then
                    if [ $(grep -E "^$usuarioAEliminar:" /etc/passwd) ]; then # busca el usuario en la lista de usuarios del sistema
                        continuar=false
                        abrirSeleccionarGrupo=true
                    fi
                fi
                ;;
            "2")
                if $respuestaGestor; then
                    continuar=false
                fi
                ;;

        esac
    done
}
ejecutarEliminarUsuario(){

    local continuar=true 
    while $continuar; do
        VMenuEliminarUsuario
        if $abrirSeleccionarGrupo; then
            ejecutarElegirGrupo
            if [ $(grep -E "^$usuarioAEliminar:.*::/home/USUARIOS/$grupoPerteneciente/$usuarioAEliminar" /etc/passwd) ]; then
                if [ $(borrarUsuario $usuarioAEliminar) = "0" ]; then
                    VAvisoRegistrado "Usuario eliminado correctamente" 10
                else
                    VAvisoRegistrado "Necesita permisos para borrar usuarios" 9
                fi
                
            else 
                VAvisoRegistrado "Usuario inexistente o el grupo no fue el correspondiente" 9
            fi
        else
            continuar=false
        fi
    done

    cerrarPantalla
}