#!/usr/bin/bash
#necesita root 



configurarRed(){
    # $1 : ip mi maquina
    # $2 : prefix
    # $3 : puerta de enlace
    # $4 : dns (8.8.8.8)

    local ifcfg_auxiliar="/Scripts/ConfigurarEntorno/_RED/ifcfg-enp0s3nuevo"
    local ifcfg_viejo="/Scripts/ConfigurarEntorno/_RED/ifcfg-enp0s3viejo"
    local ifcfg_a_remplazar="/etc/sysconfig/network-scripts/ifcfg-enp0s3"

    cp $ifcfg_auxiliar $ifcfg_a_remplazar

    sed -i "s/IPADDR=ip/IPADDR=$1/g" $ifcfg_a_remplazar
    sed -i "s/PREFIX=prefix/PREFIX=$2/g" $ifcfg_a_remplazar
    sed -i "s/GATEWAY=gateway/GATEWAY=$3/g" $ifcfg_a_remplazar
    sed -i "s/DNS1=dns/DNS1=$4/g" $ifcfg_a_remplazar


    systemctl restart network
}
configurarRed 192.168.1.9 24 192.168.1.1 8.8.8.8