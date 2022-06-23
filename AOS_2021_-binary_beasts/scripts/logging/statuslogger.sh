#! /usr/bin/env bash
# CREATED BY: Audrey Smith
# Date Created: 2022/03/23
# Version 0.4

# This script is designed to log events to logfile.log
AUTHOR="Audrey"
VERSION="0.4"
RELEASED="2022-03-23"

DATE=$(date +%Y/%m/%dT%H:%M:%SZ)
LOGPATH=$(find ~/ -name logfile.log)
MESSAGE="$3"

# Display help message in the case of manual logging via shell
USAGE(){
    echo -e $1
    echo -e "\nUsage: \nstatuslogger [-i log events] [-n log significant changes] [-w log warnings]"
    echo -e "[-e log error statuses] [-c log critical conditions] [-I log IP] [-t log testing]"
    echo -e "Example: bash statuslogger.sh -n autogit.sh \"Automatic push to GitHub\"\n"
}

# Create new log message
# [datetime protocol] source: message
LOG(){
    echo "[${DATE} $1] $2: ${MESSAGE}" >> ${LOGPATH}
}
CLOG(){
    echo "[${DATE} $1] ${@:2}" >> ${LOGPATH}
}

# Check for arguments (error checking)
# Intended for manual use of this script. Errors in automatic logging can be detected when the logfile isn't updated
if [ $1 == '-C' ];then
    : 
elif [ $# -lt 3 ];then
    USAGE "\nNot enough arguments"
    exit 1
elif [ $# -gt 3 ];then
    USAGE "\nToo many arguments"
    exit 1
elif [[ ( $1 == '-h') || ( $1 == '-help') ]];then
    USAGE "\nHelp!"
    exit 0
fi

# Option for each protocol
while getopts inwecItC OPTION
do
case ${OPTION}
in
i) LOG "INFO" $2 $3
   echo "Message with type INFO logged";;
n) LOG "NOTICE" $2 $3
   echo "Message with type NOTICE logged";;
w) LOG "WARNING" $2 $3
   echo "Message with type WARNING logged";;
e) LOG "ERROR" $2 $3
   echo "Message with type ERROR logged";;
c) LOG "CRITICAL" $2 $3
   echo "Message with type CRITICAL logged";;
I) LOG "IP" $2 $3
   echo "Message with type IP logged";;
t) LOG "TEST" $2 $3
   echo "Message with type TEST logged";;
C) CLOG "CUSTOM" ${@:2}
   echo "Message with type CUSTOM logged";;
*) USAGE "Option not recognised";;
esac
done