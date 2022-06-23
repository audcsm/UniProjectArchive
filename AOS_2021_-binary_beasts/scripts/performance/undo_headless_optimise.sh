#!/bin/env/bash

cd
#Code adapted from: https://learn.pi-supply.com/make/how-to-save-power-on-your-raspberry-pi/

#enable hdmi
sudo /opt/vc/bin/tvservice -p

#enable usb
echo '1-1' |sudo tee /sys/bus/usb/drivers/usb/bind

# logging to logfile.log 
bash $(find ~/ -name statuslogger.sh) -i undo_headless_optimise.sh "Enabled HDMI and USB"