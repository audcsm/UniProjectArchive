#! /usr/bin/env bash
# CREATED BY: Audrey Smith
# Date Created: 2022/02/24
# Version 0.3

# This script is designed to log the IP
AUTHOR="Audrey"
VERSION="0.3"
RELEASED="2022-03-02"

DATE=$(date +%Y/%m/%dT%H:%M:%SZ)
IP=$(hostname -I)
bash $(find ~/ -name statuslogger.sh) -I iplogger.sh ${IP}