#!/bin/bash

VMenuAgregarUsuario() {

    iniciarPantallaNueva
    dibujarTxt "Ingresar usuario" 50 2
    dibujarTxt "| en la contraseña:" 48 6
    dibujarTxt "| no ingresar palabras" 48 7
    dibujarTxt "| ingresar más de 7 caracteres" 48 8
    dibujarTxt "| deben haber mínimo 4 caracteres diferentes" 48 9

    dibujarTxt "Nombre de usuario" 20 5
    dibujarEntradaTxt 20 6 20 false

    dibujarTxt "Contraseña" 20 8
    dibujarEntradaTxt 20 9 20 true

    dibujarBoton "Siguiente" 20 13 40 3
    dibujarBoton "Volver" 60 13 40 3

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
                        ejecutarElegirGrupo

                        if [ $grupoPerteneciente ]; 
                        then
                            if [ $(grep -E "^$user:" /etc/passwd) ]; 
                            then
                                VAvisoRegistrado "Ya hay un usuario con el mismo nombre" 9
                            else
                                resp=$(agregarUsuario $user $grupoPerteneciente)

                                if [ $resp -eq 0 ]; 
                                then
                                    echo -e "$pw\n$pw" | passwd $user
                                    pw=""
                                    VAvisoRegistrado "El usuario ha sido ingresado correctamente" 10

                                elif [ $resp -eq 1 ]; 
                                    then
                                    VAvisoRegistrado "Ha ocurrido un problema con los permisos" 9
                                fi
                                continuar=false
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
            *)
                ;;
        esac
    done
}
ejecutarVAgregarUsuario() {

    VMenuAgregarUsuario
    cerrarPantalla

}
