#!/bin/bash

. "/Scripts/InterfazGrafica/Control/inicio.sh"
. "/Scripts/Computos/FTP/configFTP.sh"
#
#ejecutar con sudo
#tiene que haber conexion a internet desde antes de ejecutarse
#

PrincipalFTP() {
    local continuar=true
    
    #region tui

    iniciarPantallaNueva
    dibujarTxt "FTP" 43 3 0

    dibujarTxt "4 -> ARRIBA" 11 3 0
    dibujarTxt "5 -> ENTER " 11 4 0
    dibujarTxt "6 -> ABAJO" 11 5 0
    
    instalado=$(grep ftp /etc/environment | cut -f2 -d"=")

    if [ "$instalado" ];
    then
        dibujarBoton "DESINSTALAR" 11 6 80 3
    else 
        dibujarBoton "INSTALAR" 11 6 80 3
    fi
    
    dibujarBoton "ACCESO USUARIOS" 11 9 80 3
    dibujarBoton "CONFIGURAR" 11 9 80 3
    dibujarBoton "VOLVER" 11 12 80 3
    
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

    instalado=$(grep ftp /etc/environment | cut -f2 -d"=")

    local continuarCiclo=true

    while $continuarCiclo; 
    do
        PrincipalFTP
        case $posDeEsteElemento in 

            "0")
                if [ "$instalado" ];
                then
                    preguntaDesinstalarFTP  
                else
                    preguntaInstalacionFTP 
                fi
                ;;

            "1")
                mensajeError "ACCESO EN CONSTRUCCION" 1 37 33 2 1 2
                ;;
            "2")
                mensajeError "CONFIGURACION EN CONSTRUCCION" 1 37 33 2 1 2
                ;;
            "3")
                continuarCiclo=false
                ;;
                
            *)
                continuarCiclo=false
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
    echo "Comenzará el proceso de instalación"
    sleep 3
    clear
    yum -y update
    yum -y install wget vsftpd
    yum -y update
    systemctl start vsftpd
    clear
    echo "Instalación finalizada"
    sleep 3
    clear
    echo "export ftp=true">>/etc/environment
    tput sgr0
    clear
 : '
    yum -y install wget
    wget https://dev.mysql.com/get/mysql57-community-release-el7-9.noarch.rpm
    rpm -ivh mysql57-community-release-el7-9.noarch.rpm
    yum update 
    yum install mysql-community-server
    systemctl start mysqld
    clear
    mensajeError "Se ha instalado MySQL" 2 37 33 2 2 2
    echo "export ftp=true">>/etc/environment
    tput sgr0
    clear
'
}
desinstalarFTP() {

   tput sgr0
   clear
   echo "Comenzará el proceso de desinstalación"
   sleep 3
   clear
   yum -y remove vsftpd
   clear
   sed -i 's/export ftp=true//' /etc/environment
   echo "Desinstalación finalizada"
   sleep 3
   clear
   tput sgr0
   clear
   
}
#endregion
