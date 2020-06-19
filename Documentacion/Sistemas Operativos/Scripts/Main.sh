	#!/bin/bash
	export LANG=C.UTF-8
	
	while :
	do	
		clear
		tput cup 14,24
		echo " ___________________________________ "
		echo "│     Configuración del entorno 	  │"
		echo "│                                   │#"
		echo "│ 1 - Crear grupo                   │#"
		echo "│ 2 - Crear usuario                 │#"
		echo "│ 3 - Salir                         │#"
		echo "│                                   │"
		echo "│ Opción:                           │"
		echo "│___________________________________│"
	

	case "$opc" in 
	## CASE sirve para comprobar el valor de una variable y ejecutar una porcion de codigo dependiendo de que valor sea
	#En este caso se comprueba el valor de opc , si es 1 2 o 3 se ejecuta el codigo correspondiente, si es otra opcion se ejecuta el codigo dentro de la opcion *
	1) 	clear
		read -p "Ingrese el nombre del grupo a crear: " grupo
		sudo groupadd $grupo
		echo "El grupo $grupo ha sido creado ..."
		sleep 2;	
		
		;;

	2)	funcion_usuarios  ##Se llama a la funcion creada al principio
		;;

	3) echo "Finalizando ..."
		sleep 3;	
		clear
		exit ;;

	*) echo "$opc no es una opciè´¸n vè°©lida"
		sleep 2;
		;;


	esac ## Cierra el CASE
	done ## Cierra el DO