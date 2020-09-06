#!/bin/bash

#
#ejecutar con sudo
#tiene que haber conexion a internet desde antes de ejecutarse
#
configurarMYSQL(){
    #necesita root
    clear
    tput cup 0 40
    echo "contraseña_temporal=$(grep -i password /var/log/mysqld.log | tail -1 | cut -d" " -f13)"
    
    mysql_secure_installation
    clear

    
}
instalarMYSQL(){
    local destinoDescargas="/mysqlRPM"
    tput cup 0 0 
    yum update -y
    yum install -y libaio wget 
    mkdir $destinoDescargas 
    wget https://dev.mysql.com/get/mysql80-community-release-el7-3.noarch.rpm -O "$destinoDescargas/mysql.rpm" 2> /dev/null

    rpm -Uvh "$destinoDescargas/mysql.rpm"
    rm -r $destinoDescargas
    yum update
    yum remove -y mysql mysql-server
    mv /var/lib/mysql /var/lib/old_backup_mysql 
    yum install -y mysql mysql-server
}