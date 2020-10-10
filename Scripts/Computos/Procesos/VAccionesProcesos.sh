#!/bin/bash

. "/Scripts/InterfazGrafica/Control/inicio.sh" 

. "/Scripts/Computos/Procesos/logicaProcesos.sh"

menuProcesos(){
    local continuar=true
    
    #region [rgba(27, 173, 192, 0.10)] tui 
    iniciarPantallaNueva
    dibujarTxt "PROCESOS" 46 3 0

    dibujarTxt "4 -> ARRIBA" 11 6 0
    dibujarTxt "5 -> ENTER " 11 7 0
    dibujarTxt "6 -> ABAJO" 11 8 0
    
    dibujarBoton "VER PROCESOS ACTIVOS (Q PARA SALIR)" 11 9 80 3
    if [ $EUID -eq 0 ];
	then
        dibujarBoton "INSTALAR HTOP(VER PROCESOS MEJORADO)" 11 12 80 3 #solo root
        dibujarBoton "MATAR PROCESO USANDO EL PID" 11 15 80 3
        dibujarBoton "MATAR PROCESO USANDO EL NOMBRE" 11 18 80 3
        dibujarBoton "VOLVER" 11 21 80 3
    else
        dibujarBoton "MATAR PROCESO USANDO EL PID" 11 12 80 3
        dibujarBoton "MATAR PROCESO USANDO EL NOMBRE" 11 15 80 3
        dibujarBoton "VOLVER" 11 18 80 3
    fi
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

ejecutarProcesos(){

    local continuarCiclo=true

    while $continuarCiclo; 
    do
        menuProcesos

        case $texto in 

        	"VER PROCESOS ACTIVOS (Q PARA SALIR)")
				tput sgr0
                tput cup 0 0
                htop
                if [ $? -ne 0 ];
				then
                    top
                fi
				;;
		    "INSTALAR HTOP(VER PROCESOS MEJORADO)")
                clear 
                tput cup 0 0 
            	yum install -y htop
                sleep 2
				;;
			"MATAR PROCESO USANDO EL PID")
            	matarProcesoPID
				;;

			"MATAR PROCESO USANDO EL NOMBRE")
				matarProcesoNombre
				;;

            "VOLVER")
                continuarCiclo=false
                ;;
        esac
        cerrarPantalla
        
    done
}

