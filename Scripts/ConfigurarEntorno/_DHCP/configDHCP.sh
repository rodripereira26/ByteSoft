#!/usr/bin/bash
#necesita root 
# NO FUNCIONAL
#nmtui
echo "DHCPDARGS=enp0s3" >> /etc/sysconfig/dhcpd
cp "/Scripts/ConfigurarEntorno/_DHCP/ifcfg-enp0s3" /etc/sysconfig/network-scripts/ifcfg-enp0s3 
cp "/Scripts/ConfigurarEntorno/_DHCP/dhcpd.conf" /etc/dhcp/dhcpd.conf 

firewall-cmd --add-service=dhcp --permanent 
firewall-cmd --reload

systemctl restart network
systemctl restart dhcpd