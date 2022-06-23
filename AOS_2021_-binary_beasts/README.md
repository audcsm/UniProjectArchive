# AOS-2021-Binary-Beasts

# Introduction

## Branches

* Each contributor has a branch of their own, titled their name for easy distinction. This is mainly where each of us do our work on the version control.  

* The **_development_** branch is used when a contributor makes a change that should be checked by everyone before it is pushed into **_main_**. This allows for testing and proofreading to occur in a place where there isn't a risk of overwriting stable versions.  

* If one or multiple contributors decide to work on an isolated piece of the project, the **_feature_** branch will be utilised to separate this work from other work they may be doing on their named branch.  

* The raspberry pi pushes updates to the **_pi\_monitor_** branch before merging with **_main_**. It gives contributors the opportunity to catch faults more easily and keep pi updates separate from contributions.  

# Prerequisites
* Raspberry PI Model 4b
* Raspberry PI OS
* Python3 
* PiCamera
* CPUFreqUtils 

**Note** - PiCamera is not currently avaialable for Windows OS' as required installation files are missing.

# Installation

The Raspberry Pi 4b must be set up in the standard way, as detialed in the [official documentation](https://www.raspberrypi.com/documentation/computers/getting-started.html)
Model 4b is being used as it is the most powerful available Pi.
A Raspberry Pi camera module must be physically plugged in to the pi.


* Python3 `sudo apt-get install python3-pip`
* PiCamera `sudo pip install picamera`
* CPUFreqUtils 'sudo apt-get install cpufrequtils'

**Note** - Python3, pip and PiCamera are pre-installed with Raspberry PI OS.
Other distros can find information on PiCamera at: [pi camera library](https://picamera.readthedocs.io/en/release-1.13/install.html)

Once the Pi is initially set up, it can be used without other peripherals (mouse, keyboard, monitor) since it can be run just using SSH.

# Features

* Automatic Git commit, pushing and pulling
* Optimistaiton for running system headless
* CPU frequency changing based on if system is idle
* Camera that takes pictures on schedule and also on user command
* Automatic sending of pictures to the cloud to be viewed
* Logging that takes place whenever anything happens on the system
* Scheduled log rotations to clear out old, irrelevant logs


# Usage

## Autogit.sh

This script takes care of automatic synchronization of local git on the raspberry pi with the remote repository on Github.
On the raspberry pi, there are two branches: 
+ **_main_** branch is the branch with all most recent changes. Contents of this branch should never be directly modified while connected to the raspberry pi.
+ **_pi_monitor_** is the working branch. Changes made on the raspberry pi should only be made on this branch. 
By default, when a user logs on the raspberry pi, they are in *pi_monitor* branch.
`autogit.sh` is scheduled via **crontab** to run every eight hours. We believe that this schedule is effective because it is not too frequent as to run without any changes being made, but also frequent enough to include major modifications to files on remote *main* branch.
In order to manage the branches and their contents correctly, `autogit.sh` does the following steps each time it runs:
   1. As the current branch is *pi_monitor*, all changes are staged and committed. These changes are mostly new logs and/or log rotation.
   2. The branch is switched to the *main* branch and data are "pulled down" in order to update the local branch with the data from the remote repository.
   3. The logic is that the data from the remote repository is correct, since it is more recent than local data. The only exception are the logs. Local logs are always more recent that the remote logs. For this reason, the logs that have been "pulled down" are replaced with the local logs saved on the *pi_monitor* branch. The logs on branch *main* are essentially overwritten by logs on the *pi_monitor* branch.
   4. Next step is to switch to branch *pi_monitor* and update it with new data from *main* that have been pulled from the remote repository. The following code is executed: `git merge -X theirs main` which automatically resolves any unexpected merge conflicts by prioritizing data on *main* branch over data on *pi_monitor* branch. Thanks to the previous step, the newest logs are already on the *main* branch and therefore this operation is safe.
   5. The merge is committed, logged and "pushed" to the *pi_monitor* branch located in the remote repository.
   6. Then the branch is switched back to *main*, which is subsequently merged with *pi_monitor*. This is done so that the commit from the previous merge is also included on the *main* branch. The contents of this branch are then "pushed" to the remote repository.
   7. Finally, the branch is switched back to *pi_monitor* so that any subsequent changes are made on this branch and not on the *main* branch.
> **Note** that when this script runs, it puts the commits under David's account, even though they are automated.

## Headless Optimisation

Since this project does not require HDMI or USB, they are disabled to save power  
To run:
`cd AOS_2021_-binary_beasts`

`bash headless_optimise.sh`

The main lines are:
```bash
sudo /opt/vc/bin/tvservice -o #Disable HDMI
echo '1-1' |sudo tee /sys/bus/usb/drivers/usb/unbind # Disable USB
```



If you need to use the Pi in 'head' mode for any reason, this can be disabled with:
`cd AOS_2021_-binary_beasts`

`bash undo_headless_optimise.sh`

The key lines are:

```bash
sudo /opt/vc/bin/tvservice -p #Enable HDMI

echo '1-1' |sudo tee /sys/bus/usb/drivers/usb/bind #Enable USB
```

## Changing CPU performance

Since the Pi will often be idle, it makes sense for the CPUs governors to be in 'powersave' mode most of the time.
Then, when something important (such as taking a picture) takes place, it will be more beneficial for the CPU to be in 'performance' mode.
The scripts to do this are:

[performance_cpu.sh](https://github.com/cccu-uk/AOS_2021_-binary_beasts/blob/main/performance_cpu.sh)

and 

[powersave_cpu.sh](https://github.com/cccu-uk/AOS_2021_-binary_beasts/blob/main/powersave_cpu.sh)

These scripts are not intended to be manually run, they are to be called by others such as the camera.

These scripts utilise the CPUFreqUtils library, they work by changing the maximum and minimum frequency values that the CPU can run at.
This library was used because it is very simple, it does not take up much space and has been around for a long time. When doing research, it seemed to be brought up a lot so I would consider it to be the industry standard.
These scripts can also be tested by running `cpufreq-info`, this will display each Cores CPU values.

The key lines of code in each are:

```bash
sudo cpufreq-set -u 1.5Ghz
sudo cpufreq-set -d 1.5Ghz
``` 
for the high performance mode and
```bash
sudo cpufreq-set -u 1.5Ghz
sudo cpufreq-set -d 600Mhz
``` 
for the powersaving mode

## Logging

The log file can be found at [~/AOS_2021_-binary_beasts/log/logfile.log](https://github.com/cccu-uk/AOS_2021_-binary_beasts/blob/main/log/logfile.log)

### Status Logger

All scripts execute [statuslogger.sh](https://github.com/cccu-uk/AOS_2021_-binary_beasts/blob/main/statuslogger.sh) with some arguments to write to the log file.  

Though this shell script is most often called automatically by another, syntax and error messages are provided for the rare case that a user would like to write a log message from the shell. In this case, using `--help` will give a list of syntax and the filename can be replaced with "shell". 

`bash statuslogger.sh [-i, -n, -w, -e, -c, -I, -t, -C] [filename.sh] ["log message"]`

Option definitions:

* -i INFO: small events
* -n NOTICE: significant events/changes
* -w WARNING: undesirable occurrences but not errors
* -e ERROR: runtime errors that should be monitored
* -c CRITICAL: errors that require immediate action
* -I IP: recording of the current IP address. See [iplogger.sh](https://github.com/cccu-uk/AOS_2021_-binary_beasts/blob/main/iplogger.sh)
* -t TEST: testing in any regard, manual or automatic   
* -C CUSTOM: custom log. Any amount of args, does not have to follow syntax

### System Logger

Every 4 hours [systemlogger.sh](https://github.com/cccu-uk/AOS_2021_-binary_beasts/blob/main/statuslogger.sh) is executed automatically via crontab. This duration was selected to allow for frequent checks of the system statistics without overloading the log. It also lines up with the automatic IP logging, which also occurs every 4 hours.  

To run manually, no arguments are needed, just `bash path/to/script/systemlogger.sh`.  

This script has three sections: Disk Space, CPU Usage, and Last Login. The following sets of commands are used by the script to find the proper information for each:  

* The total disk space and usage are found and written to a variable: `DISKTOTAL=$(df -h -P --total | tail -1)`. The `tail -1` portion takes only the final line of the output from `df`. Then, the `cut` command is ued so split this string into pieces for Total, Available, and Used. This is then reconstructed into a more human-friendly string.

* The CPU usage is found using `grep -w 'cpu' /proc/stat` initially, which searches the /proc/stat file for the line that begins with "cpu". Then, `awk` separates the output into fields and uses some maths to determine the total used CPU and the total free CPU. This makes up the second line sent to the log file.  

* Finally, the command `lastlog` is used to find the most recent time anyone accessed the raspberry pi via the username 'pi'. The output, similarly to the disk space section, is separated into variables using `cut` and rearranged into a descriptive string that includes the IP, date, and time of the last login. 

Below is an example from the logfile of what all of this looks like:  
```
[2022/03/09T12:09:10Z INFO] systemlogger.sh: Total Disk Space: 20G | Available: 14G | Used: 6.0G  
[2022/03/09T12:09:10Z INFO] systemlogger.sh: CPU Available: 99.94% | Used: 0.06%  
[2022/03/09T12:09:10Z INFO] systemlogger.sh: Last User Login: 10.150.200.186 on Wed 9 Mar 2022 at 11:59:3  
```

## Taking Photos

The system features two ways of taking a picture:
1. By command  - this will run a script, this can be done at any point while the raspberry pi is on.
Doing so will send the picture to remote storage, saving space on the pi.

`bash camera.sh`

2. Automatically by timer - This will take pictures every 30 minutes and send them to the remote storage.

`python3 camera_script.py`

Key lines
```
camera.resolution = (1980, 1080)
```
This can be changed to change the resolution of the cameras
```
camera.start_preview()
sleep(5)
```
Once the script is started the camera will be set to preview for 5 seconds before it'll take a picture. The picamera has a bit of a start up time which is why the sleep is implemented.
```
time = datetime.datetime.now().strftime('%Y%m%d%H%M%S')
imagesave= "3DPrinterImages/"+time+".png"
camera.capture(imagesave)
```
The pictures are all saved as the date and time that they were taken. The format of this can be changed to include anything the user wants.
```
camera.annotate_text = time
```
This will annotate the pictures with the time they were taken.

The regularity at which pictures are taken can be altered to the user's choice by editing when the script runs in the crontab.

[camera_script.py](https://github.com/cccu-uk/AOS_2021_-binary_beasts/blob/main/camera_script.py)

The file type that the images are saved as can be changed, but by default it is set to .png.  
PNG was chosen as it has a good ratio of resolution to image size, whereas JPEG would be too blurry/low res, and TIFF would take up too much space.

Only a certain number of images will be kept locally at a time, and shall be deleted upon going over a set number to prevent the storage from being filled up.

## Other

### Scheduling

We are using Crontab to schedule the scripts that need to be executed automatically. This allows us to set exactly what minute, hour, day, etc that we would like each respective script to run.  

See below for the documentation and usage of Crontab.  

[Crontab - Quick Reference](https://www.adminschoice.com/crontab-quick-reference)

### GitHub-Discord Integration

For the development of this project, we set up a webhook with the group's development Discord server that would send out messages and notifiations when commits took place.



# Contributors

* Nathan Shuttleworth
* David Filipiak
* Ben Fowler
* Audrey Smith

## References

* Rush, Chris (2019) - [How to save power on your Raspberry Pi](https://learn.pi-supply.com/make/how-to-save-power-on-your-raspberry-pi/) - Accessed 23/2/2022  
* Wysocki, Rafael (2017) - [CPU Performance Scaling](https://www.kernel.org/doc/html/latest/admin-guide/pm/cpufreq.html) - Accessed 2/3/2022  
* Jones, Dave (2013 - 2016) - [picamera](https://picamera.readthedocs.io/en/release-1.13/) - Accessed 25/2/2022  
* Pleski, Elvis (2021) - [How To Find a File In Linux From the Command Line](https://www.plesk.com/blog/various/find-files-in-linux-via-command-line/) - Accessed 10/3/2022  
* Schkn (2021) - [How To Find Last Login on Linux](https://devconnected.com/how-to-find-last-login-on-linux/) - Accessed 9/3/2022
* Computer Hope (2021) - [Linux Cut Command](https://www.computerhope.com/unix/ucut.htm#syntax) - Accessed 9/3/2022
* thinkwiki (2007) - [How to use cpufrequtils](https://www.thinkwiki.org/wiki/How_to_use_cpufrequtils) - Accessed 18/3/2022
