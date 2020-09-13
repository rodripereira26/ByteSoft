#!/usr/bin/bash
#necesita root 

. "/Scripts/InterfazGrafica/Control/inicio.sh" 

VConfigRed() {

    local continuar=true
    local IP=""
    local PREFIX=""
    local GATEWAY=""
    local DNS=""
    local IP_RESPALDO=""
    local IP_SUBRED_ADMIN=""
    #prueba

    local patronIP_RESPALDO="(?<=export IP_RESPALDO=)\d+.\d+.\d+.\d+"
    local patronIP_SUBRED_ADMIN="(?<=export IP_SUBRED_ADMIN=)\d+.\d+.\d+.\d+"


    iniciarPantallaNueva
    dibujarTxt "CONFIGURACION DE RED" 41 6 0

    dibujarTxt "IP" 11 11 0
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

    dibujarBoton "SIGUIENTE" 11 20 40 3
    dibujarBoton "VOLVER" 50 20 40 3

    while $continuar; 
    do

        siguientePos
#: '
#al descomentar estas lineas solo se insertan las variables
        IP="192.168.1.9"
        PREFIX="24"
        GATEWAY="192.168.1.1"
        DNS="8.8.8.8"
        IP_RESPALDO="192.168.1.10"
        IP_SUBRED_ADMIN="192.168.100.97/24"
#'       
        case $posDeEsteElemento in
            "0")
                IP=$respuestaGestor
                ;;
            "1")
                PREFIX=$respuestaGestor
                ;;
            "2")
                GATEWAY=$respuestaGestor
                ;;
            "3")
                DNS=$respuestaGestor
                ;;
            "4")
                IP_RESPALDO=$respuestaGestor
                ;;
            "5")
                IP_SUBRED_ADMIN=$respuestaGestor
                ;;
            "6")
                if $respuestaGestor; then
                    if [ $IP -a $PREFIX -a $GATEWAY -a $DNS ] && \
                        [ $IP_RESPALDO -a $IP_SUBRED_ADMIN ]; then
                    
                        ping -c1 $IP &> /dev/null
                        if [ $? -eq 0 ] && [ $(hostname -I) != $IP ];then 
                            mensajeError "Ya hay una ip en la red" 1 37 33 2 1 2
                        else
                            mensajeError "Configurando..." 2 37 33 0 2 2
                            configurarRed $IP $PREFIX $GATEWAY $DNS

                            if [ "$(grep IP_RESPALDO /etc/environment | wc -l)" -eq "0" ]; then
                                echo "export IP_RESPALDO=$IP_RESPALDO" >> /etc/environment
                            else
                                perl -pe "s/$patronIP_RESPALDO/$IP_RESPALDO/g" -i /etc/environment
                            fi

                            if [ "$(grep IP_SUBRED_ADMIN /etc/environment | wc -l)" -eq "0" ]; then
                                echo "export IP_SUBRED_ADMIN=$IP_SUBRED_ADMIN" >> /etc/environment
                            else
                                perl -pe "s/$patronIP_SUBRED_ADMIN/$IP_SUBRED_ADMIN/g" -i /etc/environment
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
            "7")
                if $respuestaGestor; then
                    continuar=false
                fi
                ;;

        esac

    done


}

configurarRed(){
    # $1 : ip mi maquina
    # $2 : prefix
    # $3 : puerta de enlace
    # $4 : dns (8.8.8.8)

    local ifcfg_auxiliar="/Scripts/ConfigurarEntorno/RED/ifcfg-enp0s3nuevo"
    local ifcfg_viejo="/Scripts/ConfigurarEntorno/RED/ifcfg-enp0s3viejo"
    local ifcfg_a_remplazar="/etc/sysconfig/network-scripts/ifcfg-enp0s3"

    cp $ifcfg_auxiliar $ifcfg_a_remplazar

    sed -i "s/IPADDR=ip/IPADDR=$1/g" $ifcfg_a_remplazar
    sed -i "s/PREFIX=prefix/PREFIX=$2/g" $ifcfg_a_remplazar
    sed -i "s/GATEWAY=gateway/GATEWAY=$3/g" $ifcfg_a_remplazar
    sed -i "s/DNS1=dns/DNS1=$4/g" $ifcfg_a_remplazar

    systemctl restart network
}
#configurarRed 192.168.1.9 24 192.168.1.1 8.8.8.8
VConfigRed
