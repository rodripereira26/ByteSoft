#!/bin/bash

. "/Scripts/InterfazGrafica/Control/inicio.sh" 

. "/Scripts/Computos/Servicios/VConexiones.sh"
. "/Scripts/Computos/Servicios/Configuracion/VMenuServicioConf.sh"
. "/Scripts/Computos/Servicios/VAccionesServicios.sh"


VMenuPrincipalServicios(){
    local continuar=true

    iniciarPantallaNueva
    dibujarTxt "SERVICIOS" 46 3 0

    dibujarTxt "4 -> ARRIBA" 11 6 0
    dibujarTxt "5 -> ENTER " 11 7 0
    dibujarTxt "6 -> ABAJO" 11 8 0
    
    dibujarBoton "VER SERVICIOS ACTIVOS (Q PARA SALIR)" 11 9 80 3
    
    if [ $EUID -eq 0 ];then
        dibujarBoton "ACTIVAR SERVICIO" 11 12 80 3 #necesita root
        dibujarBoton "DESACTIVAR SERVICIO" 11 15 80 3 #necesita root
        dibujarBoton "CONEXIONES (SSH, MYSQL)" 11 18 80 3 #necesita root
        dibujarBoton "CONFIGURACION" 11 21 80 3
        dibujarBoton "VOLVER" 11 24 80 3
    else
        dibujarBoton "CONFIGURACION" 11 12 80 3
        dibujarBoton "VOLVER" 11 15 80 3
    fi



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

        case $codigoElemento in 

        	"BTN:VER SERVICIOS ACTIVOS (Q PARA SALIR):11:9:80:3")
				tput sgr0
				clear
				systemctl list-unit-files | grep "enabled" | less
				;;
                
			"BTN:ACTIVAR SERVICIO:11:12:80:3")
            	activarServicio 
				;;

			"BTN:DESACTIVAR SERVICIO:11:15:80:3")
				desactivarServicio
				;;

            "BTN:CONEXIONES (SSH, MYSQL):11:18:80:3")
                ejecutarVConexiones
                ;;

            "BTN:CONFIGURACION:11:21:80:3"|"BTN:CONFIGURACION:11:12:80:3")
                ejecutarMenuServicioConf
                ;;

            "BTN:VOLVER:11:24:80:3"|"BTN:VOLVER:11:15:80:3")
                continuarCiclo=false
                ;;
            *)
                ;;
        esac
        
        cerrarPantalla
    done
}