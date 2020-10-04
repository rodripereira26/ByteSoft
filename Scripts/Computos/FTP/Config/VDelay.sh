#!/bin/bash

. "/Scripts/InterfazGrafica/Control/inicio.sh"
. "/Scripts/Computos/FTP/Config/funcFTP.sh"
VDelay() {
    #region [rgba(170, 160, 26, 0.10)] variables 
    local continuar=true
    local delayLogueo=$(getConfiguracion delay_successful_login '0')
    local delayDenagado=$(getConfiguracion delay_failed_login '1')
    #endregion
    #region [rgba(27, 173, 192, 0.10)] tui  
    
    iniciarPantallaNueva
    dibujarTxt "DELAY" 41 6 0
    dibujarTxt "ARCHIVO DE CONFIGURACION: /etc/vsftpd/vsftpd.conf" 11 8 0

    dibujarTxt "DELAY LOGEO(0: segundos)" 11 12 0
    dibujarEntradaTxt 11 13 20 false "$delayLogueo"
   
    dibujarTxt "DELAY DENEGADO(1: segundos)" 55 12 0
    dibujarEntradaTxt 55 13 20 false "$delayDenagado"
   
    dibujarBoton "CONFIGURAR" 11 20 40 3
    dibujarBoton "CANCELAR" 50 20 40 3
    #endregion
    
    while $continuar; 
    do
        siguientePos

        case $posDeEsteElemento in
            
            "0") #DELAY LOGUEO(0: segundos)
                if $modificado; then 
                    delayLogueo=$respuestaGestor
                fi        
                ;;
            "1") #DELAY DENEGADO(1: segundos)
                if $modificado; then 
                    delayDenagado=$respuestaGestor
                fi                
                ;;
            "2") #CONFIGURAR
                if $respuestaGestor; 
                then
                    if [ "${delayLogueo//[0-9]/}" -a "$delayLogueo" -a ! "$delayLogueo" = '(none)' ]; then #no es un numero
                        mensajeError "INGRESE UN NUMERO VÁLIDO EN LOGUEO" 1 37 33 0 1 1
                    else
                        if [ "${delayDenagado//[0-9]/}" -a "$delayDenagado" -a ! "$delayDenagado" = '(none)' ]; then #no es un numero
                            mensajeError "INGRESE UN NUMERO VÁLIDO EN DENEGADO" 1 37 33 0 1 1
                        else
                            configureDelay "$delayLogueo" "$delayDenagado"
                            systemctl restart vsftpd
                            continuar=false
                        fi
                    fi
                fi
                ;;          
            "3") #CANCELAR
                if $respuestaGestor; 
                then
                    continuar=false
                fi
                ;;
        esac
    done
}

ejecutarVDelay() {
    VDelay
    cerrarPantalla
}

probarFuncionEjecucionLocal ejecutarVDelay "VDelay.sh"
