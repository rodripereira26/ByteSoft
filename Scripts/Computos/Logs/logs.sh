#!/bin/bash

. "/Scripts/InterfazGrafica/Grafica/disenoVentana.sh" 
. "/Scripts/InterfazGrafica/Logica/logicaVentana.sh" 

MenuLogs() {

    iniciarPantallaNueva
    dibujarTxt "LOGS DEL SISTEMA (Q PARA SALIR)" 37 2 0

    dibujarTxt "4 -> ARRIBA" 11 3 0
    dibujarTxt "5 -> ENTER " 11 4 0
    dibujarTxt "6 -> ABAJO" 11 5 0

    dibujarBoton "HARDWARE" 11 6 80 3
    dibujarBoton "SYSLOG" 11 9 80 3
    dibujarBoton "MENSAJES DEL SISTEMA" 11 12 80 3
    dibujarBoton "INICIO Y SEGURIDAD" 11 15 80 3
    dibujarBoton "ÚLTIMOS LOGINS" 11 18 80 3
    dibujarBoton "LOGINS EXITOSOS" 11 21 80 3
    dibujarBoton "LOGINS FALLIDOS" 11 24 80 3
    dibujarBoton "VOLVER" 11 27 80 3

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
                tput sgr0
                clear
                dmesg | less
                ;;

            "1")
                tput sgr0
                clear
                journalctl -r
                ;;

            "2")
                tput sgr0
                clear
                tail /var/log/messages | less
                ;;
                
            "3")
                tput sgr0
                clear
                tail /var/log/secure | less
                ;;

            "4")
                tput sgr0
				clear
				lastlog | less
				;;

			"5")
                tput sgr0
				clear
				last | less
				;;

			"6")
                tput sgr0
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
