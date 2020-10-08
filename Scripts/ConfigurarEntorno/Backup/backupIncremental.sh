#!/bin/bash

BACKUP="/var/bytesoft/backupsBD/$(date +%a)/$(date +%H-%M)"

# Respaldo de la base de datos
mysqldump --defaults-file=/var/bytesoft/backupsBD/.credenciales.cnf --all-databases > "$BACKUP.sql"
tar -czf "$BACKUP.sql.tar.gz" -g "$BACKUP.snar" "$BACKUP.sql"
rm -f $BACKUP.sql

# Respaldo de los logs
tar -czf "/var/bytesoft/backupsLog/$(date +%a)/$(date +%H-%M).tar.gz" -g /var/bytesoft/backupsLog/$(date +%a)/$(date +%H-%M).snar /var/log

# Respaldo de los directorios
tar -czf "/var/bytesoft/backupsDIR/$(date +%a)/$(date +%H-%M).tar.gz" -g /var/bytesoft/backupsDIR/$(date +%a)/$(date +%H-%M).snar /home/USUARIOS

# Envío los datos al servidor remoto
rsync -az -e ssh "/var/bytesoft" bytesoftRespaldoEntrada@$IP_RESPALDO:/var/bytesoft # IP de prueba

# tar -xvf "/var/bytesoft/backupsLog/$(date +%a)/$(date +%H-%M).tar.gz" -g "/var/bytesoft/backupLog/$(date +%a)/$(date +%H-%M).snar" Para restaurar backups
# tar -xvf /var/bytesoft/backupsBD/$(date +%a)/$(date +%H-%M).tar.gz -g "/var/bytesoft/backupsBD/$(date +%a)/$(date +%H-%M).snar" 
# tar -xvf "/var/bytesoft/backupsDIR/$(date +%a)/$(date +%H-%M).tar.gz" -g "/var/bytesoft/backupsDIR/$(date +%a)/$(date +%H-%M).snar"
