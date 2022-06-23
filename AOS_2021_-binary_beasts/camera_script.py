#! /usr/bin/env python
#sshpass -p "a052022" scp -P 443 ~/AOS_2021_-binary_beasts/3DPrinterImages pi@10.150.200.120:/media/pi/NAS/3DPrinterImages/Node#/
#scp pi@raspberrypi:/tmp/picture.jpg ~/Downloads/
import datetime
from time import sleep
from os import system
from picamera import PiCamera
import subprocess

camera = PiCamera()
camera.resolution = (1980, 1080)


#subprocess.run(["bash","./performance/performance_cpu.sh"])#Pi Performance mode
camera.start_preview()
sleep(5)
subprocess.run(["mkdir","-p","3DPrinterImages"])
subprocess.run(["bash", "./camera/deletescript.sh"])
time = datetime.datetime.now().strftime('%Y%m%d%H%M%S')
imagesave= "3DPrinterImages/"+time+".png"
camera.capture(imagesave)
time = datetime.datetime.now().strftime('%Y-%m-%d %H:%M:%S')
camera.annotate_text = time
subprocess.run(["bash","./logging/statuslogger.sh","-i","camera_script.py","Image taken"])#logging to logfile.log
print("Image taken at",time)
camera.stop_preview()
subprocess.run(["bash","./camera/sshpasscamerascript.sh"])#Sends images to remote pi
subprocess.run(["bash","./logging/statuslogger.sh","-i","camera_script.py","Image sent to remote pi"])#logging to logfile.log
#subprocess.run(["bash","./performance/powersave_cpu.sh"])#Pi power save Mode
