#!/bin/bash

declare -a gruposQueDeberianEstar=(ADMINISTRADORES MEDICOS)

agregarUsuario() {
    #necesita root
    # $1 : nombre del usuario
    # $2 : nombre del grupo

    local dirDeTrabajo="/home/USUARIOS/$2/$1" 

    if [ $EUID -eq 0 ]; 
    then
        if [ -e "/home/USUARIOS" ];
        then 
            verificarExistenciaDeGrupos
            useradd -m -d "$dirDeTrabajo" -g "$2" -s /bin/bash $1
            chown $1:$2 "$dirDeTrabajo"
            chmod 755 -R "$dirDeTrabajo"
            echo 0 # Se ejecutó
        else
            echo 2 # no se configuro el entorno, no se pudo crear el usuario
        fi
    else
        echo 1 # No es root
    fi
}

borrarUsuario() {
    #necesita root
    # $1 : nombre del usuario

    if [ $EUID -eq 0 ]; 
    then # Se ejecutó en root
        verificarExistenciaDeGrupos
        directorio=$(grep -E "^$1:.*" /etc/passwd | cut -d: -f6)
        sudo rm -r $directorio
        userdel $1
        echo 0 # Sin errores 
    else
        echo 1 # No es root
    fi
}

verificarExistenciaDeGrupos() {

    for grupo in "${gruposQueDeberianEstar[@]}"; 
    do
        if [ -z $(cat /etc/group | cut -d: -f1 | grep $grupo) ]; 
        then
            groupadd "$grupo"
        fi
    done
}