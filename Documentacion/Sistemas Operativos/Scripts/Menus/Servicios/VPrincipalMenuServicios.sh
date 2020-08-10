#!/bin/bash

. "Menus/Servicios/VConexiones.sh"
. "Menus/Servicios/Configuracion/VMenuServicioConf.sh"

VMenuPrincipalServicios(){
    # muestra diseño
    iniciarPantallaNueva
    dibujarTxt "Menú Servicios" 53 2
    
    dibujarBoton "Estado" 20 5 80 3
    dibujarBoton "Configuracion" 20 8 80 3
    dibujarBoton "Salir" 20 11 80 3

    local continuar=true
    while $continuar; do
        siguientePos
        if $respuestaGestor; then
            continuar=false
        fi 
    done

}
ejecutarMenuPrincipalServicios(){
    local continuarCiclo=true
    while $continuarCiclo; do
        VMenuPrincipalServicios
        case $posDeEsteElemento in 
            "0")
                ejecutarVConexiones
                ;;
            "1")
                ejecutarMenuServicioConf
                ;;
            "2")
                continuarCiclo=false
                ;;
            *)
                ;;
        esac
        cerrarPantalla
    done
}