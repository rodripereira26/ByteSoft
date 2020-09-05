#!/bin/bash

. "/Scripts/InterfazGrafica/Control/inicio.sh"

. "/Scripts/Computos/Red/VPermitirIP.sh"
. "/Scripts/Computos/Red/VBloquearIP.sh"
. "/Scripts/Computos/Red/VEliminarRegla.sh"
#solo root
VPrincipalRed() {

    local continuar=true
    
    iniciarPantallaNueva
    dibujarTxt "RED" 43 3 0

    dibujarTxt "4 -> ARRIBA" 11 3 0
    dibujarTxt "5 -> ENTER " 11 4 0
    dibujarTxt "6 -> ABAJO" 11 5 0

    if [ $EUID -eq 0 ];then #solo root 
        dibujarBoton "PERMITIR IP" 11 9 80 3 #solo root
        dibujarBoton "BLOQUEAR IP" 11 12 80 3 #solo root
        dibujarBoton "ELIMINAR REGLA" 11 15 80 3 #solo root
        dibujarBoton "LISTAR REGLAS" 11 18 80 3 #solo root
        dibujarBoton "VOLVER" 11 21 80 3
    else
        dibujarBoton "VOLVER" 11 9 80 3 
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

ejecutarPrincipalRed() {

    local continuarCiclo=true

    while $continuarCiclo; 
    do
        VPrincipalRed
        case $texto in 

            "PERMITIR IP")
                ejecutarPermitirIP 
                ;;
                
            "BLOQUEAR IP")
                ejecutarBloquearIP     
                ;;

            "ELIMINAR REGLA")
                ejecutarEliminarRegla
                ;;
            "LISTAR REGLAS")
                (iptables -L INPUT -n && \
                    echo -e "\n" && iptables -L OUTPUT -n && \
                    echo -e "\n" && iptables -L FORWARD -n)  | less
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

