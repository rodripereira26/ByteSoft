#!/bin/bash

chcon -t system_cron_spool_t /etc/crontab
systemctl start crond