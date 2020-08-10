#!/bin/bash

#
# cambiar de puerto no esta verificado
#


__init__(){


    _archAux="auxSSHD_config1.txt"
    _archAux2="auxSSHD_config2.txt"

    nroArchivoModificado=1

    archConfSSH="/etc/ssh/sshd_config"
    puertoAnterior=$(sudo grep "Port" $archConfSSH | cut -d " " -f2)
}
sacarConfig(){
    # $1 : txt
    if [ $nroArchivoModificado -eq 1 ];then
        sudo grep -v $1 $_archAux > $_archAux2
        nroArchivoModificado=2
    else
        sudo grep -v $1 $_archAux2 > $_archAux
        nroArchivoModificado=1
    fi
    
}
agregarConfig(){
    # $1 : config en txt
    archivoConfigurado=""
    if [ $nroArchivoModificado -eq 1 ];then
        (sudo cat $_archAux && echo -e $config) > $_archAux2
        archivoConfigurado=$_archAux2
        nroArchivoModificado=2
    else
        (sudo cat $_archAux2 && echo -e $config) > $_archAux
        archivoConfigurado=$_archAux
        nroArchivoModificado=1
    fi
}
agregarArchivosAuxiliares(){
    touch $_archAux $_archAux2
    sudo cat $archConfSSH > $_archAux #agrega configuracion del ssh actual al archivo
}
eliminarArchivosAuxiliares(){
    if [ -e $_archAux ];then
        rm $_archAux
    else # porque anteriormente lo movi de directorio
        rm $_archAux2
    fi
}
configurarFirewall(){
    sudo semanage port -a -t ssh_port_t -p tcp $puerto
    sudo ufw enable
    sudo ufw delete allow "$puertoAnterior/tcp"
    sudo ufw allow $puerto/tcp
    reiniciarServidor
}
reiniciarServidor(){
    sudo systemctl restart sshd
}
configurarSSH(){
    # $1 : puerto
    # $2 : config
    puerto=$1

    #configuracion 
    agregarArchivosAuxiliares
    sacarConfig "Port"
    sacarConfig "AllowUsers"
    sacarConfig "PermitRootLogin"
    sacarConfig "Host"
    agregarConfig $2

    sudo mv $archivoConfigurado $archConfSSH
    eliminarArchivosAuxiliares
    configurarFirewall

}
__init__
