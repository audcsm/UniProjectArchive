#!/bin/bash


#Script to make CPU run at low frequency for idle times


sudo cpufreq-set -g userspace

sudo cpufreq-set -u 1.5Ghz
sudo cpufreq-set -d 600Mhz


cd
cd /home/pi/AOS_2021_-binary_beasts

# logging to logfile.log 
bash $(find ~/ -name statuslogger.sh) -i powersave_cpu.sh "CPU set to power save mode"
