#!/bin/bash

. "/Scripts/InterfazGrafica/Grafica/disenoVentana.sh" 

VMenuModificarUsuario() {

    iniciarPantallaNueva

    dibujarTxt "MODIFICAR CONTRASEÑA" 41 6 0

    dibujarTxt "NOMBRE DE USUARIO" 25 11 0
    dibujarEntradaTxt 25 12 20 false

    dibujarTxt "CONTRASEÑA" 25 14 0
    dibujarEntradaTxt 25 15 20 true
    
    dibujarTxt "NUEVA CONTRASEÑA" 60 11 0
    dibujarEntradaTxt 60 12 20 true

    dibujarTxt "REPITE NUEVA CONTRASEÑA" 60 14 0
    dibujarEntradaTxt 60 15 20 true

    dibujarBoton "SIGUIENTE" 14 20 40 3
    dibujarBoton "VOLVER" 53 20 40 3

    local continuar=true

    user=""
    pw=""
    pwN=""
    reppwN=""
    intentoRegistrar=false

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
                pwN=$respuestaGestor
                ;;

            "3")
                reppwN=$respuestaGestor
                ;;
            "4")
                if $respuestaGestor; 
                then
                    continuar=false
                    intentoRegistrar=true
                fi
                ;;

            "5")
                if $respuestaGestor; 
                then
                    continuar=false
                fi
                ;;
        esac
    done
}

ejecutarModificarUsuario() {

    local ciclo=true

    while $ciclo; 
    do
        VMenuModificarUsuario

        if $intentoRegistrar; 
        then
            declare -a listaPalabras
            declare -i posEnLista=0

            agregarALaLista=true

            for ((n=0;n<${#pwN};n++)); 
            do
                lpwN=${pwN:$n:1}
                agregarALaLista=true

                for i in ${listaPalabras[@]}; 
                do
                    if [ $lpwN = $i ]; 
                    then
                        agregarALaLista=false
                    fi
                done

                if $agregarALaLista; 
                then
                    listaPalabras[$posEnLista]="$lpwN"
                    ((posEnLista++))
                fi
                
            done

            lpwN=""
            listaPalabras=()
            agregarALaLista=false
            
            if [ $EUID -ne 0 ]; then # no es root
                if [ -n "$user" -a -n "$pwN" -a ${#pwN} -gt 7 -a $posEnLista -gt 4 ]; 
                then
                    if [ $(grep -E "^$user:.*::/home/USUARIOS/.*/$user" /etc/passwd) ]; 
                    then
                        if [ "$pwN" = "$reppwN" ];
                        then
                            respCambioContrasena=$(echo "$pw" | su $user -c "echo -e '$pw\n$pwN\n$pwN\n' | passwd 2> /dev/null")
                            if [ $? -eq 0 ]; then # verifica anterior comando
                                VAvisoRegistrado "Modificado con éxito" 10 
                            else
                                VAvisoRegistrado "Contraseña incorrecta" 9
                            fi
                            pw=""
                            pwN=""
                            reppwN=""
                        else
                            VAvisoRegistrado "Contraseñas no coinciden" 9 
                        fi
                    else
                        VAvisoRegistrado "$user no pertenece a usuarios" 9 
                    fi
                else
                    VAvisoRegistrado "Formulario no lleno o los requisitos de contraseña no coinciden" 9
                fi
            else
                VAvisoRegistrado "No se puede modificar la contraseña con root" 9
            fi
        else
            ciclo=false
        fi
        
        cerrarPantalla
    done
}