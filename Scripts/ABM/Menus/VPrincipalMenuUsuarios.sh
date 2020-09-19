#!/bin/bash
#region imports
. "/Scripts/InterfazGrafica/Control/inicio.sh" 

. "/Scripts/ABM/Logica/Usuarios.sh"

. "/Scripts/ABM/Menus/VAvisoRegistrado.sh"
. "/Scripts/ABM/Menus/VEligeGrupo.sh"
. "/Scripts/ABM/Menus/VEliminarUsuario.sh"
. "/Scripts/ABM/Menus/VAgregarUsuario.sh"
. "/Scripts/ABM/Menus/VModificarUsuario.sh"
#endregion

VMenuUsuarios() {
    local continuar=true
    
    #region tui
    iniciarPantallaNueva

    dibujarTxt "¿QUÉ DESEA HACER?" 42 5 0
    dibujarTxt "4 -> ARRIBA" 11 7 0
    dibujarTxt "5 -> ENTER " 11 8 0
    dibujarTxt "6 -> ABAJO" 11 9 0
    
    if [ $EUID -eq 0 ];then 
        dibujarBoton "AGREGAR USUARIO" 11 10 80 3 #necesita root
        dibujarBoton "ELIMINAR USUARIO" 11 13 80 3 #necesita root
        dibujarBoton "LISTAR USUARIOS (Q PARA SALIR)" 11 16 80 3 # puede ser root como que no
        dibujarBoton "VOLVER" 11 19 80 3    
    else
        dibujarBoton "MODIFICAR USUARIO" 11 10 80 3 #no root
        dibujarBoton "LISTAR USUARIOS (Q PARA SALIR)" 11 13 80 3 # puede ser root como que no
        dibujarBoton "VOLVER" 11 16 80 3
    fi

    #endregion

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
        
        case $texto in 

            "AGREGAR USUARIO")
                ejecutarVAgregarUsuario
                ;;

            "MODIFICAR USUARIO")
                ejecutarModificarUsuario
                ;;

            "ELIMINAR USUARIO")
                ejecutarEliminarUsuario
                ;;

            "LISTAR USUARIOS (Q PARA SALIR)")
				tput sgr0
                clear
                cat /etc/passwd | cut -f1 -d":" | less
                ;;
            "VOLVER")
                continuarCiclo=false
                ;;
            *)  
                ;;
        esac

        cerrarPantalla
    done

}