#!/bin/bash

. "/Scripts/Computos/Servicios/VConexiones.sh"
. "/Scripts/Computos/Servicios/Configuracion/VMenuServicioConf.sh"
. "/Scripts/Computos/Servicios/logica.sh"
. "/Scripts/InterfazGrafica/Grafica/disenoVentana.sh" 
. "/Scripts/InterfazGrafica/Logica/logicaVentana.sh" 


VMenuPrincipalServicios(){

    iniciarPantallaNueva
    dibujarTxt "SERVICIOS" 46 3 0

    dibujarTxt "4 -> ARRIBA" 11 6 0
    dibujarTxt "5 -> ENTER " 11 7 0
    dibujarTxt "6 -> ABAJO" 11 8 0
    
    dibujarBoton "VER SERVICIOS ACTIVOS (Q PARA SALIR)" 11 9 80 3
    dibujarBoton "ACTIVAR SERVICIO" 11 12 80 3
    dibujarBoton "DESACTIVAR SERVICIO" 11 15 80 3
    dibujarBoton "CONEXIONES (SSH, MYSQL)" 11 18 80 3
    dibujarBoton "CONFIGURACIÓN" 11 21 80 3
    dibujarBoton "VOLVER" 11 24 80 3

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
ejecutarMenuPrincipalServicios() {

    local continuarCiclo=true

    while $continuarCiclo; 
    do
        VMenuPrincipalServicios

        case $posDeEsteElemento in 

        	"0")
				tput sgr0
				clear
				systemctl list-unit-files | grep "enabled" | less
				;;

			"1")
				colorBgDefecto=0
            	activarServicio
				;;

			"2")
				colorBgDefecto=0
				desactivarServicio
				;;

            "3")
                ejecutarVConexiones
                ;;

            "4")
                ejecutarMenuServicioConf
                ;;

            "5")
                continuarCiclo=false
                ;;
            *)
                ;;
        esac
        
        cerrarPantalla
    done
}