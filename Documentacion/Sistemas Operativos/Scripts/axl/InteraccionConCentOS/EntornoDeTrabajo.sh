#!/bin/bash

crearCarpetasIniciales(){
    local carpUsuarios="/home/USUARIOS"
    local carpAdministradores="/home/USUARIOS/ADMINISTRADORES"
    local carpMedicos="/home/USUARIOS/MEDICOS"
    local carpByteSoft="/var/bytesoft"
    
    if [[ -d "$carpUsuarios" && -d $carpByteSoft ]] #Si los directorios ya existen se muestra un error, de lo contrario se crean
    then
        echo 1 # ya existen los directorios
    else
        mkdir $carpUsuarios
        mkdir $carpAdministradores
        mkdir $carpMedicos
        mkdir $carpByteSoft
        mkdir "$PATHD"
        mkdir "$PATHB"
        echo 0 #se ejecuto bien
    fi

}
respaldarBD(){
	# $1 : usuario de mysql
	# $2 : path destino

	local FECHA=$(date +"%d-%m-%y_%H-%M")
	local USER=$1
	local RUTA=$2

	mysqldump --user="$USER" -p --all-databases > "$RUTA"/backupBD_"$FECHA".sql #Utilizo mysqldump para generar un backup de todas las bases de datos y lo envío a la ruta seleccionada
	
	if [ -s "$RUTA"/backupBD_"$FECHA".sql ] #Verifico que el backup creado no esté vacío
	then
		tput setaf 2
		tput cup 7 0
		sed -i 's/'$CANTB'/'$NUM'/' /etc/environment #Si se logra el resplado intercambio el valor anterior del contador
		source /etc/environment
        echo 0 
	else
		rm "$RUTA"/backupBD_"$FECHA".sql
        echo 1
	fi
}
respaldarDirectorios(){
   	# $1 : ruta respaldo

	local FECHA=$(date +"%d-%m-%y_%H-%M")
	local RUTA

    if [ $1 ]; then
        RUTA=$1    
    else
        RUTA=$PATHD
    fi

  	if [ -d "$RUTA"/backupDIR_"$FECHA"/ ] #Verifico si existe el directorio del backup
    then
        echo 1 # la copia ya existe
    else
        mkdir "$RUTA"/backupDIR_"$FECHA"/
		cp -r /home/USUARIOS "$RUTA"/backupDIR_"$FECHA"
        echo 0 # se ha creado la copia
    fi

}
variablesEntorno(){
	if [ "$(grep PATHB /etc/environment | wc -l)" -eq "0"  ] #Verifico que las variables no hayan sido creadas
	then
		echo "export PATHB=/var/bytesoft/backupsBD">>/etc/environment
		echo "export PATHD=/var/bytesoft/backupsDIR">>/etc/environment
		echo "export CANTB=0">>/etc/environment
		source /etc/environment #Actualizo el valor de las variables
	fi 
}
