#!/bin/bash

. "/Scripts/InterfazGrafica/Control/inicio.sh"
. "/Scripts/Computos/FTP/Config/funcFTP.sh"

VBuscarLogUsuarios() {
    #region [rgba(170, 160, 26, 0.10)] variables 
    local continuar=true
    if [ -z "$nombreFila" ];
	then
        nombreFila=""
        textoBusqueda=""
    fi
    primeraLinea="DIA MES NRO HORA AÑO IP MODIFICA USUARIO PROTOCOLO "
    #endregion
    #region [rgba(27, 173, 192, 0.10)] tui  
    
    iniciarPantallaNueva
    dibujarTxt "LOGS BUSCADOR" 41 6 0
    dibujarTxt "NOMBRE FILA: $primeraLinea" 11 8 0
    dibujarTxt "Q : para volver a el buscador" 11 9 0

    dibujarTxt "NOMBRE FILA" 11 11 0
    dibujarEntradaTxt 11 12 20 false "$nombreFila"

    dibujarTxt 'BUSQUEDA' 11 14 0
    dibujarEntradaTxt 11 15 20 false "$textoBusqueda"
    
    dibujarBoton "BUSCAR" 11 20 40 3
    dibujarBoton "VOLVER" 50 20 40 3
    #endregion
    
    while $continuar; 
    do
        siguientePos

        case $posDeEsteElemento in

            "0") #NOMBRE FILA
                if $modificado;
                then
                    nombreFila=$respuestaGestor
                fi
                ;;

            "1") #BUSQUEDA
                if $modificado;
                then 
                    textoBusqueda=$respuestaGestor
                    continuar=false
                fi     
                ;;  
            "2") #BUSCAR
                if $respuestaGestor; 
                then
                    continuar=false
                fi
                ;;            
            "3") #VOLVER
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

ejecutarVBuscarLogUsuarios() {
    VBuscarLogUsuarios
    if [ "$posDeEsteElemento" = "1" ] || [ "$posDeEsteElemento" = "2" ];
	then
        if [ "$nombreFila" ];
		then
            cerrarPantalla
            case "$nombreFila" in
                "DIA")
                    awk -v "dia=$textoBusqueda" '{if(dia==substr($1,0,length(dia))){print $0}}' /var/log/xferlog | less
                ;;
                "MES")
                    awk -v "mes=$textoBusqueda" '{if(mes==substr($2,0,length(mes))){print $0}}' /var/log/xferlog | less
                ;;
                "HORA")
                    awk -v "hora=$textoBusqueda" '{if(hora==substr($3,0,length(hora))){print $0}}' /var/log/xferlog | less
                ;;
                "AÑO")
                    awk -v "anio=$textoBusqueda" '{if(anio==substr($5,0,length(anio))){print $0}}' /var/log/xferlog | less
                ;;
                "IP")
                    awk -v "IP=$textoBusqueda" '{if(IP==substr($7,0,length(IP))){print $0}}' /var/log/xferlog | less
                ;;
                "MODIFICA")
                    awk -v "mod=$textoBusqueda" '{if(mod==substr($9,0,length(mod))){print $0}}' /var/log/xferlog | less
                ;;
                "USUARIO")
                    awk -v "us=$textoBusqueda" '{if(us==substr($14,0,length(us))){print $0}}' /var/log/xferlog | less
                ;;
                "PROTOCOLO")
                    awk -v "proto=$textoBusqueda" '{if(proto==substr($15,0,length(proto))){print $0}}' /var/log/xferlog | less
                ;;
                *)
                ;;
            esac 
        else
            cat /var/log/xferlog | less
        fi
        ejecutarVBuscarLogUsuarios
    fi
}

probarFuncionEjecucionLocal ejecutarVBuscarLogUsuarios "VBuscarLogUsuarios.sh"
