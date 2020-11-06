#!/bin/bash

. "/Scripts/InterfazGrafica/Control/inicio.sh"
. "/Scripts/Computos/FTP/Config/funcFTP.sh"

VMaximos() {
    #region [rgba(170, 160, 26, 0.10)] variables 
    local continuar=true
    local maximoPorIP=$(getConfiguracion max_per_ip '50')
    local maximoLoginFallido=$(getConfiguracion max_login_fails '3')
    local maximoClientes=$(getConfiguracion max_clients '2000')
    local maximoBitsSegAutentificados=$(getConfiguracion local_max_rate '0')
    #endregion
    #region [rgba(27, 173, 192, 0.10)] tui  
    
    iniciarPantallaNueva
    dibujarTxt "MAXIMOS" 41 6 0
    dibujarTxt "ARCHIVO DE CONFIGURACION: /etc/vsftpd/vsftpd.conf" 11 8 0

    dibujarTxt "MÁXIMO POR IP(50)" 11 12 0
    dibujarEntradaTxt 11 13 20 false "$maximoPorIP"
   
    dibujarTxt "MÁXIMO POR DENEGADO(3)" 11 15 0
    dibujarEntradaTxt 11 16 20 false "$maximoLoginFallido"

    dibujarTxt "MÁXIMO CLIENTES (2000)" 55 12 0
    dibujarEntradaTxt 55 13 20 false "$maximoClientes"

    dibujarTxt "MÁXIMO BYTES POR SEGUNDO AUTENTIFICADOS (default: 0 ilimitado)" 55 15 0
    dibujarEntradaTxt 55 16 20 false "$maximoBitsSegAutentificados"

    dibujarBoton "CONFIGURAR" 11 20 40 3
    dibujarBoton "CANCELAR" 50 20 40 3
    #endregion
    
    while $continuar; 
    do
        siguientePos

        case $posDeEsteElemento in
            
            "0") #MÁXIMO POR IP(50)
                if $modificado;
				then 
                    maximoPorIP=$respuestaGestor
                fi        
                ;;
            "1") #MÁXIMO POR DENEGADO(3)
                if $modificado;
				then 
                    maximoLoginFallido=$respuestaGestor
                fi                
                ;;
            "2") #MÁXIMO CLIENTES (2000)
                if $modificado;
				then 
                    maximoClientes=$respuestaGestor
                fi                
                ;;
            "3") #MÁXIMO BYTES POR SEGUNDO AUTENTIFICADOS (default: 0 ilimitado)
                if $modificado;
				then 
                    maximoBitsSegAutentificados=$respuestaGestor
                fi         
                ;;
            "4") #CONFIGURAR
                if $respuestaGestor; 
                then
                    if [ "${maximoPorIP//[0-9]/}" -a "$maximoPorIP" -a ! "$maximoPorIP" = '(none)' ];
			    	then #no es un numero
                        mensajeError "INGRESE UN NUMERO VÁLIDO EN MAXIMO POR IP" 1 37 33 0 1 1
                    else                   
                        if [ "${maximoLoginFallido//[0-9]/}" -a "$maximoLoginFallido" -a ! "$maximoLoginFallido" = '(none)' ];
			        	then #no es un numero
                            mensajeError "INGRESE UN NUMERO VÁLIDO EN MAXIMO DENEGADO" 1 37 33 0 1 1
                        else
                            if [ "${maximoClientes//[0-9]/}" -a "$maximoClientes" -a ! "$maximoClientes" = '(none)' ];
			            	then #no es un numero
                                mensajeError "INGRESE UN NUMERO VÁLIDO EN MAXIMO CLIENTES" 1 37 33 0 1 1
                            else
                                configurarMaximos "$maximoPorIP" \
                                    "$maximoLoginFallido" "$maximoClientes" \
                                    "$maximoBitsSegAutentificados"
                                systemctl restart vsftpd
                                continuar=false
                            fi
                        fi
                    fi
                fi
                ;;          
            "5") #CANCELAR
                if $respuestaGestor; 
                then
                    continuar=false
                fi
                ;;
        esac
    done
}

ejecutarVMaximos() {
    VMaximos
    cerrarPantalla
}
probarFuncionEjecucionLocal ejecutarVMaximos "VMaximos.sh"

