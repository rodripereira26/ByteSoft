#!/bin/bash
export LANG=C.UTF-8

crearDirectorios()
{	
	if [[ -d /home/USUARIOS && -d /var/bytesoft ]] #Si los directorios ya existen se muestra un error, de lo contrario se crean
	then
		tput setaf 1	
		echo "Los directorios ya han sido creados"
		tput sgr0
		sleep 2
	else
		mkdir /home/USUARIOS
		mkdir /home/USUARIOS/MEDICOS
		mkdir /home/USUARIOS/ADMINISTRADORES
		mkdir /var/bytesoft
		mkdir "$PATHD"
		mkdir "$PATHB"
		echo "Creando directorios..."
		sleep 2
		tput setaf 2
		echo "Directorios creados"
		sleep 2
		tput sgr0
	fi
}

variablesEntorno()
{
	if [ "$(grep PATHB /etc/environment | wc -l)" -eq "0"  ] #Verifico que las variables no hayan sido creadas
	then
		echo "export PATHB=/var/bytesoft/backupsBD">>/etc/environment
		echo "export PATHD=/var/bytesoft/backupsDIR">>/etc/environment
		echo "export CANTB=0">>/etc/environment
		source /etc/environment #Actualizo el valor de las variables
	fi 
}

rutaRespaldo()
{
	local opc=

	while [[ "$op" != 's' &&  "$op" != 'n' ]]
	do
	clear
	echo "¿Desea guardar el respaldo en la ruta predeterminada? (s/n):"
	tput cup 0 61
	read op
	
	case $op in

		'n')
			while [ "$opc" != "s" ]
			do
				clear	
				tput cup 0 0
				echo "Ingrese una ruta para el respaldo:"
				tput cup 0 35
				read RUTA

				if [ -d "$RUTA" ]
				then
					tput cup 2 0
					echo "¿La ruta $RUTA es correcta? (s/n):"
					read opc

					if [ "$opc" = "s" ]
					then
						opc=s
					else
						opc=a
					fi
				else
					tput cup 3 0
					tput setaf 1
					echo "Ingresó una ruta incorrecta"
					tput sgr0
					sleep 2
					opc=a
				fi

			done
			;;

		's')
			tput cup 2 0
			echo "El respaldo se guardará en la ruta "
			tput cup 2 35
			tput setaf 2
			echo $1
			RUTA=$1
			tput sgr0
			;;

		*) 
			tput cup 2 0
			tput setaf 1
			echo "Ingresó una opción incorrecta"
			tput sgr0
			sleep 2;
			op=1
			;;
		esac
	done
}

respaldoBD()
{	
	source /etc/environment
	local FECHA=$(date +"%d-%m-%y_%H-%M")
	local RUTA=
	local USER=	
	local NUM=$(($CANTB+1)) #Contador para la cantidad de backups realizados

	rutaRespaldo $PATHB

	tput cup 4 0
	echo "Ingrese usuario de MySQL: "
	tput cup 4 26
	read USER

	mysqldump --user="$USER" -p --all-databases > "$RUTA"/backupBD_"$FECHA".sql #Utilizo mysqldump para generar un backup de todas las bases de datos y lo envío a la ruta seleccionada
	
	if [ -s "$RUTA"/backupBD_"$FECHA".sql ] #Verifico que el backup creado no esté vacío
	then
		tput setaf 2
		tput cup 7 0
		sed -i 's/'$CANTB'/'$NUM'/' /etc/environment #Si se logra el resplado intercambio el valor anterior del contador
		source /etc/environment
		echo "Respaldo realizado con éxito"	
		tput cup 9 0 
		echo "Se han realizado $CANTB backup"
		tput sgr0
	else
		tput cup 9 0
		tput setaf 1
		echo "Error al realizar el respaldo"
		rm "$RUTA"/backupBD_"$FECHA".sql
		tput sgr0
	fi

	sleep 3
}

respaldoDirectorios()
{
	local FECHA=$(date +"%d-%m-%y_%H-%M")
	local RUTA=

	rutaRespaldo $PATHD
    
	if ! [ -d "$RUTA"/backupDIR_"$FECHA"/ ] #Verifico si existe el directorio del backup
	then
		mkdir /"$RUTA"/backupDIR_"$FECHA"/
		cp -r /home/USUARIOS /"$RUTA"/backupDIR_"$FECHA"
		tput setaf 2
		tput cup 4 0
		echo "Respaldo realizado con éxito"	
	else
		tput cup 4 0
		tput setaf 1
		echo "Error al realizar el respaldo"
		tput sgr0
	fi
    
    sleep 3
    
}
