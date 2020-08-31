#!/bin/bash

#
#
# root obligatorio 
#
#
. "/Scripts/InterfazGrafica/Control/inicio.sh" 

. "/Scripts/ConfigurarEntorno/Logica/CrearCarpetasYVariables.sh"
. "/Scripts/ConfigurarEntorno/Logica/funciones.sh" 
. "/Scripts/ConfigurarEntorno/SSH/VConfigSSH.sh" 
. "/Scripts/ConfigurarEntorno/MySQL/configMySQL.sh"

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
                        pantallaInstalacion
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

    else
         mensajeError "LA INSTALACIÓN YA FUE REALIZADA" 1 36 33 2 3 1 1  
    fi
    
}

pantallaInstalacion() {
    
    colorBgDefecto=7
    iniciarPantallaNueva
    dibujarRectangulo 11 4 80 30 7 7 
    dibujarTxt "CONFIGURANDO ENTORNO" 41 5 7

    while $continuar
    do
        case $(variablesEntorno) in

            "0") 
                dibujarTxt "Configurando variables..." 37 8 1
                sleep 2
                ;;

            "1")
                mensajeError "LAS VARIABLES YA FUERON CREADAS" 1 37 33 2 3 1 1
                desinstalar
                continuar=false
                ;;
        esac

        case $(crearCarpetasIniciales) in 

            "0")
                dibujarTxt "Creando Carpetas..." 40 12 1    
                sleep 2
               ;;
                            
            "1")
                mensajeError "LAS CARPETAS YA FUERON CREADAS" 1 37 33 2 3 1 1
                desinstalar
                continuar=false
                ;;
        esac

        case $(crontabConf) in

            "0")
                dibujarTxt "Configurando crontab..." 38 16 1
                sleep 2
                ;;
                            
            "1")
                mensajeError "EL CRONTAB YA FUE CONFIGURADO" 1 37 33 2 3 1 1
                desinstalar
                continuar=false
                ;;
        esac

        dibujarTxt "Configurando firewall..." 38 20 1
        firewallConf
        sleep 2
        
        let PUERTO=$(grep "#Port 22" /etc/ssh/sshd_config | cut -f2 -d" ")

        if [ $PUERTO -eq 2 ]; 
        then
            continuar=false
            colorBgDefecto=7
        else 
            dibujarTxt "Configurando SSH..." 40 24 1 
            sleep 2
            colorBgDefecto=0
            pantallaSSH
            continuar=false
        fi
        instalarMYSQL
        configurarMYSQL
        
    done
}

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
					    dibujarTxt "Desinstalando firewall..." 37 8 1
					    sleep 2
					    dibujarTxt "Desinstalando SSH..." 39 12 1
					    sleep 2
					    dibujarTxt "Desinstalando crontab..." 38 16 1
					    sleep 2
					    dibujarTxt "Eliminando carpetas..." 39 20 1
					    sleep 2
					    dibujarTxt "Borrando variables..." 40 24 1
					    sleep 2
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