#!/usr/bin/bash

#targetaDeRed1="10.0.2.15/24"
#targetaDeRed2="10.0.2.15/"
#ip a flush dev eth0
#ip a add 127.0.0.1/8 dev lo
#ip a add 10.0.2.15/24 dev enp0s3
#necesita root 


echo "DHCPDARGS=enp0s3" >> /etc/sysconfig/dhcpd
cp "/Scripts/ConfigurarEntorno/_DHCP/configuracionDHCPD.conf"  /etc/dhcp/dhcpd.conf 
firewall-cmd --add-service=dhcp --permanent 
firewall-cmd --reload 
systemctl restart network
systemctl restart dhcpd