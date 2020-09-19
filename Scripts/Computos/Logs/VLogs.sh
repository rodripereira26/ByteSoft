#!/bin/bash

. "/Scripts/InterfazGrafica/Control/inicio.sh" 

MenuLogs() {
    local continuar=true

    #region tui

    iniciarPantallaNueva
    dibujarTxt "LOGS DEL SISTEMA (Q PARA SALIR)" 37 2 0

    dibujarTxt "4 -> ARRIBA" 11 3 0
    dibujarTxt "5 -> ENTER " 11 4 0
    dibujarTxt "6 -> ABAJO" 11 5 0

    dibujarBoton "HARDWARE" 11 6 80 3
    dibujarBoton "SYSLOG" 11 9 80 3
    dibujarBoton "ÚLTIMOS LOGINS" 11 12 80 3
    dibujarBoton "LOGINS EXITOSOS" 11 15 80 3

    if [ $EUID -eq 0 ]; then #root
        dibujarBoton "MENSAJES DEL SISTEMA" 11 18 80 3
        dibujarBoton "INICIO Y SEGURIDAD" 11 21 80 3
        dibujarBoton "LOGINS FALLIDOS" 11 24 80 3 
        dibujarBoton "VOLVER" 11 27 80 3
    else # no root
        dibujarBoton "VOLVER" 11 18 80 3
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
ejecutarLogs() {

    local continuarCiclo=true

    while $continuarCiclo; 
    do
        MenuLogs
        case $texto in 

            "HARDWARE")
                tput sgr0
                clear
                dmesg | less
                ;;

            "SYSLOG")
                tput sgr0
                clear
                journalctl -r
                ;;

            "ÚLTIMOS LOGINS")
                tput sgr0
				clear
				lastlog | less
				;;

			"LOGINS EXITOSOS")
                
                tput sgr0
				clear
				last | less
				;;

            "MENSAJES DEL SISTEMA")
                #necesita root
                tput sgr0
                clear
                tail /var/log/messages | less
                ;;
                
            "INICIO Y SEGURIDAD")
                #necesita root
                tput sgr0
                clear
                tail /var/log/secure | less
                ;;

			"LOGINS FALLIDOS")
                #necesita root
                tput sgr0
				clear
				lastb | less
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
