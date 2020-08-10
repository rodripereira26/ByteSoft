#!/bin/bash
declare -a gruposQueDeberianEstar=(ADMINISTRADORES MEDICOS)


agregarUsuario(){
    # $1 : nombre del usuario
    # $2 : nombre del grupo
    local dirDeTrabajo="/home/USUARIOS/$2/$1"

    if [ $EUID -eq 0 ]; then # se ejecuto en root
        verificarExistenciaDeGrupos
        useradd -m -d "$dirDeTrabajo" -g "$2" -s /bin/bash $1
        #mkdir "$dirDeTrabajo"
        chown $1:$2 "$dirDeTrabajo"
        #chown $1:$2 -R "$dirDeTrabajo"
        chmod 755 -R "$dirDeTrabajo"
        echo 0 # se ejecuto
    else
        echo 1 # no es root
    fi
}
borrarUsuario(){
    # $1 : nombre del usuario
    if [ $EUID -eq 0 ]; then # se ejecuto en root
        verificarExistenciaDeGrupos
        directorio=$(grep -E "^$1:.*" /etc/passwd | cut -d: -f6)
        sudo rm -r $directorio
        userdel $1
        echo 0 # sin errores 
    else
        echo 1 # no es root
    fi
}
verificarExistenciaDeGrupos(){
    for grupo in "${gruposQueDeberianEstar[@]}"; do
        if [ -z $(cat /etc/group | cut -d: -f1 | grep $grupo) ]; then
            groupadd "$grupo"
        fi
    done
}