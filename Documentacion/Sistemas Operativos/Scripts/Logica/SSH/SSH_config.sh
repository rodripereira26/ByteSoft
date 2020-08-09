#!/bin/bash

archAux="auxSSHD_config.txt"
archAux2="auxSSHD_config2.txt" # para evitar el error
archConfSSH="/etc/ssh/sshd_config"
puerto=22
puertoAnterior=$(sudo grep "Port" $archConfSSH | cut -d " " -f2)

touch $archAux
touch $archAux2

(sudo grep -v "Port" $archConfSSH && echo "Port $puerto") > $archAux
#(sudo grep -v "Host" $archAux && echo "Host *") > $archAux2
#(sudo grep -v "AllowUsers" $archAux2 && echo "AllowUsers AlexisUTU") > $archAux
(sudo grep -v "PermitRootLogin" $archAux && echo "PermitRootLogin yes") > $archAux2

sudo mv $archAux2 $archConfSSH
if [ -e $archAux ];then
    rm $archAux
fi
if [ -e $archAux2 ];then
    rm $archAux2
fi

semanage port -a -t ssh_port_t -p tcp $puerto

ufw enable
ufw delete allow $puertoAnterior/tcp
ufw allow $puerto/tcp

sudo systemctl restart sshd
