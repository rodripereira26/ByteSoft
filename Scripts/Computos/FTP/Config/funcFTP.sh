#!/bin/bash

#region funciones
configuracionArchivosYDirectorios(){
    #region [rgba(47, 0, 255, 0.10)] args archivos y directorios
    # $1 : local_umask - permisos de archivos creados {default: 0666, preferible 0777 }
    # $2 : file_open_mode - permisos de archivos abiertos {default: 0666, preferible 0777 }
    # $3 : local_root - intenta ir al path al iniciar sesion $USER {default: (none)}
    # $4 : xferlog_enable - registro de cargas y descargas {default: NO}
    # $5 : force_dot_files - forzar carga de archivos con punto {default: NO}
    # $6 : log_ftp_protocol - registra peticiones FTP, util para depurar {default: NO}
    # $7 : write_enable - permitir escritura {default: NO}
    #endregion
    if [ "$1" ];
	then
        agregarConfiguracion "local_umask" "$1" "$archivoAConfigurar"
    else
        agregarConfiguracion "local_umask" '(none)' "$archivoAConfigurar"
    fi

    if [ "$2" ];
	then
        agregarConfiguracion "file_open_mode" "$2" "$archivoAConfigurar"
    else
        agregarConfiguracion "file_open_mode" '(none)' "$archivoAConfigurar"
    fi

    if [ "$3" ];
	then
        agregarConfiguracion "home" "$3" "/etc/default/useradd"
    else
        agregarConfiguracion "home" "/home" "/etc/default/useradd"
    fi

    agregarConfiguracion "local_root" "$3" "$archivoAConfigurar"
    agregarConfiguracion "xferlog_enable" "$4" "$archivoAConfigurar"   
    agregarConfiguracion "force_dot_files" "$5" "$archivoAConfigurar"   
    agregarConfiguracion "log_ftp_protocol" "$6" "$archivoAConfigurar"   
    agregarConfiguracion "write_enable" "$7" "$archivoAConfigurar"   
}
configuracionIniciosDeSesion(){
    #region inicios de sesion
    # $1 : userlist_enable - Permitir filtro de usuarios por userlist_file  {default: NO}
    # $2 : userlist_deny - Si es YES, nunca acceden los del archivo userlist_file  {default: YES}
    # $3 : userlist_log - Se registran todas las denegaciones de inicio de sesion basada en
    #                     userlist_file  {default: NO}
    #endregion
    
    agregarConfiguracion "userlist_enable" "$1" "$archivoAConfigurar"   
    if [ "$1" = "YES" ];
	then
        agregarConfiguracion "userlist_deny" "$2" "$archivoAConfigurar"   
        agregarConfiguracion "userlist_log" "$3" "$archivoAConfigurar"   
    else
        agregarConfiguracion "userlist_deny" '(none)' "$archivoAConfigurar"   
        agregarConfiguracion "userlist_log" '(none)' "$archivoAConfigurar"  
    fi
}
configurarFTPAnon(){
    #region [rgba(47, 0, 255, 0.10)] args
    # $1 : anonymous_enable {default: NO}
    # $2 : anon_mkdir_write_enable {default: NO} ---> depente de writeEnable=YES
    # $3 : anon_root , ruta anonimo {default: (none}
    # $4 : anon_max_rate {default: 0} limite de bits
    # $5 : anon_umask {default: 077} permisos al crear archivos 
    # $6 : anon_upload_enable {default: NO} permite subir archivos
    #endregion

    local errorWrite="Para que anon_mkdir_write_enable=YES, haz que writeEnable=YES"
    local condicionAnonMKDIR=$([ $(grep -cE "^writeEnable=NO" "$archivoAConfigurar") -eq 0 ] && echo true || echo false)

    agregarConfiguracion "anonymous_enable" "$1" "$archivoAConfigurar"   
    if [ "$1" = "YES" ];
	then
        if $condicionAnonMKDIR;
		then
            agregarConfiguracion "anon_mkdir_write_enable" "$2" "$archivoAConfigurar"
        fi
        agregarConfiguracion "anon_root" "$3" "$archivoAConfigurar"   
        agregarConfiguracion "anon_max_rate" "$4" "$archivoAConfigurar" 
        agregarConfiguracion "anon_umask" "$5" "$archivoAConfigurar"  
        agregarConfiguracion "anon_upload_enable" "$6" "$archivoAConfigurar"  

    else
        agregarConfiguracion "anon_mkdir_write_enable" '(none)' "$archivoAConfigurar" 
        agregarConfiguracion "anon_root" '(none)' "$archivoAConfigurar"   
        agregarConfiguracion "anon_max_rate" '(none)' "$archivoAConfigurar"  
        agregarConfiguracion "anon_umask" '(none)' "$archivoAConfigurar"  
        agregarConfiguracion "anon_upload_enable" '(none)' "$archivoAConfigurar"  
    fi
}
configuracionComandosDenegadosYPermitidos(){
    #region - args y variables permitir/denegar comandos
    # $1 : cmds_allowed[] - comandos permitidos {formato: 1,2,3}
    # $2 : cmds_denied[] - comandos denegados (tiene prioridad) {formato: 1,2,3}

    local cmds_allowed=$1
    local cmds_denied=$2
    #endregion
    if [ "$cmds_allowed" ];
	then
        agregarConfiguracion "cmds_allowed" "$cmds_allowed" "$archivoAConfigurar" 
    else
        agregarConfiguracion "cmds_allowed" '(none)' "$archivoAConfigurar" 
    fi
    if [ "$cmds_denied" ];
	then
        agregarConfiguracion "cmds_denied" "$cmds_denied" "$archivoAConfigurar"
    else
        agregarConfiguracion "cmds_denied" '(none)' "$archivoAConfigurar" 
    fi
}
configurarBanner(){
    # $1 : banner_file path {default: (none)}
    if [ "$1" ];
	then
        chmod 744 "$1"
        agregarConfiguracion "banner_file" "$1" "$archivoAConfigurar"   
    else
        agregarConfiguracion "banner_file" '(none)' "$archivoAConfigurar"   
    fi
}
configurarPuertosPASV(){
    #region [rgba(47, 0, 255, 0.10)] args y variables
    # $1 : pasv_enable {default: YES} 
    # $2 : pasv_min_port {default: 0 (cualquier puerto no recomendable) }
    # $3 : pasv_max_port {default: 0 (cualquier puerto no recomendable) }
    
    local pasvHabilitado=$(configuracionEsTrue pasv_enable '!=' NO)
    local pasv_min_port=$(getConfiguracion pasv_min_port '0')
    local pasv_max_port=$(getConfiguracion pasv_max_port '0')
    local inputBorrar=$(iptables -L INPUT -n --line-number | grep -E "multiport dports $pasv_min_port:$pasv_max_port$" | cut -d" " -f1)
    local outputBorrar=$(iptables -L OUTPUT -n --line-number | grep -E "multiport sports $pasv_min_port:$pasv_max_port$" | cut -d" " -f1)
    #endregion
    
    if [ $pasvHabilitado ];
    then
        [ "$inputBorrar" ] && iptables -D INPUT $inputBorrar
        [ "$outputBorrar" ] && iptables -D OUTPUT $outputBorrar
    fi

    agregarConfiguracion "pasv_enable" "$1" "$archivoAConfigurar"

    if [ "$1" = "YES" ];
	then
        agregarConfiguracion "pasv_min_port" "$2" "$archivoAConfigurar"
        agregarConfiguracion "pasv_max_port" "$3" "$archivoAConfigurar"
        if [ $2 -ne 0 ] || [ $3 -ne 0 ];
		then
            iptables -A INPUT -p tcp --match multiport --dports $2:$3 -j ACCEPT
            iptables -A OUTPUT -p tcp --match multiport --sports $2:$3 -j ACCEPT
        fi
    else
        agregarConfiguracion "pasv_max_port" '(none)' "$archivoAConfigurar"
        agregarConfiguracion "pasv_min_port" '(none)' "$archivoAConfigurar"
    fi
}
configureDelay(){
    #region [rgba(47, 0, 255, 0.10)] args
    # $1 : delay_successful_login {default:0}
    # $2 : delay_failed_login {default:1}
    #endregion
    agregarConfiguracion "delay_successful_login" "$1" "$archivoAConfigurar"
    agregarConfiguracion "delay_failed_login" "$2" "$archivoAConfigurar"
}
configurarMaximos(){
    #region [rgba(47, 0, 255, 0.10)] args
    # $1 : max_per_ip {default: 50}
    # $2 : max_login_fails {default: 3}
    # $3 : max_clients {default: 2000}
    # $4 : local_max_rate {default: 0} maximo bits por segundo para usuarios autentificados
    #endregion
    agregarConfiguracion "max_per_ip" "$1" "$archivoAConfigurar"
    agregarConfiguracion "max_login_fails" "$2" "$archivoAConfigurar"
    agregarConfiguracion "max_clients" "$3" "$archivoAConfigurar"
    agregarConfiguracion "local_max_rate" "$4" "$archivoAConfigurar"
}
configuracionProtocolo(){
    # $1 : listen {default: NO}
    if [ "$1" = "YES" ];
	then
        agregarConfiguracion "listen" "YES" "$archivoAConfigurar"
        agregarConfiguracion "listen_ipv6" "NO" "$archivoAConfigurar"
    else
        agregarConfiguracion "listen" "NO" "$archivoAConfigurar"
        agregarConfiguracion "listen_ipv6" "YES" "$archivoAConfigurar"
    fi
    
}
#endregion
#region tomar y agregar configuracion especifica
agregarConfiguracion(){
    #region [rgba(47, 0, 255, 0.10)] args
    # $1 : nombre de la configuracion
    # $2 : value
    # $3 : archivo
    #endregion
    
    local patronBusqueda="^$1=.*"
    if [ "$2" = "(none)" ];
	then
        sed -i "/$patronBusqueda/d" "$3"
    else
        if [ $(grep -cE  "$patronBusqueda" $3) -eq 1 ];
		then
            sed -i "s|$patronBusqueda|$1=$2|g" "$3"
        else
            sed -i "/$patronBusqueda/d" "$3" #elimina todas las lineas, si no hay, no hace nada y si es mas de una, las borra 
            if [ $(cat -A "$3" | grep -c $) -gt $(wc -l "$3" | cut -d" " -f1) ];
		    then # evita que dos lineas se junten en una
                echo "" >> "$3"
            fi
            echo "$1=$2" >> "$3"
        fi
    fi  
}

