#!/bin/bash

. "Logica/SSH/SSH_config.sh"


VConfigurarSSH(){
    iniciarPantallaNueva
    dibujarTxt "Configurar SSH (no funciona)" 80 2

    dibujarTxt "Port" 20 5
    dibujarEntradaTxt 20 6 20 false

    dibujarTxt "PermitRootLogin" 50 5
    dibujarEntradaTxt 50 6 20 false
    
    dibujarTxt "Host" 20 8
    dibujarEntradaTxt 20 9 20 false

    dibujarTxt "AllowUsers" 50 8
    dibujarEntradaTxt 50 9 20 false

    dibujarBoton "Siguiente" 20 13 40 3
    dibujarBoton "Volver" 60 13 40 3

    local continuar=true

    port=""
    rootLogin=""
    host=""
    allowUsers=""
    intentoRegistrar=false

    while $continuar; do
        siguientePos
        case $posDeEsteElemento in
            "0")
                port=$respuestaGestor
                ;;
            "1")
                rootLogin=$respuestaGestor
                ;;
            "2")
                host=$respuestaGestor
                ;;

            "3")
                allowUsers=$respuestaGestor
                ;;
            "4")
                if $respuestaGestor; then
                    continuar=false
                    intentoRegistrar=true
                fi
                ;;
            "5")
                if $respuestaGestor; then
                    continuar=false
                fi
                ;;
            *)
                ;;
        esac
    done
}
ejecutarVConfigurarSSH(){
    local ciclo=true
    while $ciclo; do
        VConfigurarSSH
        if $intentoRegistrar; then
            #config="
            #    Port 22\n
            #    PermitRootLogin yes\n
            #    Host *\n
            #    AllowUsers AlexisUTU\n
            #"
            config="
                Port $port\n
                PermitRootLogin $rootLogin\n   
                Host $host\n
                AllowUsers $allowUsers\n
            "
            configurarSSH 22 $config  
            ciclo=false
        fi
    done
}