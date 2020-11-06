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
    
    #region [rgba(27, 173, 192, 0.10)] tui 
    iniciarPantallaNueva

    dibujarTxt "¿QUÉ DESEA HACER?" 42 5 0
    dibujarTxt "4 -> ARRIBA" 11 7 0
    dibujarTxt "5 -> ENTER " 11 8 0
    dibujarTxt "6 -> ABAJO" 11 9 0
    dibujarTxt "ESC -> SALIR DE INPUT" 11 10 0
    
    if [ $EUID -eq 0 ];
	then 
        dibujarBoton "AGREGAR USUARIO" 11 11 80 3 #necesita root
        dibujarBoton "ELIMINAR USUARIO" 11 14 80 3 #necesita root
        dibujarBoton "LISTAR USUARIOS (Q PARA SALIR)" 11 17 80 3 # puede ser root como que no
        dibujarBoton "VOLVER" 11 20 80 3    
    else
        dibujarBoton "MODIFICAR USUARIO" 11 11 80 3 #no root
        dibujarBoton "LISTAR USUARIOS (Q PARA SALIR)" 11 14 80 3 # puede ser root como que no
        dibujarBoton "VOLVER" 11 17 80 3
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