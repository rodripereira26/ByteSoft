#!/bin/bash

. "/Scripts/InterfazGrafica/Control/inicio.sh"

#
#ejecutar con sudo
#tiene que haber conexion a internet desde antes de ejecutarse
#

PrincipalMysql() {

    local continuar=true
    
    #region [rgba(27, 173, 192, 0.10)] tui 
    iniciarPantallaNueva
    dibujarTxt "MYSQL" 43 3 0

    dibujarTxt "4 -> ARRIBA" 11 3 0
    dibujarTxt "5 -> ENTER " 11 4 0
    dibujarTxt "6 -> ABAJO" 11 5 0
    
    instalado=$(grep mysql /etc/environment | cut -f2 -d"=")

    if [ "$instalado" ];
    then
        dibujarBoton "DESINSTALAR" 11 6 80 3
    else 
        dibujarBoton "INSTALAR" 11 6 80 3
    fi
    
    dibujarBoton "EXPORTAR BASE DE DATOS" 11 9 80 3
    dibujarBoton "IMPORTAR BASE DE DATOS" 11 12 80 3
    dibujarBoton "VOLVER" 11 15 80 3
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

ejecutarMysql() {

    instalado=$(grep mysql /etc/environment | cut -f2 -d"=")

    local continuarCiclo=true

    while $continuarCiclo; 
    do
        PrincipalMysql
        case $posDeEsteElemento in 

            "0")
                if [ "$instalado" ];
                then
                    preguntaDesinstalarMySQL
                else
                    preguntaInstalacionMySQL
                fi
                ;;

            "1")
                exportarBD
                ;;
            "2")
                mensajeError "Funcion importar en construccion" 1 37 33 2 1 2
                ;;
            "3")
                continuarCiclo=false
                ;;
                
            *)
                ;;
        esac
        cerrarPantalla

    done

}

#region preguntar instalar-desinstalar mysql
preguntaInstalacionMySQL() {

    local continuar=true

    pregunta "¿Desea instalar MySQL?" 7 28 15 21 2 7

    while $continuar; 
    do
        siguientePos
        case $posDeEsteElemento in
                            
            "0") 
                if $respuestaGestor;
                then               
                    instalarMySQL
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

preguntaDesinstalarMySQL() {

    local continuar=true

    pregunta "¿Desea desinstalar MySQL?" 7 28 15 21 2 7
                  
                    while $continuar; 
                    do
                        siguientePos

                        case $posDeEsteElemento in

                            "0") 
                                if $respuestaGestor;
                                then

                                    desinstalarMySQL
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

#region instalar-desinstalar mysql
instalarMySQL() {

    # Instalación

    local paquetes="/etc/PaquetesSQL/"

    tput sgr0
    clear                              
    echo "Comenzará el proceso de instalación"
    sleep 3
    clear
    yum update
    yum install wget
    mkdir $paquetes
    wget http://repo.mysql.com/mysql-community-release-el7-5.noarch.rpm -O "$paquetes/repo.rpm"  > /dev/null 2>&1
    rpm -ivh mysql-community-release-el7-5.noarch.rpm
    yum update
    yum install mysql-community-server
    systemctl start mysqld
    clear
    echo "Instalación finalizada"
    sleep 3
    clear
    echo "export mysql=true">>/etc/environment
    tput sgr0
    clear
 
    #yum -y install wget
    #wget https://dev.mysql.com/get/mysql57-community-release-el7-9.noarch.rpm
    #rpm -ivh mysql57-community-release-el7-9.noarch.rpm
    #yum update 
    #yum install mysql-community-server
    #systemctl start mysqld
    #clear
    #mensajeError "Se ha instalado MySQL" 2 37 33 2 2 2
    #echo "export mysql=true">>/etc/environment
    #tput sgr0
    #clear

    # Configuración

    echo "Ingrese un espacio en blanco o, en caso de error, la siguiente contraseña: $(grep -i password /var/log/mysqld.log | head -1 | cut -d" " -f11)"
    mysql_secure_installation
    clear

}

desinstalarMySQL() {

   tput sgr0
   clear
   echo "Comenzará el proceso de desinstalación"
   sleep 3
   clear
   yum remove mysql mysql-server
   rm -rf /var/lib/mysql
   yum remove mysql57-community-release-el7-9.noarch
   yum remove mysql-community-libs-5.7.31-1.el7.x86_64
   yum remove mysql-community-common-5.7.31-1.el7.x86_64
   rm -rf "/etc/PaquetesSQL/"
   rm -f /var/log/mysqld.log 
   clear
   sed -i 's/export mysql=true//' /etc/environment
   echo "Desinstalación finalizada"
   sleep 3
   clear
   tput sgr0
   clear
   
}
#endregion

#region acciones con SQL
exportarBD() {

    local nombre=""
    local ruta=""
    local continuarExport=true

    colorBgDefecto=7
    iniciarPantallaNueva
    dibujarRectangulo 11 4 80 30 7 7 
    dibujarTxt "NOMBRE DE LA BASE DE DATOS" 11 11 0
    dibujarEntradaTxt 11 12 20 false
    dibujarTxt "DESTINO" 11 14 0
    dibujarEntradaTxt 11 15 20 true

    dibujarBoton "EXPORTAR" 11 20 40 3
    dibujarBoton "VOLVER" 50 20 40 3

    while $continuarExport; 
    do
        siguientePos

        case $posDeEsteElemento in
            
            "0")
                nombre=$respuestaGestor
                ;;
            
            "1")
                ruta=$respuestaGestor
                ;;

            "2")
                tput sgr0
                clear
                if $respuestaGestor; 
                then
                    if [ -d $ruta ];
                    then
                        #mysqldump -u root -p $nombre | gzip > "$ruta"/$nombre.sql.gz
                        mysqldump -u root -p $nombre > "$ruta"/$nombre.sql

                        if [ -e $nombre.sql ];
                        then
                            tput setaf 2
                            echo "Se ha exportado la base de datos"
                            tput sgr0
                            clear
                        else
                            tput setaf 1
                            echo "Error al exportar la base de datos"
                            tput sgr0
                            clear
                        fi
                    fi
                    tput sgr0
                    clear
                fi
                ;;

            "3")
                if $respuestaGestor; 
                then
                    continuarExport=false
                fi
                ;;

        esac

    done

}
#endregion