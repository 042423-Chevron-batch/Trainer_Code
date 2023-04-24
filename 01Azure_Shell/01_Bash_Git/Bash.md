## What is Bash?
Bash is a command line interface, or software that interacts with an operating system via text commands. In particular, Bash is a CLI (command line interface) that is used in Linux systems.

### Wait, but we're in Windows, why do we need to learn Bash?
Because Linux is used everywhere in IT industry and Linux operates primarily via CLI. While Windows and MacOS dominate the PC market, Linux is very Very popular in most business use cases. Why? Most importantly, it's Free. But also, it's lightweight, it's flexible, and there are probably a Linux flavor that'll suit exactly whatever you're trying to do (web server, IoT, etc.).

### Okay, but we're still in Windows and this is for Linux. How do we get this to work here?
The correct answer for this is Windows Subsystem Linux (WSL), which is a small Linux system living inside your windows OS. But for now we'll be using Git Bash, which is a *Bash Emulator* provided by Git (more on this later) to make  familiar bash commands available in Windows. Now, because it's a lightweight emulator, it is not capable of doing Everything bash can, but it will work for our purposes today.

## Basic Commands
Many bash commands are abbreviations. Use this to your advantage!
- ls (LiSt)
- cd (Change Directory)
	- Following are short hands for commonly used directories
		- / : root directory
		- ~ : home directory (usually users/your-user-name)
		- . :current directory
		- .. : parent directory
- pwd (Present Working Directory)
- touch
	- literally "touch" the file to change the modified time to now
	- HOWEVER, this is used the most often to create new files
- mkdir (MaKe DIRectory)
- rm (ReMove)
- echo (Hello? hello? ...hello? ......hello?)
- cat (conCATenate)
- cp (CoPy)
- mv (MoVe)

### Flags (or Options)
Flags are optional information you give to a particular command to extend/modify its behavior

#### Examples
- ls -a : displays ALL files/folders, yes, even your hidden ones
- rm -r: removes folders and their files recursively
- _command_ --help: displays help prompt on how to use the command 