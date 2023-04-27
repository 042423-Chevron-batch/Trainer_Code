# PowerShell

## What is PowerShell?
PowerShell is a _cross platform_ task automation and configuration tool from Microsoft. It is optimized for dealing with structured data (such as JSON, XML, CSV, etc), REST APIs, and object models. It includes a CLI Shell, an associated scripting language, and a framework for processing cmdlets ("commandlets")

Powershell file extension is .ps1

### Cmdlet?
Cmdlet (pronounced 'commandlets') are commands in powershell, they consist of two parts: a verb and a noun. EX: Get-ChildItem, Get-Help, etc.

### What makes Powershell special?
Unlike bash or other shell, Powershell operates on the runtime of .NET Platform, called Common Language Runtime. This leads to a few cool characteristics of the tool:
	- Uniform performance across different systems
	- Powershell works with .NET Objects (it's OOP!) instead of plain strings

## Three Cmdlets to Get Started
- `Get-Help`
	- AKA `man` command or `--help` flag in bash
- `Get-Command`
	- command search tool
- `Get-Member`
	- Gets all members of the object
	- example usage:
		- `Get-Command | Get-Member`

## Bash to PowerShell
- cd : Set-Location
- ls: Get-ChildItem
- echo: Write-Output
- pwd: Get-Location
- touch (to create new file): New-Item
- mkdir : New-Item -ItemType directory
- rm: Remove-Item (works for both files and folders)
- cat : Get-Content
- cp: Copy-Item
- mv: Move-Item
- *note*: Many of these command offer shorthands and they are in fact the same as their equivalent bash commands. Try them out!

### If/ElseIf/Else
- [MSLearn](https://learn.microsoft.com/en-us/powershell/scripting/learn/deep-dives/everything-about-if?view=powershell-7.3)

### Loops
- [MSLearn](https://learn.microsoft.com/en-us/powershell/scripting/learn/ps101/06-flow-control?view=powershell-7.3)

### PowerShell Cheat Sheet
- https://virtualizationreview.com/articles/2020/07/27/bash-powershell-cheat-sheet.aspx
- https://www.comparitech.com/net-admin/powershell-cheat-sheet/

## Exercise
Take your grade calculator bash file and turn that into powershell!
