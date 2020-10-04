#!/bin/bash

#necesita root

. "/Scripts/InterfazGrafica/Control/inicio.sh"

VConfigRedParaLocal() {
    # $1 : tipo (SERVIDOR, RESPALDO, SUBRED_ADMIN)

    #region [rgba(170, 160, 26, 0.10)] variables  locales
    local continuar=true
    local _IP_SERVIDOR=""
    local _IP_RESPALDO=""
    local _IP_SUBRED_ADMIN=""
    local patronIP_RESPALDO="(?<=export IP_RESPALDO=)\d+.\d+.\d+.\d+"
    local patronIP_SUBRED_ADMIN="(?<=export IP_SUBRED_ADMIN=)\d+.\d+.\d+.\d+:\d+"
    local patronIP_SERVIDOR="(?<=export IP_SERVIDOR=)\d+.\d+.\d+.\d+"
    #endregion
    #region [rgba(27, 173, 192, 0.10)] tui
    iniciarPantallaNueva
    dibujarTxt "CONFIGURACION DE RED" 41 6 0

    dibujarTxt "IP SERVIDOR" 11 11 0
    dibujarEntradaTxt 11 12 20 false

    dibujarTxt "IP PARA RESPALDOS" 40 11 0
    dibujarEntradaTxt 40 12 20 false

    dibujarTxt "IP PARA ADMINISTRADORES(IP/PREFIX)" 11 14 0
    dibujarEntradaTxt 11 15 20 false

    dibujarBoton "SIGUIENTE" 11 20 80 3
    #endregion

    while $continuar;
    do

        siguientePos
: ' al comentar este comentario se puede ir a SIGUIENTE sin insertar las variables (para pruebas)
        _IP_SERVIDOR="192.168.1.9"
        _IP_RESPALDO="192.168.1.10"
        _IP_SUBRED_ADMIN="192.168.100.97/24"
'
        case $posDeEsteElemento in
            "0")
                if $modificado; then
                    _IP_SERVIDOR=$respuestaGestor
                fi
                ;;
            
            "1")
                if $modificado; then
                    _IP_RESPALDO=$respuestaGestor
                fi
                ;;
            "2")
                if $modificado; then
                    _IP_SUBRED_ADMIN=$respuestaGestor
                fi
                ;;

            "3")
                if $respuestaGestor; then
                    if [ "$_IP_SERVIDOR" -a "$_IP_RESPALDO" -a "$_IP_SUBRED_ADMIN" ]; then

                        ping -c1 "$_IP_SERVIDOR" &> /dev/null
                        if [ $? -eq 0 ] && [ $(hostname -I) != "$_IP_SERVIDOR" ]; then
                            mensajeError "YA HAY UNA IP EN LA RED" 1 37 33 2 1 2
                        else
                            mensajeError "CONFIGURE LA RED..." 2 37 33 0 2 2

                            rm /etc/sysconfig/network-scripts/*
                            nmtui-edit
                            systemctl restart NetworkManager

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
                            mensajeError "TERMINÓ LA CONFIGURACION" 2 37 33 2 2 2
                        fi
                    else
                        mensajeError "INGRESE TODOS LOS CAMPOS" 1 37 33 2 1 2
                    fi
                fi
                ;;
        esac
    done
    cerrarPantalla
}
probarFuncionEjecucionLocal VConfigRedParaLocal "SERVIDOR"