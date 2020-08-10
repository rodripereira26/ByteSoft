#!/bin/bash
. "Menus/Servicios/Configuracion/VConfigMySQL.sh"
. "Menus/Servicios/Configuracion/VConfigSSH.sh"
  
VMenuServicioConf(){
    iniciarPantallaNueva
    dibujarTxt "Configuración servicios" 48 2
    dibujarBoton "SSH" 20 4 80 3
    dibujarBoton "MySQL" 20 7 80 3
    dibujarBoton "Volver" 20 10 80 3

    local continuar=true
    while $continuar; 
    do
        siguientePos
        if $respuestaGestor; 
        then
            continuar=false
        fi 
    done
}
ejecutarMenuServicioConf() {

    local continuarCiclo=true

    while $continuarCiclo; 
    do
        VMenuServicioConf
        case $posDeEsteElemento in 
            "0")
                ejecutarVConfigurarSSH
                ;;

            "1")
                echo "configuar mysql en construccion" | less
                ;;

            "2")

                continuarCiclo=false
                ;;
            *)
                ;;
        esac
        
        cerrarPantalla
    done

}