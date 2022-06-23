#! /usr/bin/env bash 

cd ~/AOS_2021_-binary_beasts/3DPrinterImages/

LOCATION="/home/pi/AOS_2021_-binary_beasts/3DPrinterImages/"
REMOTEPI="pi@10.150.200.120:/media/pi/NAS/3DPrinterImages/Node2/"
DATETIME=$(date +"%Y%m%d%H%M%S")
VAR=$(ls | sort -V | tail -n 1)

if [[ $PHOTOCOUNT -le 5 ]] 
then
    sshpass -p a052022 scp -P 443 $LOCATION$VAR $REMOTEPI
fi
