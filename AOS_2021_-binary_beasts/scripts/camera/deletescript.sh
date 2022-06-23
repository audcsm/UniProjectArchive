#! /usr/bin/env bash 

cd ~/AOS_2021_-binary_beasts/3DPrinterImages/


PHOTOCOUNT=$(ls *.png | wc -l)

if [[ $PHOTOCOUNT -ge 5 ]]
then 
    rm *.png
fi

# logging to logfile.log
bash $(find ~/ -name statuslogger.sh) -i deletescript.sh "Cleared temporary image storage"