#!/bin/bash

respaldarBD() {

	# $1 : Usuario de MySQL
	# $2 : Ruta destino

	local FECHA=$(date +"%d-%m-%y_%H-%M")
	local USER=$1
	local RUTA

	if [ $2 ]; 
	then
        RUTA=$2    
    else
        RUTA=$PATHB
    fi

	mysqldump --user="$USER" -p --all-databases | gzip > "$RUTA"/backupBD_"$FECHA".sql.gz # Utilizo mysqldump para realizar el backup y gzip para comprimirlo y ocupar menos memoria en el disco

	if [ -s "$RUTA"/backupBD_"$FECHA".sql.gz ]; # Verifico que el backup creado no esté vacío
	then
		#sed -i "s/'$CANTB'/'$NUM'/" /etc/environment # Si se logra el respaldo intercambio el valor anterior del contador
		#source /etc/environment
        echo 0 # Devuelve 0 si se creó el backup
	else
		rm -f "$RUTA"/backupBD_"$FECHA".sql.gz
        echo 1 # Devuelve 1 si el backup está vacío
	fi

}

respaldarDirectorios() {
	
   	# $1 Ruta Destino

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