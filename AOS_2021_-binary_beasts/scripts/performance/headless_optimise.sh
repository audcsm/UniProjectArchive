#!/bin/env/bash

cd
#Code adapted from: https://learn.pi-supply.com/make/how-to-save-power-on-your-raspberry-pi/

#disable hdmi
sudo /opt/vc/bin/tvservice -o

#disable usb
echo '1-1' |sudo tee /sys/bus/usb/drivers/usb/unbind

# logging to logfile.log 
bash $(find ~/ -name statuslogger.sh) -i headless_optimise.sh "Disabled HDMI and USB"