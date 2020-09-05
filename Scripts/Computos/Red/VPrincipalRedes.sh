#!/bin/bash

. "/Scripts/InterfazGrafica/Control/inicio.sh"

. "/Scripts/Computos/Red/VPermitirIP.sh"
. "/Scripts/Computos/Red/VBloquearIP.sh"
. "/Scripts/Computos/Red/VEliminarRegla.sh"

VPrincipalRed() {

    local continuar=true
    
    iniciarPantallaNueva
    dibujarTxt "RED" 43 3 0

    dibujarTxt "4 -> ARRIBA" 11 3 0
    dibujarTxt "5 -> ENTER " 11 4 0
    dibujarTxt "6 -> ABAJO" 11 5 0
    
    dibujarBoton "PERMITIR IP" 11 9 80 3 #solo root
    dibujarBoton "BLOQUEAR IP" 11 12 80 3 #solo root
    dibujarBoton "ELIMINAR REGLA" 11 15 80 3 #solo root
    dibujarBoton "LISTAR REGLAS" 11 18 80 3 #solo root
    dibujarBoton "VOLVER" 11 21 80 3
    
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
        case $posDeEsteElemento in 

            "0")
                ejecutarPermitirIP 
                ;;
                
            "1")
                ejecutarBloquearIP     
                ;;

            "2")
                ejecutarEliminarRegla
                ;;
            "3")
                (iptables -L INPUT -n && \
                    echo -e "\n" && iptables -L OUTPUT -n && \
                    echo -e "\n" && iptables -L FORWARD -n)  | less
                ;;

            "4") 
                continuarCiclo=false
                ;;
                  
            *)
                ;;
        esac
        cerrarPantalla

    done

}

