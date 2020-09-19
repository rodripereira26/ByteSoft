#!/bin/bash

. "/Scripts/InterfazGrafica/Control/inicio.sh"

#region PARAMETROS que no entiendo
# secure_chroot_dir #inutil
# message_file ---> depende de dirmessage_enable=YES ?? 
# write_enable #inutil
# idle_session_timeout # inutil
# passwd_chroot_enable ????
# user_config_dir # no entiendo
# deny_file - preferible usar permisos del sistema
#endregion
#region ideas
    #agregar una opcion de limitar permisos segun grupos
#endregion

#region funciones
configurarBanner(){
    # $1 : banner_file path {default: (none)}
    cp "$1" "$bannerPath"
    agregarConfiguracion "true" "banner_file" "$1" "$auxialiarVsftpdConf" ""
}
configuracionIniciosDeSesion(){
    #region inicios de sesion
    # $1 : userlist_enable - Permitir filtro de usuarios por userlist_file  {default: NO}
    # $1 : userlist_deny - Si es YES, nunca acceden los del archivo userlist_file  {default: YES}
    # $2 : userlist_log - Se registran todas las denegaciones de inicio de sesion basada en
    #                     suserlist_file  {default: NO}
    #endregion
    
    agregarConfiguracion "true" "userlist_enable" "$1" "$auxialiarVsftpdConf" ""
    agregarConfiguracion "[[ $1 == YES ]]" "userlist_deny" "$2" "$auxialiarVsftpdConf" ""
    agregarConfiguracion "[[ $1 == YES ]]" "userlist_log" "$3" "$auxialiarVsftpdConf" ""
}
configuracionArchivosYDirectorios(){
    #region args archivos y directorios
    # $1 : file_open_mode - cambia permisos de archivos creados {default: 0666, preferible 0777 }
    # $2 : local_root - intenta ir al path al iniciar sesion  {default: (none)}
    # $3 : xferlog_enable - registro de cargas y descargas {default: NO}
    # $4 : force_dot_files - forzar carga de archivos con punto {default: NO}
    # $5 : log_ftp_protocol - registra peticiones FTP, util para depurar {default: NO}
    #endregion
    agregarConfiguracion "true" "file_open_mode" "$1" "$auxialiarVsftpdConf" ""
    agregarConfiguracion "true" "local_root" "$2" "$auxialiarVsftpdConf" ""
    agregarConfiguracion "true" "xferlog_enable" "$3" "$auxialiarVsftpdConf" ""
    agregarConfiguracion "true" "force_dot_files" "$4" "$auxialiarVsftpdConf" ""
    agregarConfiguracion "true" "log_ftp_protocol" "$5" "$auxialiarVsftpdConf" ""

}
configureDelay(){
    #region args
    # $1 : delay_successful_login {default:0}
    # $2 : delay_failed_login {default:1}
    #endregion
    agregarConfiguracion "true" "delay_successful_login" "$1" "$auxialiarVsftpdConf" ""
    agregarConfiguracion "true" "delay_failed_login" "$2" "$auxialiarVsftpdConf" ""
}
configurarFTPAnon(){
    #region args
    # $1 : anonymous_enable {default: NO}
    # $2 : anon_mkdir_write_enable {default: NO} ---> depente de writeEnable=YES
    # $3 : anon_root , ruta anonimo {default: none}
    # $4 : anon_max_rate {default: 0 } en bits
    #endregion

    local errorWrite="Para que anon_mkdir_write_enable=YES, haz que writeEnable=YES"
    local condicionAnonMKDIR="[[ $(grep -cE "^writeEnable=NO" "$auxialiarVsftpdConf") == 0 ]]"

    agregarConfiguracion "true" "anonymous_enable" "$1" "$auxialiarVsftpdConf" ""
    agregarConfiguracion "[[ $1 == YES ]] && $condicionAnonMKDIR" "anon_mkdir_write_enable" "$2" "$auxialiarVsftpdConf" "$errorWrite"
    agregarConfiguracion "[[ $1 == YES ]]" "anon_root" "$3" "$auxialiarVsftpdConf" ""
    agregarConfiguracion "[[ $1 == YES ]]" "anon_max_rate" "$4" "$auxialiarVsftpdConf" ""
}
configurarMaximos(){
    #region args
    # $1 : max_per_ip {default: 50}
    # $2 : max_login_fails {default: 3}
    # $3 : max_clients {default: 2000}
    #endregion
    agregarConfiguracion "true" "max_per_ip" "$1" "$auxialiarVsftpdConf" ""
    agregarConfiguracion "true" "max_login_fails" "$2" "$auxialiarVsftpdConf" ""
    agregarConfiguracion "true" "max_clients" "$3" "$auxialiarVsftpdConf" ""
    # TODO - local_max_rate
}
configurarPuertosPASV(){
    #region args
    # $1 : pasv_enable {YES, NO} 
    # $2 : pasv_max_port {default: 0 (cualquier puerto no recomendable) }
    # $3 : pasv_min_port {default: 0 (cualquier puerto no recomendable) }
    #agregar rango al firewall para que acepte las conexiones en los 
    #puertos, no es lo mismo que el puerto 20 y 21 
    #endregion
    agregarConfiguracion "true" "pasv_enable" "$1" "$auxialiarVsftpdConf" ""
    agregarConfiguracion "[[ $1 == YES ]]" "pasv_max_port" "$2" "$auxialiarVsftpdConf" "habilite psv"
    agregarConfiguracion "[[ $1 == YES ]]" "pasv_min_port" "$3" "$auxialiarVsftpdConf" "habilite psv"
    # TODO - agregar al firewall que acepte el rango definido

}
configuracionComandosDenegadosYPermitidos(){
    #region - args permitir/denegar comandos
    # $1 : cmds_denied[] - comandos denegados (tiene prioridad) {formato: 1,2,3}
    # $2 : cmds_allowed[] - comandos permitidos {formato: 1,2,3}
    #endregion
    #region variables
    local cmds_denied=$1
    local cmds_allowed=$2
    local permitidosYDenegados="$cmds_denied,$cmds_allowed"
    local listaComandosPermitidosYDenegados="$(echo -e ${permitidosYDenegados//,/\\n} | sort)"
    local anterior=""
    #endregion

    #borra los que estan repetidos en permitido
    for comando in "${listaComandosPermitidosYDenegados[@]}"; do
        if [ "$anterior" = "$comando" ]; then
            cmds_allowed=$(echo $cmds_allowed | sed "s/$comando//g; s/,,//g; s/^,//g")
            #quita repetido; quita comas duplicadas; quitar comas en el inicio
        fi
        anterior="$comando"
    done
    
    agregarConfiguracion "true" "cmds_denied" "$cmds_denied" "$auxialiarVsftpdConf" ""
    agregarConfiguracion "true" "cmds_allowed" "$cmds_allowed" "$auxialiarVsftpdConf" ""
}
iniciarConfiguracionFTP(){
    # 
    # $1 : empieza configuracion {} 
}
borrarConfiguracionFTP
#endregion
#region tomar y agregar configuracion especifica
agregarConfiguracion(){
    #region args
    # $1 : condicion
    # $2 : nombre de la configuracion
    # $3 : value
    # $4 : archivo
    # $5 : mensaje error
    #endregion

    if $1;then
        if [ $(grep -cE  "^$2=" $4) -eq 1 ];then
            sed "s/^$2=.*/$2=$3/g" "$4"
        else
            sed -i "/^$2=/d" "$4" #elimina todas las lineas, si no hay, no hace nada y si es mas de una, las borra 
            echo "$2=$3" >> "$4"
        fi
    else
        mensajeError "$5" 1 37 33 2 1 2
    fi
}

getConfiguracion(){
    # $1 : nombre de la configuracion
    grep -oP "(?<=$1=).+" /etc/vsftpd/vsftpd.conf
}
#endregion
#region comandos de inicio 
definirVariables(){
    #region var
    auxialiarVsftpdConf="/Scripts/Computos/FTP/vsftpd.conf"
    copiaSeguridadVsftpConf="/Scripts/Computos/FTP/vsftpd2.conf"
    original="/etc/vsftpd/vsftpd.conf"
    userList="/etc/vsftpd/user_list"
    bannerPath="/Scripts/Computos/FTP/bannerFTP.txt"
    #endregion
    cp $original $copiaSeguridadVsftpConf
    rm $auxialiarVsftpdConf
    touch $auxialiarVsftpdConf
} 
crearArchivoLocal(){
    rm "$auxialiarVsftpdConf"
    touch "$auxialiarVsftpdConf"
}
confInicial(){
    definirVariables
    crearArchivoLocal
}
#endregion
confInicial