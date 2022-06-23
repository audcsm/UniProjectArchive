#!/bin/bash

#put CPU into higher Frequency mode
#sudo bash $(find ~/ -name performance_cpu.sh) #put CPU into higher Frequency mode

git checkout pi_monitor

# update the logs since last autogit run
git add .
git commit -m "<mod> updated the logs"

# go to branch 'main' to make it up to date with Github repository


git checkout main

git pull

# updating downlaoded logs with logs on branch 'pi_monitor'
# basically overwrites logs on 'main' by logs on 'pi_monitor', which should always be the most recen logs
# sources used for this part:
# https://stackoverflow.com/questions/18115411/how-to-merge-specific-files-from-git-branches
# https://clubmate.fi/git-checkout-file-or-directories-from-another-branch
git checkout pi_monitor -- log
git stash
git checkout main
git stash pop
git add .
git commit -m "<mod> synchronised logs from pi_monitor into main"

# start updating the branch 'pi_monitor' with changes on branch 'main'
git checkout pi_monitor

# in case of a merge conflict, choose the version on 'main' branch, because that one should be more up to date
git merge -X theirs main -m "<mod> daily merge - updated the raspberry pi with the most recent changes" 

git push

# go back to the 'main' branch after 'pi-monitor' has been updated
git checkout main

# update the 'main' branch with the previous merge commit made on the 'pi_monitor' branch
# there should not happen any merge conflicts in this case
git merge pi_monitor

git push

# go back to 'pi_monitor', so that changes are not made on the 'main' branch
git checkout pi_monitor

# logging to logfile.log 
bash $(find ~/ -name statuslogger.sh) -n autogit.sh "Automatic daily git update of local and remote branches"

#move CPU frequency lower, system is idle again
#sudo bash $(find ~/ -name powersave_cpu.sh)