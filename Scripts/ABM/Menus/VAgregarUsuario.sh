#!/bin/bash

. "/Scripts/InterfazGrafica/Grafica/disenoVentana.sh" 

VMenuAgregarUsuario() {

    iniciarPantallaNueva
    dibujarTxt "INGRESAR USUARIO" 41 6 0
    dibujarTxt "| EN LA CONTRASEÑA:" 48 12 0
    dibujarTxt "| NO INGRESAR PALABRAS" 48 13 0
    dibujarTxt "| INGRESAR MÁS DE 7 CARACTERES" 48 14 0
    dibujarTxt "| DEBEN HABER MÍNIMO 4 CARACTERES DIFERENTES" 48 15 0

    dibujarTxt "NOMBRE DE USUARIO" 11 11 0
    dibujarEntradaTxt 11 12 20 false

    dibujarTxt "CONTRASEÑA" 11 14 0
    dibujarEntradaTxt 11 15 20 true

    dibujarBoton "SIGUIENTE" 11 20 40 3
    dibujarBoton "VOLVER" 50 20 40 3

    local continuar=true
    local user=""
    local pw=""

    while $continuar; 
    do
        siguientePos

        case $posDeEsteElemento in

            "0")
                user=$respuestaGestor
                ;;

            "1")
                pw=$respuestaGestor
                ;;

            "2")
                if $respuestaGestor; 
                then
                    declare -a listaPalabras
                    declare -i posEnLista=0
                    
                    agregarALaLista=true

                    for ((n=0;n<${#pw};n++)) 
                    do
                        lpw=${pw:$n:1}
                        agregarALaLista=true

                        for i in ${listaPalabras[@]}; 
                        do
                            if [ $lpw = $i ]; 
                            then
                                agregarALaLista=false
                            fi
                        done

                        if $agregarALaLista; 
                        then
                            listaPalabras[$posEnLista]="$lpw"
                            ((posEnLista++))
                        fi
                    done

                    listaPalabras=()
                    agregarALaLista=false

                    if [ -n "$user" -a -n "$pw" -a ${#pw} -gt 7 -a $posEnLista -gt 4 ]; 
                    then
                        continuar=false #solucion error continuar
                        ejecutarElegirGrupo

                        if [ $grupoPerteneciente ]; 
                        then
                            if [ $(grep -E "^$user:" /etc/passwd) ]; 
                            then
                                VAvisoRegistrado "Ya hay un usuario con el mismo nombre" 9 ##############
                            else
                                resp=$(agregarUsuario $user $grupoPerteneciente)

                                if [ $resp -eq 0 ]; 
                                then
                                    echo -e "$pw\n$pw" | passwd $user
                                    pw=""
                                    VAvisoRegistrado "El usuario ha sido ingresado correctamente" 10 ##############

                                elif [ $resp -eq 1 ]; 
                                    then
                                    VAvisoRegistrado "Ha ocurrido un problema con los permisos" 9 ##############
                                fi
                                #continuar=false ######posible error
                            fi

                        fi
                    fi
                fi
                ;;

            "3")
                if $respuestaGestor; 
                then
                    continuar=false
                fi
                ;;
        esac
    done
}

ejecutarVAgregarUsuario() {

    VMenuAgregarUsuario
    cerrarPantalla
}