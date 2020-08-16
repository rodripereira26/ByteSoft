#!/bin/bash

. "ABM/Menus/VAvisoRegistrado.sh"
. "ABM/Menus/VEligeGrupo.sh"
. "ABM/Menus/VEliminarUsuario.sh"
. "ABM/Menus/VAgregarUsuario.sh"
. "ABM/Menus/VModificarUsuario.sh"
. "InterfazGrafica/Grafica/disenoVentana.sh" 
. "InterfazGrafica/Logica/logicaVentana.sh" 

VMenuUsuarios() {

    iniciarPantallaNueva

    dibujarTxt "¿QUÉ DESEA HACER?" 42 5 0
    dibujarTxt "4 -> ARRIBA" 11 7 0
    dibujarTxt "5 -> ENTER " 11 8 0
    dibujarTxt "6 -> ABAJO" 11 9 0
    
    
    dibujarBoton "AGREGAR USUARIO" 11 10 80 3
    dibujarBoton "MODIFICAR USUARIO" 11 13 80 3
    dibujarBoton "ELIMINAR USUARIO" 11 16 80 3
    dibujarBoton "LISTAR USUARIOS (Q PARA SALIR)" 11 19 80 3
    dibujarBoton "VOLVER" 11 22 80 3

    local continuar=true

    while $continuar; 
    do
        siguientePos

        if $respuestaGestor; 
        then
            continuar=false
        fi 

    done

}

ejecutarUsuario() {

    local continuarCiclo=true

    while $continuarCiclo; 
    do
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
				tput sgr0
                clear
                cat /etc/passwd | cut -f1 -d":" | less
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