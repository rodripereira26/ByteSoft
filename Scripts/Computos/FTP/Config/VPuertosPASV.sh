#!/bin/bash

. "/Scripts/InterfazGrafica/Control/inicio.sh"
. "/Scripts/Computos/FTP/Config/funcFTP.sh"

VPuertosPASV() {
    #region [rgba(170, 160, 26, 0.10)] variables 
    local continuar=true
    local pasvHabilitado=$(configuracionEsTrue pasv_enable '!=' NO)
    local puertoPASVmaximo=$(getConfiguracion pasv_max_port '0')
    local puertoPASVminimo=$(getConfiguracion pasv_min_port '0')
    #endregion
    #region [rgba(27, 173, 192, 0.10)] tui  
    
    iniciarPantallaNueva
    dibujarTxt "PUERTOS PASV" 41 6 0
    dibujarTxt "ARCHIVO DE CONFIGURACION: /etc/vsftpd/vsftpd.conf" 11 8 0
    dibujarTxt "RECOMENDADO: 10090 AL 10100" 11 7 0

    dibujarTxt "¿HABILITAR PASV? (YES)" 11 12 0
    dibujarSwitch 11 13 20 1 $pasvHabilitado

    dibujarTxt "PUERTO MINIMO(0: cualquier puerto)" 11 15 0
    dibujarEntradaTxt 11 16 20 false "$puertoPASVminimo"
   
    dibujarTxt "PUERTO MAXIMO(0: cualquier puerto)" 55 15 0
    dibujarEntradaTxt 55 16 20 false "$puertoPASVmaximo"
   
    dibujarBoton "CONFIGURAR" 11 20 40 3
    dibujarBoton "CANCELAR" 50 20 40 3
    #endregion
    
    while $continuar; 
    do
        siguientePos

        case $posDeEsteElemento in
            
            "0") #¿HABILITAR PASV? (YES)
                if $modificado;
				then             
                    pasvHabilitado=$respuestaGestor
                fi
                ;;
            "1") #PUERTO MINIMO(0: cualquier puerto)
                if $modificado;
				then 
                    puertoPASVminimo=$respuestaGestor
                fi                
                ;;
            "2") #PUERTO MAXIMO(0: cualquier puerto)
                if $modificado;
				then 
                    puertoPASVmaximo=$respuestaGestor
                fi        
                ;;

            "3") #CONFIGURAR
                if $respuestaGestor; 
                then
                    if [ "${puertoPASVminimo//[0-9]/}" -a "$puertoPASVminimo" -a ! "$puertoPASVminimo" = '(none)' ];
				    then #no es un numero
                        mensajeError "INGRESE UN NUMERO VÁLIDO EN PUERTO MINIMO" 1 37 33 0 1 1
                    else
                        if [ "${puertoPASVmaximo//[0-9]/}" -a "$puertoPASVmaximo" -a ! "$puertoPASVmaximo" = '(none)' ];
				        then #no es un numero
                            mensajeError "INGRESE UN NUMERO VÁLIDO EN PUERTO MAXIMO" 1 37 33 0 1 1
                        else
                            pasvHabilitado=$([ $pasvHabilitado = true ] && echo YES || echo NO) 
                            configurarPuertosPASV \
                                "$pasvHabilitado" "$puertoPASVminimo" \
                                "$puertoPASVmaximo"
                            systemctl restart vsftpd
                            continuar=false
                        fi
                    fi
                fi
                ;;          
            "4") #CANCELAR
                if $respuestaGestor; 
                then
                    continuar=false
                fi
                ;;

        esac
    done
}

ejecutarVPuertosPASV() {
    VPuertosPASV
    cerrarPantalla
}
probarFuncionEjecucionLocal ejecutarVPuertosPASV "VPuertosPASV.sh"

