#!/bin/bash

#. "InterfazGrafica/Grafica/disenoVentana.sh"

MenuLogs() {

    iniciarPantallaNueva
    dibujarTxt "LOGS DEL SISTEMA (Q PARA SALIR)" 45 2
    dibujarBoton "HARDWARE" 20 4 80 3
    dibujarBoton "SYSLOG" 20 7 80 3
    dibujarBoton "MENSAJES DEL SISTEMA" 20 10 80 3
    dibujarBoton "INICIO Y SEGURIDAD" 20 13 80 3
    dibujarBoton "ÚLTIMOS LOGINS" 20 16 80 3
    dibujarBoton "LOGINS EXITOSOS" 20 19 80 3
    dibujarBoton "LOGINS FALLIDOS" 20 22 80 3
    dibujarBoton "VOLVER" 20 25 80 3

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

ejecutarLogs() {

    local continuarCiclo=true

    while $continuarCiclo; 
    do
        MenuLogs
        case $posDeEsteElemento in 

            "0")
                clear
                dmesg | less
                ;;

            "1")
                clear
                journalctl -r
                ;;

            "2")
                clear
                tail /var/log/messages | less
                ;;
                
            "3")
                clear
                tail /var/log/secure | less
                ;;

            "4")
				clear
				lastlog | less
				;;

			"5")
				clear
				last | less
				;;

			"6")
				clear
				lastb | less
				;;	

            "7")
                continuarCiclo=false
                ;;
            *)
                ;;
        esac
        cerrarPantalla
    done

}
