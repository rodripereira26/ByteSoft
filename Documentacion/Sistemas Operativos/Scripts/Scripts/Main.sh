	#!/bin/bash
	export LANG=C.UTF-8

	source ./Scripts/Logica.sh

	op=1
	while [ "$op" != "0" ]
	do	
		clear
		tput sgr0
		echo " _____________________________________ "
		echo "│      Configuración del entorno      │"
		echo "│                                     │"
		echo "│ 1 - Crear directorios y variables   │"
		echo "│ 2 - Respaldar directorios           │"
		echo "│ 3 - Respaldar base de datos         │"
		echo "│ 0 - Salir                           │"
		echo "│                                     │"
		echo "│ Opción:                             │"
		echo "│_____________________________________│"
		tput cup 8 10
		read op
		
		case "$op" in 
		
			1) 	
				tput cup 11 1
				crearDirectorios
				variablesEntorno
				
			;;

			2)	
				respaldoDirectorios
			;;

			3)	
				respaldoBD
			;;


			0) 
				tput cup 12 0
				echo "Saliendo..."
				tput sgr0
				sleep 2
				clear
				exit 

			;;

			*) 
				tput cup 12 0	
				tput setaf 1
				echo "Ingresó una opción incorrecta"
				tput sgr0
				sleep 2
				op=1 
			;;

	esac
	done