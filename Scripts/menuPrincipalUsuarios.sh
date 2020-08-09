#!/bin/bash

#
# Obligatorio ejecutar con root
#

. "InterfazGrafica/Grafica/disenoVentana.sh" 
. "Logica/Entorno/Respaldar.sh"
. "Logica/Entorno/CrearCarpetasYVariables.sh"
. "Logica/ABM/Usuarios.sh"
. "Menus/ABM/VPrincipalMenuUsuarios.sh"
. "Menus/Entorno/VPrincipalMenuConfigEntorno.sh"
. "Menus/Logs/logs.sh"

VMenuPrincipal(){
    # muestra diseño
    iniciarPantallaNueva
    dibujarTxt "MENU PRINCIPAL" 53 2

    dibujarTxt "4: ARRIBA" 9 2
    dibujarTxt "5: ENTER " 9 3
    dibujarTxt "6: ABAJO" 9 4
    
    dibujarBoton "USUARIOS" 20 5 80 3
    dibujarBoton "CONFIGURACION ENTORNO" 20 8 80 3
    dibujarBoton "VER LOGS" 20 11 80 3
    dibujarBoton "SALIR" 20 14 80 3

    local continuar=true
    while $continuar; do
        siguientePos
        if $respuestaGestor; then
            continuar=false
        fi 
    done

}
ejecutarMenuPrincipal(){
    local continuarCiclo=true
    while $continuarCiclo; do
        VMenuPrincipal
        case $posDeEsteElemento in 
            "0")
                ejecutarUsuario
                ;;
            "1")
                ejecutarConfigEntorno
                ;;
            "2")
                ejecutarLogs
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
main(){
    tput sgr0
    clear
    tput civis
    animacionTitulo "InterfazGrafica/tituloByteSoft.txt" 5 5
    ejecutarMenuPrincipal
    clear
}
main