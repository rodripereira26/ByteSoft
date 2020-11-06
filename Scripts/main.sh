#!/bin/bash

# Para acceder a OTROS privilegios, ejecutar con root
# hay opciones que solo estan para usuarios no root

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
    

    # if [ $(hostname -I | cut -d" " -f1) = "$IP_SERVIDOR" ];
    # then
    dibujarBoton "CENTRO DE COMPUTOS" 11 11 80 3
    # fi
    if [ $EUID -eq 0 ];
    then
        dibujarBoton "CONFIGURACIÓN DEL ENTORNO" 11 14 80 3 #necesita root 
        dibujarBoton "DESINSTALAR ENTORNO" 11 17 80 3 #necesita root 
        if [ $(hostname -I | cut -d" " -f1) = "$IP_SERVIDOR" ];
        then
            if [ $(grep -c "export sshRespaldos=true" /etc/environment) = "0" ];  
            then
                dibujarBoton "ENVIAR SSH-COPY-ID SERVIDOR RESPALDOS" 11 20 80 3 #necesita bytesoftRespaldo 
                dibujarBoton "ENVIAR /SCRIPTS A RESPALDOS" 11 23 80 3
                dibujarBoton "SALIR" 11 26 80 3
            else
                dibujarBoton "SINCRONIZAR /SCRIPTS CON RESPALDOS" 11 20 80 3
                dibujarBoton "SALIR" 11 23 80 3
            fi
        elif [ $(hostname -I | cut -d" " -f1) = "$IP_RESPALDO" ];
        then
            dibujarBoton "SALIR" 11 20 80 3
        else
            dibujarBoton "SALIR" 11 20 80 3
        fi 
    else
        dibujarBoton "SALIR" 11 14 80 3
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
                
            "ENVIAR /SCRIPTS A RESPALDOS")
                tput sgr0
                clear
                ssh -o ConnectTimeout=10 root@$IP_RESPALDO "sudo rm -r /Scripts/*"
                if [ $? -eq 0 ];
                then
                    rsync -az -e ssh "/Scripts/" root@$IP_RESPALDO:/Scripts
                fi
                sleep 1.5
                ;;

            "SINCRONIZAR /SCRIPTS CON RESPALDOS")
                tput sgr0
                clear
                yum install -y rsync
                sleep 0.5
                clear
                ssh -p 2022 bytesoftRespaldo@$IP_RESPALDO "rm -r /Scripts"
                tput cup 0 0
                rsync -az -e "ssh -p 2022" "/Scripts/" bytesoftRespaldo@$IP_RESPALDO:/Scripts
                sleep 1
                ;;

            "ENVIAR SSH-COPY-ID SERVIDOR RESPALDOS")
                clear
                . /etc/environment  
                ssh-copy-id -p 2022 bytesoftRespaldo@$IP_RESPALDO
                if [ $? -eq 0 ];
                then
                    echo "export sshRespaldos=true" | sudo tee -a /etc/environment
                    mensajeError "SSH-KEY ENVIADO" 2 37 33 2 2 2
                    . /etc/environment
                else
                    if ping -c1 $IP_RESPALDO &>/dev/null;
                    then
                        mensajeError "ASEGURESE DE HABER CONFIGURADO RESPALDOS" 1 37 33 2 1 2
                    else
                        mensajeError "NO SE DETECTÓ CONEXIÓN AL EQUIPO" 1 37 33 2 1 2
                    fi
                fi
                sleep 1
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
    clear
    # animacionTitulo "/Scripts/InterfazGrafica/Vista/ElementosExtra/tituloByteSoft.txt" 10 10
    ejecutarMain
}
main
