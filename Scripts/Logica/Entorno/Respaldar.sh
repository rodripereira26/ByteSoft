#!/bin/bash

respaldarBD() {
	# $1 : usuario de mysql
	# $2 : path destino

	local FECHA=$(date +"%d-%m-%y_%H-%M")
	local USER=$1
	local RUTA

	if [ $2 ]; 
	then
        RUTA=$2    
    else
        RUTA=$PATHB
    fi

	mysqldump --user="$USER" -p --all-databases > "$RUTA"/backupBD_"$FECHA".sql # Utilizo mysqldump para generar un backup de todas las bases de datos y lo envío a la ruta seleccionada
	
	if [ -s "$RUTA"/backupBD_"$FECHA".sql ] # Verifico que el backup creado no esté vacío
	then
		tput setaf 2
		tput cup 7 0
		sed -i 's/'$CANTB'/'$NUM'/' /etc/environment # Si se logra el resplado intercambio el valor anterior del contador
		source /etc/environment
        echo 0 # Devuelve 0 si se creó el backup
	else
		rm "$RUTA"/backupBD_"$FECHA".sql
        echo 1 # Devuelve 1 si el backup está vacío
	fi
}
respaldarDirectorios(){
   	# $1 : ruta respaldo

	local FECHA=$(date +"%d-%m-%y_%H-%M")
	local RUTA

    if [ $1 ]; 
    then
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