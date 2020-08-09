#!/bin/bash

crearCarpetasIniciales(){

    local carpUsuarios="/home/USUARIOS"
    local carpAdministradores="/home/USUARIOS/ADMINISTRADORES"
    local carpMedicos="/home/USUARIOS/MEDICOS"
    local carpByteSoft="/var/bytesoft"
    
    if [[ -d "$carpUsuarios" && -d $carpByteSoft ]] # Si los directorios ya existen se muestra un error, de lo contrario se crean
    then
        echo 1 # Si devuelve 1, significa que las carpetas ya existen
    else
        mkdir $carpUsuarios
        mkdir $carpAdministradores
        mkdir $carpMedicos
        mkdir $carpByteSoft
        mkdir "$PATHD"
        mkdir "$PATHB"
        echo 0 # Si devuelve 0, significa que las carpetas fueron creadas
    fi

}

variablesEntorno(){

	if [ "$(grep PATHB /etc/environment | wc -l)" -eq "0"  ] # Verifico que las variables no hayan sido creadas
	then
		echo "export PATHB=/var/bytesoft/backupsBD">>/etc/environment
		echo "export PATHD=/var/bytesoft/backupsDIR">>/etc/environment
		echo "export CANTB=0">>/etc/environment
		source /etc/environment # Actualizo el valor de las variables
	fi 

}
