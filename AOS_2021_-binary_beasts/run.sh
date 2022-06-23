#!/bin/env bash



bash $(find ~/ -name performance_cpu.sh)
bash $(find ~/ -name autogit.sh) && bash $(find ~/ -name systemlogger.sh)
bash $(find ~/ -name iplogger.sh) && bash $(find ~/ -name logrotation.sh)
bash $(find ~/ -name powersave_cpu.sh)
python3 $(find ~/ -name camera_script.py)

