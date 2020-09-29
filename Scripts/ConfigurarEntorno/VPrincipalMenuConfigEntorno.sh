#!/bin/bash

#
# root obligatorio 
#
#region imports
. "/Scripts/InterfazGrafica/Control/inicio.sh" 
. "/Scripts/ConfigurarEntorno/Logica/CrearCarpetasYVariables.sh"
. "/Scripts/ConfigurarEntorno/Logica/funciones.sh" 
. "/Scripts/ConfigurarEntorno/SSH/VConfigSSH.sh" 
#. "/Scripts/Computos/MySQL/configMySQL.sh"
. "/Scripts/ConfigurarEntorno/RED/configRED.sh"
#endregion

preguntaInstalacion() {
    local continuar=true

    buscar=$(grep instalacion=true /etc/environment | cut -f2 -d"=")

    if [ -z $buscar ];
    then
        
        pregunta "¿Desea iniciar la configuración del entorno?" 7 28 15 21 2 7

        while $continuar; 
        do
            siguientePos
            case $posDeEsteElemento in

                "0") 
                    if $respuestaGestor;
                    then
                        pantallaEleccionMaquina
                    fi
                    ;;

                "1")
                    if $respuestaGestor;
                    then
                        continuar=false
                        colorBgDefecto=7
                    fi         
                    ;;

                *)  
                    ;;

            esac
        done
        cerrarPantalla
    else
         mensajeError "LA INSTALACIÓN YA FUE REALIZADA" 1 36 33 2 3 1 1  
    fi

}

pantallaEleccionMaquina(){
    local continuar=true

    iniciarPantallaNueva
    dibujarTxt "INGRESA FUNCION MAQUINA ACTUAL" 80 2
    dibujarBoton "SERVIDOR PRINCIPAL" 20 7 80 3
    dibujarBoton "RESPALDOS" 20 10 80 3 
    dibujarBoton "SUBRED ADMIN" 20 13 80 3 

    while $continuar;
    do
        siguientePos

        case $posDeEsteElemento in

            "0")
                if $respuestaGestor; 
                then
                    pantallaInstalacionServidor
                    continuar=false
                fi
                ;;

            "1")
                if $respuestaGestor; 
                then
                    pantallaInstalacionServidorRespaldos
                    continuar=false
                fi
                ;;
            "2")
                if $respuestaGestor; 
                then
                    pantallaInstalacionServidorSubredAdmin
                    continuar=false
                fi
                ;;
            *)
                ;;
        esac
    done
    cerrarPantalla
}
#region instalacions
pantallaInstalacionServidor() {
    
    colorBgDefecto=7
    iniciarPantallaNueva
    dibujarRectangulo 11 4 80 30 7 7 
    dibujarTxt "CONFIGURANDO ENTORNO" 41 5 8

    case $(variablesEntorno) in

        "0") 
            dibujarTxt "CONFIGURANDO VARIABLES..." 37 8 1
            sleep 0.5
            ;;

        "1")
            mensajeError "LAS VARIABLES YA FUERON CREADAS" 1 37 33 2 3 1 1

            ;;
    esac

    case $(crearCarpetasIniciales) in 

        "0")
            dibujarTxt "CREANDO CARPETAS..." 40 12 1    
            sleep 0.5   
            ;;
                        
        "1")
            mensajeError "LAS CARPETAS YA FUERON CREADAS" 1 37 33 2 3 1 1
            ;;
    esac
    VConfigRedParaLocal "SERVIDOR"
    case $(crontabConf) in

        "0")
            dibujarTxt "CONFIGURANDO CRONTAB..." 38 16 1
            sleep 0.5
            ;;
                        
        "1")
            mensajeError "EL CRONTAB YA FUE CONFIGURADO" 1 37 33 2 3 1 1
            ;;
    esac
    
    dibujarTxt "CONFIGURANDO FIREWALL..." 38 20 1
    firewallConf
    sleep 0.5
    
    let PUERTO=$(grep "#Port 22" /etc/ssh/sshd_config | cut -f2 -d" ")

    if [ $PUERTO -eq 22 ]; 
    then
        dibujarTxt "CONFIGURANDO SSH..." 40 24 1 
        sleep 0.5
        colorBgDefecto=0
        pantallaSSH
    else 
        colorBgDefecto=7
    fi
    cerrarPantalla
}

pantallaInstalacionServidorRespaldos() {
    
    colorBgDefecto=7
    iniciarPantallaNueva
    dibujarRectangulo 11 4 80 30 7 7 
    dibujarTxt "CONFIGURANDO ENTORNO" 41 5 7


    case $(variablesEntorno) in

        "0") 
            dibujarTxt "CONFIGURANDO VARIABLES..." 37 8 1
            sleep 0.5
            ;;

        "1")
            mensajeError "LAS VARIABLES YA FUERON CREADAS" 1 37 33 2 3 1 1
            ;;
    esac
    VConfigRedParaLocal "RESPALDO"
    dibujarTxt "CONFIGURANDO FIREWALL..." 38 20 1
    firewallConf
    dibujarTxt "CONFIGURACION TERMINADA" 38 20 1
    sleep 0.5  
}

pantallaInstalacionServidorSubredAdmin() {
    
    colorBgDefecto=7
    iniciarPantallaNueva
    dibujarRectangulo 11 4 80 30 7 7 
    dibujarTxt "CONFIGURANDO ENTORNO" 41 5 7


    case $(variablesEntorno) in

        "0") 
            dibujarTxt "CONFIGURANDO VARIABLES..." 37 8 1
            sleep 0.5
            ;;

        "1")
            mensajeError "LAS VARIABLES YA FUERON CREADAS" 1 37 33 2 3 1 1
            ;;
    esac
    VConfigRedParaLocal "SUBRED_ADMIN"
    
    dibujarTxt "CONFIGURANDO FIREWALL..." 38 20 1
    firewallConf
    dibujarTxt "CONFIGURACION TERMINADA" 38 20 1
    sleep 0.5
}
#endregion

preguntaDesinstalar() {

    local continuar=true
    
    buscar=$(grep instalacion=true /etc/environment | cut -f2 -d"=")

    if [ -z $buscar ];
    then
        mensajeError "NO SE HA INSTALADO EL ENTORNO" 1 36 33 2 3 1 1 
    else
        
        pregunta "¿Desea desinstalar el entorno?" 7 36 15 21 2 7
    
        while $continuar; 
        do
            siguientePos

            case $posDeEsteElemento in

                "0") 
                    if $respuestaGestor;
                    then
                        cerrarPantalla
					    colorBgDefecto=7
					    iniciarPantallaNueva
					    dibujarRectangulo 11 4 80 30 7 7 
					    dibujarTxt "DESINSTALANDO FIREWALL..." 37 8 1
					    sleep 0.5
					    dibujarTxt "DESINSTALANDO SSH..." 39 12 1
					    sleep 0.5
					    dibujarTxt "DESINSTALANDO CRONTAB..." 38 16 1
					    sleep 0.5
					    dibujarTxt "ELIMINANDO CARPETAS..." 39 20 1
					    sleep 0.5
					    dibujarTxt "BORRANDO VARIABLES..." 40 24 1
					    sleep 0.5
					    desinstalar
                        continuar=false
                    fi
                    ;;

                "1")
                    if $respuestaGestor;
                    then
                        continuar=false
                        colorBgDefecto=7
                    fi         
                    ;;

            esac
        done
 
    fi

}