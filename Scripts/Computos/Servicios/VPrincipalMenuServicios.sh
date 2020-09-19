#!/bin/bash
#region imports
. "/Scripts/InterfazGrafica/Control/inicio.sh" 

. "/Scripts/Computos/Servicios/VConexiones.sh"
. "/Scripts/Computos/Servicios/Login/VMenuServicioLog.sh"
. "/Scripts/Computos/Servicios/VAccionesServicios.sh"
#endregion

VMenuPrincipalServicios(){
    local continuar=true
    #region tui
    iniciarPantallaNueva
    dibujarTxt "SERVICIOS" 46 3 0

    dibujarTxt "4 -> ARRIBA" 11 6 0
    dibujarTxt "5 -> ENTER " 11 7 0
    dibujarTxt "6 -> ABAJO" 11 8 0
    
    dibujarBoton "VER SERVICIOS ACTIVOS (Q PARA SALIR)" 11 9 80 3
    
    if [ $EUID -eq 0 ];then
        dibujarBoton "ACTIVAR SERVICIO" 11 12 80 3 #necesita root
        dibujarBoton "DESACTIVAR SERVICIO" 11 15 80 3 #necesita root
        dibujarBoton "CONEXIONES (SSH, MYSQL, FTP)" 11 18 80 3 #necesita root
        dibujarBoton "LOGIN SERVICIOS" 11 21 80 3
        dibujarBoton "VOLVER" 11 24 80 3
    else
        dibujarBoton "LOGIN SERVICIOS" 11 12 80 3
        dibujarBoton "VOLVER" 11 15 80 3
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
ejecutarMenuPrincipalServicios() {

    local continuarCiclo=true

    while $continuarCiclo; 
    do
        VMenuPrincipalServicios

        case $texto in 

        	"VER SERVICIOS ACTIVOS (Q PARA SALIR)")
				tput sgr0
				clear
				systemctl list-unit-files | grep "enabled" | less
				;;
                
			"ACTIVAR SERVICIO")
            	activarServicio 
				;;

			"DESACTIVAR SERVICIO")
				desactivarServicio
				;;

            "CONEXIONES (SSH, MYSQL, FTP)")
                ejecutarVConexiones
                ;;

            "LOGIN SERVICIOS")
                ejecutarMenuServicioConf
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