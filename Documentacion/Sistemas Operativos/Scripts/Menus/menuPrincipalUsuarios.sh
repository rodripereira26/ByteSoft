#!/bin/bash


#
# Obligatorio ejecutar con root
#

. "ElementosTUI/Grafica/disenoVentana.sh" 
. "InteraccionConCentOS/EntornoDeTrabajo/Respaldar.sh"
. "InteraccionConCentOS/EntornoDeTrabajo/CrearCarpetasYVariables.sh"
. "InteraccionConCentOS/ABM/Usuarios.sh"
. "Menus/OpcionesMenuUsuarios/VPrincipalMenuUsuarios.sh"
. "Menus/OpcionesMenuConfigEntorno/VPrincipalMenuConfigEntorno.sh"



VMenuPrincipal(){
    # muestra diseño
    iniciarPantallaNueva
    dibujarTxt "MENU PRINCIPAL" 80 2

    dibujarTxt "4: ATRAS" 10 2
    dibujarTxt "5: ENTER " 10 3
    dibujarTxt "6: ADELANTE" 10 4
    
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
    tput sgr0
    clear
    tput civis
    animacionTitulo "Menus/tituloByteSoft.txt" 5 5
    ejecutarMenuPrincipal
    clear
}
main