#!/bin/bash
VMenuModificarUsuario(){
    iniciarPantallaNueva
    dibujarTxt "MODIFICAR CONTRASEÑA" 80 2
    dibujarTxt "| DEBE EN LA CONTRASEÑA:" 78 6
    dibujarTxt "| NO INGRESAR PALABRAS" 78 7
    dibujarTxt "| INGRESAR MÁS DE 7 CARACTERES" 78 8
    dibujarTxt "| DEBEN HABER MINIMO 4 CARACTERES DIFERENTES" 78 9

    dibujarTxt "NOMBRE DE USUARIO" 20 5
    dibujarEntradaTxt 20 6 20 false

    dibujarTxt "CONTRASEÑA" 50 5
    dibujarEntradaTxt 50 6 20 true
    
    dibujarTxt "NUEVA CONTRASEÑA" 20 8
    dibujarEntradaTxt 20 9 20 true

    dibujarTxt "REPITE NUEVA CONTRASEÑA" 50 8
    dibujarEntradaTxt 50 9 20 true

    dibujarBoton "SIGUIENTE" 20 13 40 3
    dibujarBoton "VOLVER" 60 13 40 3

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
                if [ $(grep -E "^$user:.*::$pathUSUARIOS/USUARIOS/.*/$user" /etc/passwd) ]; then
                    if [ "$pwN" = "$reppwN" ];then
                        respCambioContrasena=$(echo -e "$pwN\n$pwN" | passwd $user)
                        pw=""
                        pwN=""
                        reppwN=""
                        VAvisoRegistrado "MODIFICADO CON EXITO" 10
                    else
                        VAvisoRegistrado "CONTRASEÑAS NO COINCIDEN" 9
                    fi
                else
                    VAvisoRegistrado "$user NO PERTENECE A USUARIOS" 9
                fi
            else
                VAvisoRegistrado "FORMULADO NO LLENO O LOS REQUISITOS DE CONTRASEÑA NO COINCIDEN" 9
            fi
        else
            ciclo=false
        fi
        cerrarPantalla
    done
}