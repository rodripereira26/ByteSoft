#!/bin/bash
#region imports
. "/Scripts/InterfazGrafica/Control/inicio.sh"

. "/Scripts/Computos/Iptables/VPermitirIP.sh"
. "/Scripts/Computos/Iptables/VBloquearIP.sh"
#endregion
VEliminarRegla(){
    local continuar=true
    tipoRegla=""
    reglaEspecifica=""
    maximaReglas=""
    
    iniciarPantallaNueva
    dibujarTxt "ELIMINAR REGLA" 43 3 0

    dibujarTxt "4 -> ARRIBA" 11 3 0
    dibujarTxt "5 -> ENTER " 11 4 0
    dibujarTxt "6 -> ABAJO" 11 5 0
    
    dibujarTxt "INGRESA TIPO DE REGLA:" 11 11 0
    dibujarEntradaTxt 11 12 20 false

    dibujarTxt "INGRESA NRO DE REGLA:" 11 14 0
    dibujarEntradaTxt 11 15 20 false

    dibujarBoton "ELIMINAR" 11 20 40 3
    dibujarBoton "VOLVER" 50 20 40 3
    
    while $continuar; do
        siguientePos

        case $posDeEsteElemento in
            "0")
                if [ $respuestaGestor ] && [ "$tipoRegla" != "$respuestaGestor" -a $modificado ]; then 
                    tipoRegla=$respuestaGestor
                    mostrarTabla "$tipoRegla" "$reglaEspecifica" "$maximaReglas" 
                fi
                ;;          
            "1")
                if $modificado; then 
                    reglaEspecifica=$respuestaGestor
                fi             
                ;;

            "2")
                if $respuestaGestor; then
                    if  [ $reglaEspecifica -a $tipoRegla ]; then
                        iptables -D $tipoRegla $reglaEspecifica  > /dev/null 2>&1
                        if [ $? -eq 0 ]; then
                            mensajeError "EJECUTADO CORRECTAMENTE" 2 37 33 2 0 2
                            mostrarTabla "$tipoRegla" "$reglaEspecifica" "$maximaReglas" 
                        else
                            mensajeError "IP INVALIDA" 1 37 33 2 0 2
                        fi
                    else
                        mensajeError "INGRESE TIPO REGLA Y NRO" 1 37 33 2 0 2 
                    fi

                fi
                
                ;;
            "3")
                if $respuestaGestor; then
                    continuar=false
                fi
                ;;
            *)
                ;;
        esac
    done
}
ejecutarEliminarRegla(){
    VEliminarRegla
    cerrarPantalla
}
mostrarTabla(){
    if [ "$maximaReglas" ]; then
        dibujarRectangulo 50 5 $(($(tput cols)-50)) $maximaReglas 7 8
    fi
    maximaReglas=$(iptables -L $tipoRegla -n --line-numbers  2> /dev/null | tail -1 | cut -d" " -f1)

    if [ $maximaReglas ]; then
        mensajeError "TIPO VALIDO" 2 37 33 2 0 2
        for ((i=0;i<maximaReglas;i++)); do
            tput cup $((i+5)) 50
            tput setab 3
            (iptables -L $tipoRegla -n --line-numbers | head -$((i+3)) | tail -1 )  2> /dev/null
        done
    else
        mensajeError "TIPO INVALIDO" 1 37 33 2 0 2
    fi 
}
probarFuncionEjecucionLocal ejecutarEliminarRegla "VEliminarRegla.sh"
