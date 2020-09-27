#!/bin/bash

. "/Scripts/InterfazGrafica/Control/inicio.sh"
. "/Scripts/Computos/FTP/Config/funcFTP.sh"
VBanner() {
    local continuar=true
    local pathBanner=$(getConfiguracion banner_file '(none)')
    #region [rgba(27, 173, 192, 0.10)] tui  
    
    iniciarPantallaNueva
    dibujarTxt "BANNER" 41 6 0

    dibujarTxt "En el siguiente path hay un banner" 11 7 0
    dibujarTxt "/Scripts/Computos/FTP/bannerDefectoFTP.txt" 11 8 0
    dibujarTxt "AL CONFIGURAR SE HARÁ UNA COPIA DEL ARCHIVO EN /etc/banner.txt" 11 9 0
    
    dibujarTxt "PATH DEL BANNER((none))" 11 11 0
    dibujarEntradaTxt 11 12 80 false "$pathBanner"

    dibujarBoton "CONFIGURAR" 11 20 40 3
    dibujarBoton "CANCELAR" 50 20 40 3
    #endregion
    
    while $continuar; 
    do
        siguientePos

        case $posDeEsteElemento in

            "0") #PATH DEL BANNER
                if $modificado; then             
                    pathBanner=$respuestaGestor
                fi
                ;;
            "1") #CONFIGURAR
                if $respuestaGestor; 
                then
                    # ver de agregar el path acaa
                    if [ "$pathBanner" -a -e "$pathBanner" ]; then
                        cp "$pathBanner" "/etc/bannerFTP.txt"
                        pathBanner="/etc/banner.txt"
                        chmod 755 "$pathBanner"
                        configurarBanner "$pathBanner"
                        systemctl restart vsftpd
                        continuar=false
                    else
                       mensajeError "NO SE ENCONTRÓ EL ARCHIVO BANNER" 1 37 33 0 1 1
                    fi
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

ejecutarVBanner() {
    VBanner
    cerrarPantalla
}
probarFuncionEjecucionLocal ejecutarVBanner "VBanner.sh"
