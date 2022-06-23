#!/bin/env bash

LOCATION="/home/pi/AOS_2021_-binary_beasts/3DPrinterImages/"
REMOTEPI="pi@10.150.200.120:/media/pi/NAS/3DPrinterImages/Node2/"
DATETIME=$(date +"%y%m%d%H%M%S")
IMAGETAKEN=$(date +"%y-%m-%d-%H-%M-%S")

cd ~/AOS_2021_-binary_beasts/

mkdir -p 3DPrinterImages

cd ~/AOS_2021_-binary_beasts/3DPrinterImages/


PHOTOCOUNT=$(ls *.png | wc -l)

if [[ $PHOTOCOUNT -ge 5 ]]
then 
    rm *.png
fi

raspistill -o $DATETIME.png


if [[ $PHOTOCOUNT -le 5 ]] 
then
    sshpass -p a052022 scp -P 443 $LOCATION$DATETIME.png $REMOTEPI
    echo Image take at $IMAGETAKEN
fi