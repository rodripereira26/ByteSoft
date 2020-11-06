#!/bin/bash

. "/Scripts/InterfazGrafica/Control/inicio.sh"
. "/Scripts/Computos/FTP/Config/funcFTP.sh"

VFiltroPorUsuario() {
    #region [rgba(170, 160, 26, 0.10)] variables  
    local continuar=true
    local filtroPorUsuarios=$(configuracionEsTrue userlist_enable = YES)
    local politicaDenegar=$(configuracionEsTrue userlist_deny '!=' NO)
    local registrarDenegaciones=$(configuracionEsTrue userlist_log = YES)
    #endregion
    #region [rgba(27, 173, 192, 0.10)] tui 
    iniciarPantallaNueva
    dibujarTxt "FILTROS POR USUARIO" 41 6 0
    dibujarTxt "ARCHIVO DE CONFIGURACION: /etc/vsftpd/vsftpd.conf" 11 8 0

    dibujarTxt "¿FILTRAR POR USUARIOS? (NO)" 50 11 0
    dibujarSwitch 50 12 20 1 $filtroPorUsuarios
    
    dibujarTxt "POLITICA DE DENEGAR (YES)" 50 14 0
    dibujarSwitch 50 15 20 1 $politicaDenegar

    dibujarTxt "¿REGISTRAR DENEGACIONES DE INICIO DE SESION FTP? (NO)" 50 17 0
    dibujarSwitch 50 18 20 1 $registrarDenegaciones
    
    dibujarBoton "CONFIGURAR" 11 20 40 3
    dibujarBoton "CANCELAR" 50 20 40 3
    #endregion

    while $continuar; 
    do
        siguientePos

        case $posDeEsteElemento in

            "0") #¿FILTRAR POR USUARIOS? (NO)
                if $modificado;
				then 
                    filtroPorUsuarios=$respuestaGestor
                fi
                ;;

            "1") #POLITICA DE DENEGAR (YES)
                if $modificado;
				then 
                    politicaDenegar=$respuestaGestor
                fi        
                ;;
            "2") #¿REGISTRAR DENEGACIONES DE INICIO DE SESION FTP? (NO)
                if $modificado;
				then 
                    registrarDenegaciones=$respuestaGestor
                fi        
                ;;
            "3") #CONFIGURAR
                if $respuestaGestor; 
                then
                    filtroPorUsuarios=$([ $filtroPorUsuarios = true ] && echo YES || echo NO) 
                    politicaDenegar=$([ $politicaDenegar = true ] && echo YES || echo NO) 
                    registrarDenegaciones=$([ $registrarDenegaciones = true ] && echo YES || echo NO)                     
                    
                    configuracionIniciosDeSesion "$filtroPorUsuarios" "$politicaDenegar" "$registrarDenegaciones"
                    systemctl restart vsftpd
                    continuar=false
                fi
                ;;          
            "4") #CANCELAR
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

ejecutarVFiltroPorUsuario() {
    VFiltroPorUsuario
    cerrarPantalla
}
probarFuncionEjecucionLocal ejecutarVFiltroPorUsuario "VFiltroPorUsuario.sh"

