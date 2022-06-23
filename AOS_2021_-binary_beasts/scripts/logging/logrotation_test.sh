#! /usr/bin/env bash
# CREATED BY: David Filipiak
# Date Created: 2022/02/24
# Version 0.1

# This scirpt performs log rotation
AUTHOR="David"
VERSION="0.1"
RELEASED="2022-02-28"

LOGPATH="$(find ~/ -name logfile.log)"
#source "$(find ~/ -name scripts.config)"

if [ $# -ne 0 ]; then
    echo "Testing log rotation..."

    for ((i=0; i<$1; i++)); do
        
        echo -ne "${i}/$1 test logs done\r"

        #echo -e "Testing log number ${i}" >> ${LOGPATH}
        bash $(find ~/ -name statuslogger.sh) -t logrotation_test.sh "Test Log"
        bash $(find ~/ -name logrotation.sh)
    done

    echo "All test logs done!        "
else
    echo "Please add the amount of testing logs you want to make"
fi

