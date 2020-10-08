#!/bin/bash

# SECTION - COMANDO PARA SINCRONIZAR /Scripts en la maquina de respaldos
: ' 
ssh bytesoftRespaldoEntrada@$IP_RESPALDO "sudo rm -r /Scripts"
rsync -az -e ssh "/Scripts/" bytesoftRespaldoEntrada@$IP_RESPALDO:/Scripts 
'
# Para acceder a OTROS privilegios, ejecutar con root
# hay opciones que solo estan para usuarios no root
#f


#region imports
. "/Scripts/InterfazGrafica/Control/inicio.sh" 
. "/Scripts/Computos/VPrincipalComputos.sh"
. "/Scripts/ConfigurarEntorno/VPrincipalMenuConfigEntorno.sh"
. "/Scripts/ConfigurarEntorno/Logica/funciones.sh" 
#endregion

Principal() {
    local continuar=true
    #region [rgba(27, 173, 192, 0.10)] tui 
    
    iniciarPantallaNueva 
    dibujarTxt "MENU PRINCIPAL" 43 5 0

    dibujarTxt "4 -> ARRIBA" 11 7 0
    dibujarTxt "5 -> ENTER " 11 8 0
    dibujarTxt "6 -> ABAJO" 11 9 0
    dibujarTxt "ESC -> SALIR DE INPUT" 11 10 0
    
    dibujarBoton "CENTRO DE COMPUTOS" 11 11 80 3

    if [ $EUID -eq 0 ];
    then
        dibujarBoton "CONFIGURACIÓN DEL ENTORNO" 11 14 80 3 #necesita root 
        dibujarBoton "DESINSTALAR ENTORNO" 11 17 80 3 #necesita root 
        dibujarBoton "SALIR" 11 20 80 3
    else
        if [ $(hostname -I) = "192.168.1.10" ] && [ $(whoami) = "bytesoftRespaldoEntrada" ] && [ $(grep -c "export sshRespaldos=true" /etc/environment) = "0" ];  
        then
            dibujarBoton "ENVIAR SSH-COPY-ID SERVIDOR RESPALDOS" 11 14 80 3 #necesita bytesoftRespaldoEntrada 
            dibujarBoton "SALIR" 11 17 80 3
        else
            dibujarBoton "SALIR" 11 14 80 3
        fi
    fi
    #endregion
   
    while $continuar; 
    do
        siguientePos

        if $respuestaGestor; 
        then
            continuar=false
        fi 
    done

}
ejecutarMain() {

    local continuarCiclo=true
    while $continuarCiclo; 
    do
        Principal
        case $texto in 

            "CENTRO DE COMPUTOS")
                ejecutarComputos
                ;;

            "CONFIGURACIÓN DEL ENTORNO")
                preguntaInstalacion
                colorBgDefecto=7
                ;;

            "DESINSTALAR ENTORNO")
                preguntaDesinstalar
                ;;
            "ENVIAR SSH-COPY-ID SERVIDOR RESPALDOS")
                clear
                ssh-copy-id -p 2022 bytesoftRespaldoEntrada@$IP_SERVIDOR # FIXME - cambiar a lo que no sea root 

                echo "export sshRespaldos=true" | sudo tee -a /etc/environment
                . /etc/environment  

                ;;
            "SALIR")
                continuarCiclo=false
                ;;

            *)
                ;;
        esac
        cerrarPantalla
    done

}

main() {
    
    tput sgr0
    tput civis
    #animacionTitulo "/Scripts/InterfazGrafica/Vista/ElementosExtra/tituloByteSoft.txt" 10 10
    ejecutarMain
}
main
