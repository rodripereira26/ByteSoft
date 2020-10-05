#!/bin/bash

#necesita root
crontabConf() {
	local respaldo="/var/bytesoft/backupsBD/.credenciales.cnf"

	if [ -e $respaldo ];
	then
		echo 1
	else
		touch $respaldo
		echo "[mysqldump]">>$respaldo 	
		echo "user=root">>$respaldo # cambiar usuario
		echo "password=Root123;">>$respaldo # cambiar contraseña
		
	

		chmod 600 $respaldo
		mkdir -p /var/bytesoft/backupsLog/{$(date +%a),$(date +%a --date='+1 day'),$(date +%a --date='+2 day'),$(date +%a --date='+3 day'),$(date +%a --date='+4 day'),$(date +%a --date='+5 day'),$(date +%a --date='+6 day'),$(date +%a --date='+7 day')}
		mkdir -p /var/bytesoft/backupsDIR/{$(date +%a),$(date +%a --date='+1 day'),$(date +%a --date='+2 day'),$(date +%a --date='+3 day'),$(date +%a --date='+4 day'),$(date +%a --date='+5 day'),$(date +%a --date='+6 day'),$(date +%a --date='+7 day')}
		mkdir -p /var/bytesoft/backupsBD/{$(date +%a),$(date +%a --date='+1 day'),$(date +%a --date='+2 day'),$(date +%a --date='+3 day'),$(date +%a --date='+4 day'),$(date +%a --date='+5 day'),$(date +%a --date='+6 day'),$(date +%a --date='+7 day')}
		cp -f /Scripts/ConfigurarEntorno/Backup/backupIncremental.sh /etc
		cp -f /Scripts/ConfigurarEntorno/Backup/backupTotal.sh /etc
		chmod ugo+x /etc/backupIncremental.sh
		chmod ugo+x /etc/backupTotal.sh
		cp -f /etc/crontab /var/bytesoft/.crontab
		cp -f /Scripts/ConfigurarEntorno/Backup/ejecutarCrontab.sh /etc
		chmod +x /Scripts/ConfigurarEntorno/Backup/ejecutarCrontab.sh
		chmod +x /etc/ejecutarCrontab.sh
		cp -f /etc/rc.d/rc.local /var/bytesoft/.rc.local
		echo "/etc/ejecutarCrontab.sh" >> /etc/rc.d/rc.local
		chmod +x /etc/rc.d/rc.local
		echo "* */12 * * * root /etc/backupIncremental.sh">>/etc/crontab
		echo "0 3 * * 0 root /etc/backupTotal.sh">>/etc/crontab
		source /etc/ejecutarCrontab.sh 
		systemctl restart crond.service > /dev/null 2>&1
		echo 0
	fi
}
firewallConfRespaldos(){
	iptables -F
	iptables -X
	iptables -Z
	iptables -t nat -F

	iptables -P INPUT DROP
	iptables -P OUTPUT DROP
	iptables -P FORWARD DROP
	
	iptables -A INPUT -s $IP_SERVIDOR -j ACCEPT #IP de la OVA, cambiar por la del servidor
	iptables -A OUTPUT -s $IP_SERVIDOR -j ACCEPT #IP de la OVA, cambiar por la del servidor

}
firewallConf() {
	#Flush de las reglas
	iptables -F
	iptables -X
	iptables -Z
	iptables -t nat -F

	iptables -P INPUT DROP
	iptables -P OUTPUT DROP
	iptables -P FORWARD DROP

	# INPUT
	#iptables -A INPUT -s $ip -j ACCEPT #IP de la OVA, cambiar por la del servidor
	iptables -A INPUT -i lo -j ACCEPT # LOCALHOST
	iptables -A INPUT -m state --state ESTABLISHED,RELATED -j ACCEPT
	iptables -A INPUT -p tcp --dport 20:21 -j ACCEPT # FTP
	iptables -A INPUT -p tcp --dport 25 -j ACCEPT # SMTP
	iptables -A INPUT -p udp --dport 53 -j ACCEPT
	iptables -A INPUT -p tcp --dport 80 -j ACCEPT # HTTP
	iptables -A INPUT -p tcp --dport 443 -j ACCEPT # HTTPs
	iptables -A INPUT -p tcp --dport 445 -j ACCEPT # SAMBA
	iptables -A INPUT -p tcp --dport 993 -j ACCEPT # IMAP SSL
	iptables -A INPUT -p tcp --dport 995 -j ACCEPT # POP3 SSL
	iptables -A INPUT -p tcp --dport 2022 -j ACCEPT # SSH #cambiar por el 2022
	iptables -A INPUT -p tcp --dport 3306 -j ACCEPT # MYSQL
	iptables -A INPUT -p tcp --dport 3128 -j ACCEPT # SQUID
	iptables -A INPUT -p tcp --dport 8080 -j ACCEPT
	iptables -I INPUT -i enp0s3 -p udp --dport 67:68 --sport \67:68 -j ACCEPT #DHCP
	iptables -A INPUT -p tcp --dport 9418 -j ACCEPT # GIT
	#iptables -A INPUT -s $IP_SUBRED_ADMIN -j ACCEPT # IP de la subred de administradores

	# OUTPUT
	#iptables -A OUTPUT -s $ip -j ACCEPT #IP de la OVA, cambiar por la del servidor
	iptables -A OUTPUT -m state --state ESTABLISHED,RELATED -j ACCEPT
	iptables -A OUTPUT -p tcp --dport 20:21 -j ACCEPT # FTP
	iptables -A OUTPUT -p tcp --dport 25 -j ACCEPT # SMTP
	iptables -A OUTPUT -p udp --dport 53 -j ACCEPT
	iptables -A OUTPUT -p tcp --dport 80 -j ACCEPT # HTTP
	iptables -A OUTPUT -p tcp --dport 443 -j ACCEPT # HTTPS
	iptables -A OUTPUT -p tcp --dport 445 -j ACCEPT # SAMBA
	iptables -A OUTPUT -p tcp --dport 993 -j ACCEPT # IMAP SSL
	iptables -A OUTPUT -p tcp --dport 995 -j ACCEPT # POP3 SSL
	iptables -A OUTPUT -p tcp --dport 2022 -j ACCEPT # SSH
	iptables -A OUTPUT -p tcp --dport 3306 -j ACCEPT # MYSQL
	iptables -A OUTPUT -p tcp --dport 8080 -j ACCEPT
	iptables -A OUTPUT -p tcp --dport 9418 -j ACCEPT # GIT
	iptables -A OUTPUT -p tcp --dport 3128 -j ACCEPT # SQUID
	iptables -A OUTPUT -p icmp --icmp-type echo-request -j ACCEPT # Peticiones de ping salientes

	# Reinicio el servicio
	service iptables save > /dev/null 2>&1
	service iptables restart > /dev/null 2>&1



}

desinstalar() {

	# Restauro el firewall
	iptables -F
	iptables -X
	iptables -Z
	iptables -t nat -F
	iptables -P INPUT ACCEPT
	iptables -P OUTPUT ACCEPT
	iptables -P FORWARD ACCEPT

	service iptables save > /dev/null 2>&1
	service iptables restart > /dev/null 2>&1


	# Restauro SSH 
	mv -f /var/bytesoft/.sshd_config /etc/ssh/sshd_config
	semanage port -d -t ssh_port_t -p tcp 2022 
	systemctl restart sshd > /dev/null 2>&1

	# Restauro crontab
	mv -f /var/bytesoft/.crontab /etc/crontab
	mv -f /var/bytesoft/.rc.local /etc/rc.d/rc.local
	rm -f /etc/backupIncremental.sh
	rm -f /etc/backupTotal.sh
	rm -f /etc/ejecutarCrontab.sh
	sh /Scripts/ConfigurarEntorno/Backup/ejecutarCrontab.sh
	systemctl restart crond.service > /dev/null 2>&1

	# Borro las carpetas
	rm -rf /var/bytesoft 
	rm -rf /home/USUARIOS 

	# Borro variables
	rm -rf /etc/environment
	touch /etc/environment

}
