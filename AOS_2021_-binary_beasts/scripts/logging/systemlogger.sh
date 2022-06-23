#! /usr/bin/env bash
# CREATED BY: Audrey Smith
# Date Created: 2022/03/09
# Version 0.1

# This script logs the pi system stats at any given time
AUTHOR="Audrey"
VERSION="0.1"
RELEASED="2022/03/09"


# DISK SPACE

# Use df to get disk free stats and save the "total" line
DISKTOTAL=$(df -h -P --total | tail -1)

# System Storage: (arg 2), Available: (arg 4), Used: (arg 3)
DFTOTAL=$(echo $DISKTOTAL | cut -d ' ' -f 2)
DFUSED=$(echo $DISKTOTAL | cut -d ' ' -f 3)
DFAVAI=$(echo $DISKTOTAL | cut -d ' ' -f 4)
DISK="Total Disk Space: ${DFTOTAL} | Available: ${DFAVAI} | Used: ${DFUSED}"


# CPU USAGE

# Use proc stat to get cpu usage and arrange arguments to get cpu usage and available
CPU=$(grep -w 'cpu' /proc/stat | awk '{(cpuused=($2+$3+$4+$6+$7+$8)*100/($2+$3+$4+$5+$6+$7+$8))}
                                      {cpuavai=($5)*100/($2+$3+$4+$5+$6+$7+$8)}
                                      END {printf " | Used: %.2f%%",cpuused}
                                          {printf "CPU Available: %.2f%%",cpuavai}')


# LAST LOGIN

# Use lastlog to get last user login via pi
LASTUSER="$(lastlog -u pi | tail -1)"

# Last Login: (ip) on (weekday) (date) (month) (year) at (time)
LUIP="$(echo $LASTUSER | cut -d ' ' -f 3)"
LUDAY="$(echo $LASTUSER | cut -d ' ' -f 4)"
LUDATE="$(echo $LASTUSER | cut -d ' ' -f 6)"
LUMONTH="$(echo $LASTUSER | cut -d ' ' -f 5)"
LUYEAR="$(echo $LASTUSER | cut -d ' ' -f 9)"
LUTIME="$(echo $LASTUSER | cut -d ' ' -f 7)"
LASTLOGIN="Last User Login: ${LUIP} on ${LUDAY} ${LUDATE} ${LUMONTH} ${LUYEAR} at ${LUTIME}"


# Log all stats using a line for each
bash $(find ~/ -name statuslogger.sh) -i systemlogger.sh "$DISK"
bash $(find ~/ -name statuslogger.sh) -i systemlogger.sh "$CPU"
bash $(find ~/ -name statuslogger.sh) -i systemlogger.sh "$LASTLOGIN"