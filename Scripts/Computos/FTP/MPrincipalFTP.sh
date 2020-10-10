#!/bin/bash

. "/Scripts/InterfazGrafica/Control/inicio.sh"
. "/Scripts/Computos/FTP/Config/MConfiguracion.sh"
. "/Scripts/Computos/FTP/VBuscarLogUsuarios.sh"

#
#ejecutar con sudo
#tiene que haber conexion a internet desde antes de ejecutarse
#

PrincipalFTP() {
    local continuar=true
    
    #region [rgba(27, 173, 192, 0.10)] tui 

    iniciarPantallaNueva
    dibujarTxt "FTP" 43 3 0

    dibujarTxt "4 -> ARRIBA" 11 3 0
    dibujarTxt "5 -> ENTER " 11 4 0
    dibujarTxt "6 -> ABAJO" 11 5 0
    
    instalado=$(grep "export ftp" /etc/environment | cut -f2 -d"=")

    if [ "$instalado" ];
    then
        dibujarBoton "DESINSTALAR" 11 6 80 3
        dibujarBoton "CONFIGURAR" 11 9 80 3
        dibujarBoton "LOG FTP" 11 12 80 3
        dibujarBoton "VOLVER" 11 15 80 3
    else 
        dibujarBoton "INSTALAR" 11 6 80 3
        dibujarBoton "VOLVER" 11 9 80 3
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

ejecutarFTP() {

    instalado=$(grep "export ftp" /etc/environment | cut -f2 -d"=")

    local continuarCiclo=true

    while $continuarCiclo; 
    do
        PrincipalFTP
        case $texto in 

            "DESINSTALAR")
                preguntaDesinstalarFTP  
                ;;
            "INSTALAR")
                preguntaInstalacionFTP  
                ;;
            "CONFIGURAR")
                ejecutarVConfigFTP
                ;;
            "LOG FTP")
                ejecutarVBuscarLogUsuarios
                ;;
            "VOLVER")
                continuarCiclo=false
                ;;
            *)
                ;;
        esac
        cerrarPantalla
    done
}

#region preguntar instalar-desintalar con FTP
preguntaInstalacionFTP() {
    local continuar=true

    pregunta "¿Desea instalar FTP?" 7 28 15 21 2 7

    while $continuar; 
    do
        siguientePos
        case $posDeEsteElemento in
                            
            "0") 
                if $respuestaGestor;
                then               
                    instalarFTP
                    continuar=false
                    colorBgDefecto=7
                fi
                ;;

            "1")
                if $respuestaGestor;
                then
                    continuar=false
                    colorBgDefecto=7
                fi         
                ;;

            *)  
                ;;

        esac
    done

}

preguntaDesinstalarFTP() {
    local continuar=true

    pregunta "¿Desea desinstalar FTP?" 7 28 15 21 2 7
    
    while $continuar; 
    do
        siguientePos

        case $posDeEsteElemento in

            "0") 
                if $respuestaGestor;
                then

                    desinstalarFTP
                    continuar=false
                    colorBgDefecto=7
                fi
                ;;

            "1")
                if $respuestaGestor;
                then
                    continuar=false
                    colorBgDefecto=7
                fi         
                ;;

            *)  
                ;;

        esac
    done
}
#endregion
#region instalar-desintalar con FTP
instalarFTP() {

    # Instalación

    tput sgr0
    clear                              
    echo "COMENZARÁ EL PROCESO DE INSTALACIÓN"
    sleep 1.5
    clear
    yum -y update
    yum -y install wget vsftpd
    yum -y update
    systemctl start vsftpd
    clear
    echo "INSTALACIÓN FINALIZADA"
    sleep 1.5
    clear
    echo "export ftp=true">>/etc/environment
    tput sgr0
    clear
}
desinstalarFTP() {

   tput sgr0
   clear
   echo "COMENZARÁ EL PROCESO DE DESINSTALACIÓN"
   sleep 1.5
   clear
   yum -y remove vsftpd
   clear
   sed -i 's/export ftp=true//' /etc/environment
   echo "DESINSTALACIÓN FINALIZADA"
   sleep 1.5
   clear
   tput sgr0
   clear
   
}
#endregion
probarFuncionEjecucionLocal ejecutarFTP "MPrincipalFTP.sh"
