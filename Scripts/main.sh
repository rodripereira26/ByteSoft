#!/bin/bash

#
# Para acceder a OTROS privilegios, ejecutar con root
# hay opciones que solo estan para usuarios no root
#

#region imports
. "/Scripts/InterfazGrafica/Control/inicio.sh" 
. "/Scripts/Computos/VPrincipalComputos.sh"
. "/Scripts/ConfigurarEntorno/VPrincipalMenuConfigEntorno.sh"
. "/Scripts/ConfigurarEntorno/Logica/funciones.sh" 
#endregion

Principal() {
    local continuar=true
    #region [rgba(27, 173, 192, 0.10)] tui 
    
    iniciarPantallaNueva 
    dibujarTxt "MENU PRINCIPAL" 43 5 0

    dibujarTxt "4 -> ARRIBA" 11 7 0
    dibujarTxt "5 -> ENTER " 11 8 0
    dibujarTxt "6 -> ABAJO" 11 9 0
    dibujarTxt "ESC -> SALIR DE INPUT" 11 10 0
    
    dibujarBoton "CENTRO DE COMPUTOS" 11 11 80 3

    if [ $EUID -eq 0 ];
    then
        dibujarBoton "CONFIGURACIÓN DEL ENTORNO" 11 14 80 3 #necesita root 
        dibujarBoton "DESINSTALAR ENTORNO" 11 17 80 3 #necesita root 
        dibujarBoton "SALIR" 11 20 80 3
    else

        dibujarBoton "SALIR" 11 14 80 3
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
ejecutarMain() {

    local continuarCiclo=true
    while $continuarCiclo; 
    do
        Principal
        case $texto in 

            "CENTRO DE COMPUTOS")
                ejecutarComputos
                ;;

            "CONFIGURACIÓN DEL ENTORNO")
                preguntaInstalacion
                colorBgDefecto=7
                ;;

            "DESINSTALAR ENTORNO")
                preguntaDesinstalar
                ;;

            "SALIR")
                continuarCiclo=false
                ;;

            *)
                ;;
        esac
        cerrarPantalla
    done

}

main() {
    
    tput sgr0
    tput civis
    #animacionTitulo "/Scripts/InterfazGrafica/Vista/ElementosExtra/tituloByteSoft.txt" 10 10
    ejecutarMain
}
main
