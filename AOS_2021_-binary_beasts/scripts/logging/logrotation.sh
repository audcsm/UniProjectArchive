#! /usr/bin/env bash
# CREATED BY: David Filipiak
# Date Created: 2022/02/24
# Version 0.1

# This scirpt performs log rotation
AUTHOR="David"
VERSION="0.1"
RELEASED="2022-02-24"

LOGPATH="$(find ~/ -name logfile.log)"
#source "$(find ~/ -name scripts.config)"

#PLEASE DO NOT PUT ANY .gz FILES INSIDE ./log EXCEPT THE LOGFILES
countLogFiles(){
    #echo $(ls ${LOGPATH%/*} | grep "${LOGPATH##/*}.*.gz" | wc -l )
    echo $(ls ${LOGPATH%/*} | grep ".*.gz$" | wc -l )
}

#bash $(find ~/ -name statuslogger.sh) -i logrotation.sh "Log rotation check"

log_size=$(wc -l $LOGPATH | awk '{print $1}')

log_files_count=$(countLogFiles)

if [[ ${log_size} -gt 1500 ]]; then
    #echo $(ls ${LOGPATH%/*})
    #echo $(ls ${LOGPATH%/*} | grep ".*.gz$")
    #echo ${log_files_count}
    if [ ${log_files_count} -gt 0 ]; then
        for ((i=${log_files_count}; i!=0; i--)); do
            n=$((${i}+1))
            #echo "${i} ${n}"
            mv ${LOGPATH}.${i}.gz ${LOGPATH}.${n}.gz
        done
    fi
    gzip -c "${LOGPATH}" > "${LOGPATH}.1.gz"
    > ${LOGPATH}   # clears the logfile
    # logging to logfile.log 
    bash $(find ~/ -name statuslogger.sh) -n logrotation.sh "Log rotation successful"
fi

# remove 6th+ extra log files
log_files_count=$(countLogFiles)
if [ ${log_files_count} -gt 5 ]; then
    for ((i=${log_files_count}; i>5; i--)); do
        rm -v -f ${LOGPATH}.${i}.gz
        # logging to logfile.log 
        bash $(find ~/ -name statuslogger.sh) -n logrotation.sh "Extra file logfile.log.6.gz removed"
    done
fi
    