#!/bin/bash

#
# Obligatorio ejecutar con root
#
sudo ls #pide permisos root

. "InterfazGrafica/Grafica/disenoVentana.sh" 
. "Logica/Entorno/Respaldar.sh"
. "Logica/Entorno/CrearCarpetasYVariables.sh"
. "Logica/ABM/Usuarios.sh"
. "Menus/ABM/VPrincipalMenuUsuarios.sh"
. "Menus/Entorno/VPrincipalMenuConfigEntorno.sh"
. "Menus/Logs/logs.sh"
. "Menus/Servicios/VPrincipalMenuServicios.sh"

VMenuPrincipal(){
    # muestra diseño
    iniciarPantallaNueva
    dibujarTxt "Menú principal" 53 2 ##############

    dibujarTxt "4: anterior" 9 2 ##############
    dibujarTxt "5: enter" 9 3 ##############
    dibujarTxt "6: siguiente" 9 4 ##############
    
    dibujarBoton "Usuarios" 20 5 80 3 ##############
    dibujarBoton "Configuracion de entorno" 20 8 80 3 ##############
    dibujarBoton "Ver logs" 20 11 80 3 ##############
    dibujarBoton "Servicios" 20 14 80 3 ##############
    dibujarBoton "Salir" 20 17 80 3 ##############

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
                ejecutarMenuPrincipalServicios ##############
                ;; ##############
            "4")
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
    animacionTitulo "InterfazGrafica/tituloByteSoft.txt" 5 5 ##############
    ejecutarMenuPrincipal
    clear
}
main