interfaz=$(ip a | grep inet)
echo "DHCPDARGS=$interfaz" >> /etc/sysconfig/dhcpd