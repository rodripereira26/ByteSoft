#!/bin/bash

. "/Scripts/InterfazGrafica/Control/inicio.sh"
. "/Scripts/Computos/FTP/Config/funcFTP.sh"

VComandos() {
    #region [rgba(170, 160, 26, 0.10)] variables 
    local continuar=true
    local comandosPermitidos=$(getConfiguracion cmds_allowed)
    local comandosDenegados=$(getConfiguracion cmds_denied)
    local auxiliarComando=""
    #endregion
    #region [rgba(27, 173, 192, 0.10)] tui  
    
    iniciarPantallaNueva
    dibujarTxt "ARCHIVOS Y DIRECTORIOS" 41 6 0
    dibujarTxt "ARCHIVO DE CONFIGURACION: /etc/vsftpd/vsftpd.conf" 11 8 0

    dibujarTxt "INGRESA COMANDO" 11 11 0
    dibujarEntradaTxt 11 12 20 false "$permisosArchivosCreados"
    dibujarTxt "PERMITIDOS=$comandosPermitidos" 11 13 0
    dibujarTxt "DENEGADOS=$comandosDenegados" 11 14 0

    dibujarBoton "PERMITIR" 11 17 27 3
    dibujarBoton "DENEGAR" 38 17 27 3
    dibujarBoton "QUITAR" 65 17 27 3
    dibujarBoton "CONFIGURAR" 11 20 40 3
    dibujarBoton "CANCELAR" 51 20 41 3
    #endregion
    
    while $continuar; 
    do
        siguientePos

        case $posDeEsteElemento in

            "0") #INGRESA COMANDO
                if $modificado;
				then             
                    auxiliarComando=$respuestaGestor
                fi
                ;;
            "1") #PERMITIR
                if $respuestaGestor && [ "$auxiliarComando" ]
                then
                    dibujarTxt "$(printf "%-${#comandosPermitidos}s" ' ')" 22 13 0
                    dibujarTxt "$(printf "%-${#comandosDenegados}s" ' ')" 21 14 0
                              
                    comandosDenegados=$(quitarElemento "$auxiliarComando" "$comandosDenegados")
                    comandosPermitidos=$(quitarElemento "$auxiliarComando" "$comandosPermitidos")         

                    if [ "$comandosPermitidos" ];
			    	then
                        comandosPermitidos="$comandosPermitidos,$auxiliarComando"
                    else
                        comandosPermitidos="$auxiliarComando"
                    fi

                    dibujarTxt "$comandosPermitidos" 22 13 0
                    dibujarTxt "$comandosDenegados" 21 14 0
                fi
                ;;
            "2") #DENEGAR
                if $respuestaGestor && [ "$auxiliarComando" ]
                then    
                    dibujarTxt "$(printf "%-${#comandosPermitidos}s" ' ')" 22 13 0
                    dibujarTxt "$(printf "%-${#comandosDenegados}s" ' ')" 21 14 0

                    comandosDenegados=$(quitarElemento "$auxiliarComando" "$comandosDenegados")
                    comandosPermitidos=$(quitarElemento "$auxiliarComando" "$comandosPermitidos")         

                    if [ "$comandosDenegados" ];
			    	then
                        comandosDenegados="$comandosDenegados,$auxiliarComando"
                    else
                        comandosDenegados="$auxiliarComando"
                    fi

                    dibujarTxt "$comandosPermitidos" 22 13 0
                    dibujarTxt "$comandosDenegados" 21 14 0
                fi
                ;;
            "3") #QUITAR
                if $respuestaGestor && [ "$auxiliarComando" ]
                then
                    dibujarTxt "$(printf "%-${#comandosPermitidos}s" ' ')" 22 13 0
                    dibujarTxt "$(printf "%-${#comandosDenegados}s" ' ')" 21 14 0
                      
                    comandosDenegados=$(quitarElemento "$auxiliarComando" "$comandosDenegados")
                    comandosPermitidos=$(quitarElemento "$auxiliarComando" "$comandosPermitidos")         

                    dibujarTxt "$comandosPermitidos" 22 13 0
                    dibujarTxt "$comandosDenegados" 21 14 0
                fi
                ;;
                 
            "4") #CONFIGURAR
                if $respuestaGestor; 
                then
                    configuracionComandosDenegadosYPermitidos \
                        "$comandosPermitidos" "$comandosDenegados" \
                    systemctl restart vsftpd
                    continuar=false
                fi
                ;;           
            "5") #CANCELAR
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
ejecutarVComandos() {
    VComandos
    cerrarPantalla
}
quitarElemento(){
    #region 
    # $1 : valor
    # $2 : lista
    # retorna la lista con los valores quitados
    #endregion
    echo -n $(echo $2 | sed "s/,$1,/,/g; s/,$1$//g; s/^$1,//g; s/^$1$//g;")
}

probarFuncionEjecucionLocal ejecutarVComandos "VComandos.sh"
