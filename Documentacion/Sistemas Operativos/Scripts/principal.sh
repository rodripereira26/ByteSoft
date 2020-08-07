#!/bin/bash

#
# Obligatorio ejecutar con root
#
. "InterfazGrafica/Grafica/disenoVentana.sh" 
. "/Logica/Entorno/EntornoDeTrabajo/Respaldar.sh"
. "/Logica/Entorno/EntornoDeTrabajo/CrearCarpetasYVariables.sh"
. "/Logica/Entorno/Usuarios.sh"
. "/Logica/Entorno/SegundoPlano/Logica.sh"
. "Menus/OpcionesMenuUsuarios/VPrincipalMenuUsuarios.sh"
. "Menus/OpcionesMenuConfigEntorno/VPrincipalMenuConfigEntorno.sh"


VMenuPrincipal(){
    # muestra diseño
    iniciarPantallaNueva
    animacionTitulo "Menus/tituloByteSoft.txt" 5 5
    iniciarPantallaNueva
    dibujarTxt "MENU PRINCIPAL" 80 2
    dibujarBoton "USUARIOS" 20 5 80 3
    dibujarBoton "CONFIGURACION ENTORNO" 20 8 80 3
    dibujarBoton "SALIR" 20 11 80 3
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
                continuarCiclo=false
                ;;
            *)
                ;;
        esac
        cerrarPantalla
    done
}
main(){
    ejecutarMenuPrincipal
    clear
}
main