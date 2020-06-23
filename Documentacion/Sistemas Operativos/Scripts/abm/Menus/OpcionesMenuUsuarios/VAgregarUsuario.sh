#!/bin/bash

VMenuAgregarUsuario(){
    iniciarPantallaNueva
    dibujarTxt "INGRESAR USUARIO" 80 2
    dibujarTxt "| DEBE EN LA CONTRASEÑA:" 78 6
    dibujarTxt "| NO INGRESAR PALABRAS" 78 7
    dibujarTxt "| INGRESAR MÁS DE 7 CARACTERES" 78 8
    dibujarTxt "| DEBEN HABER MINIMO 4 CARACTERES DIFERENTES" 78 9

    dibujarTxt "NOMBRE DE USUARIO" 20 5
    dibujarEntradaTxt 20 6 20 false

    dibujarTxt "CONTRASEÑA" 20 8
    dibujarEntradaTxt 20 9 20 true

    dibujarBoton "SIGUIENTE" 20 13 40 3
    dibujarBoton "VOLVER" 60 13 40 3

    local continuar=true
    local user=""
    local pw=""

    while $continuar; do
        siguientePos
        case $posDeEsteElemento in
            "0")
                user=$respuestaGestor
                ;;
            "1")
                pw=$respuestaGestor
                ;;
            "2")
                if $respuestaGestor; then
                    declare -a listaPalabras
                    declare -i posEnLista=0
                    
                    agregarALaLista=true

                    for ((n=0;n<${#pw};n++)) do
                        lpw=${pw:$n:1}
                        agregarALaLista=true
                        for i in ${listaPalabras[@]}; do
                            if [ $lpw = $i ]; then
                                agregarALaLista=false
                            fi
                        done
                        if $agregarALaLista; then
                            listaPalabras[$posEnLista]="$lpw"
                            ((posEnLista++))
                        fi
                    done
                    listaPalabras=()
                    agregarALaLista=false

                    if [ -n "$user" -a -n "$pw" -a ${#pw} -gt 7 -a $posEnLista -gt 4 ]; then
                        ejecutarElegirGrupo
                        if [ $grupoPerteneciente ]; then
                            if [ $(grep -E "^$user:" /etc/passwd) ]; then
                                VAvisoRegistrado "YA HAY UN USUARIO CON EL MISMO NOMBRE" 9
                            else
                                resp=$(agregarUsuario $user $grupoPerteneciente)
                                if [ $resp -eq 0 ]; then
                                    echo -e "$pw\n$pw" | passwd $user
                                    pw=""
                                    VAvisoRegistrado "EL USUARIO SE HA INGRESADO CORRECTAMENTE" 10
                                elif [ $resp -eq 1 ]; then
                                    VAvisoRegistrado "HA OCURRIDO UN PROBLEMA CON LOS PERMISOS" 9
                                fi
                                continuar=false
                            fi

                        fi
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
ejecutarVAgregarUsuario(){
    VMenuAgregarUsuario
    cerrarPantalla
}