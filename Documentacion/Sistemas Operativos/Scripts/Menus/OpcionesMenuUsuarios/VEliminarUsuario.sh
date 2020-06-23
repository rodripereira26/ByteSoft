#!/bin/bash

VMenuEliminarUsuario(){
    iniciarPantallaNueva
    dibujarTxt "ELIMINA USUARIO" 80 2

    dibujarTxt "INGRESA EL USUARIO" 20 5
    dibujarEntradaTxt 20 6 20 false

    dibujarBoton "SIGUIENTE" 20 13 40 3
    dibujarBoton "VOLVER" 60 13 40 3

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
            if [ $(grep -E "^$usuarioAEliminar:.*::$pathUSUARIOS/USUARIOS/$grupoPerteneciente/$usuarioAEliminar" /etc/passwd) ]; then
                if [ $(borrarUsuario $usuarioAEliminar) = "0" ]; then
                    VAvisoRegistrado "USUARIO ELIMINADO CORRECTAMENTE" 10
                else
                    VAvisoRegistrado "NECESITA PERMISOS PARA BORRAR USUARIOS" 9
                fi
                
            else 
                VAvisoRegistrado "USUARIO INEXISTENTE O EL GRUPO NO FUE EL CORRESPONDIENTE" 9
            fi
        else
            continuar=false
        fi
    done

    cerrarPantalla
}