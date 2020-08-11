#!/bin/bash
VMenuModificarUsuario(){
    iniciarPantallaNueva
    dibujarTxt "Modificar contraseña" 80 2 ############
    dibujarTxt "| Debe en la contraseña:" 78 6 ############
    dibujarTxt "| - No ingresar palabras" 78 7 ############
    dibujarTxt "| - Ingresar más de 7 caracteres" 78 8 ############
    dibujarTxt "| - Mínimo 4 caracteres diferentes" 78 9 ############

    dibujarTxt "Nombre de usuario" 20 5 ##############
    dibujarEntradaTxt 20 6 20 false

    dibujarTxt "Contraseña" 50 5 ##############
    dibujarEntradaTxt 50 6 20 true
    
    dibujarTxt "Nueva contraseña" 20 8 ##############
    dibujarEntradaTxt 20 9 20 true

    dibujarTxt "Repite nueva contraseña" 50 8 ##############
    dibujarEntradaTxt 50 9 20 true

    dibujarBoton "Siguiente" 20 13 40 3 ##############
    dibujarBoton "Volver" 60 13 40 3 ##############

    local continuar=true
    user=""
    pw=""
    pwN=""
    reppwN=""
    intentoRegistrar=false

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
                pwN=$respuestaGestor
                ;;

            "3")
                reppwN=$respuestaGestor
                ;;
            "4")
                if $respuestaGestor; then
                    continuar=false
                    intentoRegistrar=true
                fi
                ;;
            "5")
                if $respuestaGestor; then
                    continuar=false
                fi
                ;;
            *)
                ;;
        esac
    done
}
ejecutarModificarUsuario(){
    local ciclo=true
    while $ciclo; do
        VMenuModificarUsuario
        if $intentoRegistrar; then
            declare -a listaPalabras
            declare -i posEnLista=0

            agregarALaLista=true
            for ((n=0;n<${#pwN};n++)) do
                lpwN=${pwN:$n:1}
                agregarALaLista=true
                for i in ${listaPalabras[@]}; do
                    if [ $lpwN = $i ]; then
                        agregarALaLista=false
                    fi
                done
                if $agregarALaLista; then
                    listaPalabras[$posEnLista]="$lpwN"
                    ((posEnLista++))
                fi
                
            done
            lpwN=""
            listaPalabras=()
            agregarALaLista=false

            if [ -n "$user" -a -n "$pwN" -a ${#pwN} -gt 7 -a $posEnLista -gt 4 ]; then
                if [ $(grep -E "^$user:.*::/home/USUARIOS/.*/$user" /etc/passwd) ]; then
                    if [ "$pwN" = "$reppwN" ];then
                        respCambioContrasena=$(echo -e "$pwN\n$pwN" | passwd $user)
                        pw=""
                        pwN=""
                        reppwN=""
                        VAvisoRegistrado "Modificado con éxito" 10 ##############
                    else
                        VAvisoRegistrado "Contraseñas no coinciden" 9 ##############
                    fi
                else
                    VAvisoRegistrado "$user no pertenece a usuarios" 9 ##############
                fi
            else
                VAvisoRegistrado "Formulario no lleno o los requisitos de contraseña no coinciden" 9 ##############
            fi
        else
            ciclo=false
        fi
        cerrarPantalla
    done
}