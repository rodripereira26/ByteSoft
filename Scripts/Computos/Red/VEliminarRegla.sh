#!/bin/bash
#region imports
. "/Scripts/InterfazGrafica/Control/inicio.sh"

. "/Scripts/Computos/Red/VPermitirIP.sh"
. "/Scripts/Computos/Red/VBloquearIP.sh"
#endregion
VEliminarRegla(){
    local continuar=true
    local tipoRegla=""
    local reglaEspecifica=""

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
                if [ $respuestaGestor ] && [ "$tipoRegla" != "$respuestaGestor" -a $modificado]; then 
                    tipoRegla=$respuestaGestor
                    maximaReglas=$(iptables -L $tipoRegla -n --line-numbers 2> /dev/null | tail -1 | cut -d" " -f1)
                    dibujarRectangulo 50 8 101 10 7 8

                    if [ $maximaReglas ]; then
                        mensajeError "TIPO VALIDO" 2 37 33 2 2 2
                        for ((i=3;i<$((maximaReglas + 3));i++)); do
                            tput cup $((5 + i)) 50
                            tput setab 3
                            (iptables -L $tipoRegla -n --line-numbers | head -$i | tail -1 ) 2> /dev/null
                        done
                    else
                        mensajeError "TIPO INVALIDO" 1 37 33 2 1 2
                    fi 
                fi
                ;;          
            "1")
                if $modificado; then 
                    reglaEspecifica=$respuestaGestor
                fi             
                ;;

            "2")
                if $respuestaGestor; then
                    if  [ $reglaEspecifica -a $tipoRegla ];then
                        iptables -D $tipoRegla $reglaEspecifica 2> /dev/null
                        if [ $? -eq 0 ]; then
                            mensajeError "Ejecutado correctamente" 2 37 33 2 2 2
                        else
                            mensajeError "Ip invalida" 1 37 33 2 1 2
                        fi
                    else
                        mensajeError "Ingrese tipo regla y nro" 1 37 33 2 1 2 
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
}