getConfiguracion(){
    # $1 : nombre de la configuracion
    # $2 : respuesta por defecto
    local lectura=$(grep -oP "(?<=^$1=).+" "$archivoAConfigurar")
    
    if [ "$lectura" ];
	then
        echo -n $lectura 
    else
        echo -n $2
    fi
}
configuracionEsTrue(){
    #region [rgba(47, 0, 255, 0.10)] args
    # $1 : nombre de la configuracion
    # $2 : operador
    # $3 : valor a comparar
    # retorna : true si es 
    #   nom configuracion es 
    #   operador (ej =) a 
    #   YES 
    #endregion
    if [ "$(getConfiguracion $1)" $2 "$3" ];
	then
        echo true
    else
        echo false
    fi
}
#endregion

definirVariables(){
    if [ -z "$(grep vsftpPrincipal /etc/environment)" ];
	then
        echo "export vsftpPrincipal=/etc/vsftpd/vsftpd.conf" >> /etc/environment
        echo "export userList=/etc/vsftpd/user_list" >> /etc/environment
        echo "export bannerPath=/bannerFTP.msg" >> /etc/environment
        source "/etc/environment"
    else
        source "/etc/environment"
    fi
    archivoAConfigurar=$vsftpPrincipal

}
if [ $EUID -eq 0 ];
then
    definirVariables
fi