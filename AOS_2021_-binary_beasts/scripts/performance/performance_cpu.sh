#!/bin/bash


#Script to make cpu run at high frequency for important jobs


sudo cpufreq-set -g userspace

sudo cpufreq-set -u 1.5Ghz
sudo cpufreq-set -d 1.5Ghz


cd
cd /home/pi/AOS_2021_-binary_beasts

# logging to logfile.log 
bash $(find ~/ -name statuslogger.sh) -i performance_cpu.sh "CPU set to performance mode"