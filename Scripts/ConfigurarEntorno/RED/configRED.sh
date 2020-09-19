#!/usr/bin/bash
#necesita root 

. "/Scripts/InterfazGrafica/Control/inicio.sh" 

VConfigRedParaLocal() {
    # $1 : tipo (SERVIDOR, RESPALDO, SUBRED_ADMIN)

    #region variables locales
    local continuar=true
    local _IP_SERVIDOR=""
    local _PREFIX=""
    local _GATEWAY=""
    local _DNS=""
    local _IP_RESPALDO=""
    local _IP_SUBRED_ADMIN=""
    local patronIP_RESPALDO="(?<=export IP_RESPALDO=)\d+.\d+.\d+.\d+"
    local patronIP_SUBRED_ADMIN="(?<=export IP_SUBRED_ADMIN=)\d+.\d+.\d+.\d+:\d+"
    local patronIP_SERVIDOR="(?<=export IP_SERVIDOR=)\d+.\d+.\d+.\d+"
    #endregion
    #region tui
    iniciarPantallaNueva
    dibujarTxt "CONFIGURACION DE RED" 41 6 0

    dibujarTxt "IP SERVIDOR" 11 11 0
    dibujarEntradaTxt 11 12 20 false

    dibujarTxt "PREFIX" 11 14 0
    dibujarEntradaTxt 11 15 20 false

    dibujarTxt "PUERTA DE ENLACE" 40 11 0
    dibujarEntradaTxt 40 12 20 false

    dibujarTxt "DNS" 40 14 0
    dibujarEntradaTxt 40 15 20 false
    
    dibujarTxt "IP PARA RESPALDOS" 65 11 0
    dibujarEntradaTxt 65 12 20 false
    
    dibujarTxt "IP PARA ADMINISTRADORES(IP/PREFIX)" 65 14 0
    dibujarEntradaTxt 65 15 20 false

    dibujarBoton "SIGUIENTE" 11 20 80 3
    #endregion

    while $continuar; 
    do

        siguientePos
: ' al comentar este comentario se puede ir a SIGUIENTE sin insertar las variables (para pruebas)
        IP_SERVIDOR="192.168.1.9"
        PREFIX="24"
        GATEWAY="192.168.1.1"
        DNS="8.8.8.8"
        IP_RESPALDO="192.168.1.10"
        IP_SUBRED_ADMIN="192.168.100.97/24"
'       
        case $posDeEsteElemento in
            "0")
                if $modificado; then 
                    _IP_SERVIDOR=$respuestaGestor
                fi
                ;;
            "1")
                if $modificado; then 
                    _PREFIX=$respuestaGestor
                fi
                ;;
            "2")
                if $modificado; then                    
                    _GATEWAY=$respuestaGestor
                fi              
                ;;
            "3")
                if $modificado; then 
                    _DNS=$respuestaGestor
                fi
                ;;
            "4")
                if $modificado; then 
                    _IP_RESPALDO=$respuestaGestor
                fi
                ;;
            "5")
                if $modificado; then 
                    _IP_SUBRED_ADMIN=$respuestaGestor
                fi
                ;;
            
            "6")
                if $respuestaGestor; then
                    if [ "$_IP_SERVIDOR" -a "$_PREFIX" -a "$_GATEWAY" -a "$_DNS" ] && \
                        [ "$_IP_RESPALDO" -a "$_IP_SUBRED_ADMIN" ]; then
                    
                        ping -c1 "$_IP_SERVIDOR" &> /dev/null
                        if [ $? -eq 0 ] && [ $(hostname -I) != "$_IP_SERVIDOR" ];then 
                            mensajeError "Ya hay una ip en la red" 1 37 33 2 1 2
                        else
                            mensajeError "Configurando..." 2 37 33 0 2 2
                            case $1 in
                                "SERVIDOR")
                                    configurarRed $_IP_SERVIDOR $_PREFIX $_GATEWAY $_DNS
                                    ;;
                                "RESPALDO")
                                    configurarRed $_IP_RESPALDO $_PREFIX $_GATEWAY $_DNS
                                    ;;
                                "SUBRED_ADMIN")
                                    configurarRed ${_IP_SUBRED_ADMIN%%:*} ${_IP_SUBRED_ADMIN##*:} $_GATEWAY $_DNS
                                    ;;
                            esac

                            
                            if [ "$(grep IP_RESPALDO /etc/environment | wc -l)" -eq "0" ]; then
                                echo "export IP_RESPALDO=$_IP_RESPALDO" >> /etc/environment
                            else
                                perl -pe "s/$patronIP_RESPALDO/$_IP_RESPALDO/g" -i /etc/environment
                            fi

                            if [ "$(grep IP_SUBRED_ADMIN /etc/environment | wc -l)" -eq "0" ]; then
                                echo "export IP_SUBRED_ADMIN=${_IP_SUBRED_ADMIN/"/"/:}" >> /etc/environment
                            else
                                perl -pe "s/$patronIP_SUBRED_ADMIN/${_IP_SUBRED_ADMIN/"/"/:}/g" -i /etc/environment
                            fi

                            if [ "$(grep IP_SERVIDOR /etc/environment | wc -l)" -eq "0" ]; then
                                echo "export IP_SERVIDOR="$_IP_SERVIDOR"" >> /etc/environment
                            else
                                perl -pe "s/$patronIP_SERVIDOR/$"$_IP_SERVIDOR"/g" -i /etc/environment
                            fi
                            
                            . "/etc/environment"
                            
                            continuar=false
                            mensajeError "Terminó la configuracion" 2 37 33 2 2 2
                        fi
                    else
                        mensajeError "Ingrese todos los campos" 1 37 33 2 1 2
                    fi
                fi
                ;;
        esac
    done
    cerrarPantalla
}

configurarRed(){
    #region argumentos
    # $1 : ip mi maquina
    # $2 : prefix
    # $3 : puerta de enlace
    # $4 : dns (8.8.8.8)
    #endregion
   
    local ifcfg_auxiliar="/Scripts/ConfigurarEntorno/RED/ifcfg-enp0s3nuevo"
    local ifcfg_viejo="/Scripts/ConfigurarEntorno/RED/ifcfg-enp0s3viejo"
    local ifcfg_local="/etc/sysconfig/network-scripts/ifcfg-enp0s3"

    cp $ifcfg_auxiliar $ifcfg_local

    sed -i "s/IPADDR=ip/IPADDR=$1/g" $ifcfg_local
    sed -i "s/PREFIX=prefix/PREFIX=$2/g" $ifcfg_local
    sed -i "s/GATEWAY=gateway/GATEWAY=$3/g" $ifcfg_local
    sed -i "s/DNS1=dns/DNS1=$4/g" $ifcfg_local

    systemctl restart network 2> /dev/null
}
#configurarRed 192.168.1.9 24 192.168.1.1 8.8.8.8
#VConfigRedParaLocal "SERVIDOR"
