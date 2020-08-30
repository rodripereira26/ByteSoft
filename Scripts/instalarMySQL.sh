#!/bin/bash

#
#ejecutar con sudo
#tiene que haber conexion a internet desde antes de ejecutarse
#

instalarMYSQL(){
    local destinoDescargas="/mysqlRPM"

    yum update -q -y > /dev/null
    yum install -q -y libaio 
    mkdir $destinoDescargas 2> /dev/null
    wget https://dev.mysql.com/get/mysql80-community-release-el7-3.noarch.rpm -O "$destinoDescargas/mysql.rpm" 2> /dev/null

    rpm -Uvh "$destinoDescargas/mysql.rpm"
    rm -r $destinoDescargas
    yum update -q -y > /dev/null
    yum install -q -y mysql-server
}
instalarMYSQL