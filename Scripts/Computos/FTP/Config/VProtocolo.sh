#!/bin/bash

. "/Scripts/InterfazGrafica/Control/inicio.sh"
. "/Scripts/Computos/FTP/Config/funcFTP.sh"

VProtocolo() {
    #region [rgba(170, 160, 26, 0.10)] variables 
    local continuar=true
    local escuchaIpV4=$(configuracionEsTrue listen = YES)
    #endregion
    #region [rgba(27, 173, 192, 0.10)] tui  
    
    iniciarPantallaNueva
    dibujarTxt "VERSION PROTOCOLO" 41 6 0
    dibujarTxt "ARCHIVO DE CONFIGURACION: /etc/vsftpd/vsftpd.conf" 11 8 0

    dibujarTxt "IPV6" 11 11 0
    dibujarSwitch 18 11 20 1 $escuchaIpV4
    dibujarTxt "IPV4" 41 11 0

    dibujarBoton "CONFIGURAR" 11 20 40 3
    dibujarBoton "CANCELAR" 50 20 40 3
    #endregion
    
    while $continuar; 
    do
        siguientePos

        case $posDeEsteElemento in

            "0") #IPV4 O IPV6
                if $modificado; then 
                    escuchaIpV4=$respuestaGestor
                fi        
                ;;
            "1") #CONFIGURAR
                if $respuestaGestor; 
                then
                    escuchaIpV4=$([ $escuchaIpV4 = true ] && echo YES || echo NO)                     
                    configuracionProtocolo $escuchaIpV4
                    systemctl restart vsftpd
                    continuar=false
                fi
                ;;          
            "2") #CANCELAR
                if $respuestaGestor; 
                then
                    continuar=false
                fi
                ;;
            *)
                ;;
        esac
    done
}

ejecutarVProtocolo() {
    VProtocolo
    cerrarPantalla
}
probarFuncionEjecucionLocal ejecutarVProtocolo "VProtocolo.sh"
