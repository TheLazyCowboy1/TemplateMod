# TemplateMod

Intended for my own use, but hopefully the EasyModSetup folder contains classes that might be extremely helpful to others as well!
This is especially designed to make soft-compatibility with Rain Meadow painless.

### SimplerPlugin
Makes setting up a plugin require a few less lines of code, and it provides a handy debug log method that was inspired by Rain Meadow's debug log.
The logger includes the time, the file, and the line that produced the log.

### AutoConfigOptions
Since I hate making config menus, this allows me to add configs in a matter of seconds. They might not be beautiful, but they're functional.
I find this especially desireable when I want to tune a setting in-game without having to recompile each time.

### EasyExtEnum
Provides an EasyExtEnum attribute that will automatically register ExtEnums for you.
Additionally, it will read all public static ExtEnums when the plugin initializes, so you don't have to worry about them being registered at different times.

Since I'm too Lazy to declare my ExtEnums properly, why not just make a ton of Reflection do it for me?

### MeadowExt
Just a place to interface with Rain Meadow in a soft-compatible manner. The IsOnline method is especially useful.

### AutoSync
An extremely easy way to sync static variables in Rain Meadow! Just add the AutoSync attribute and it'll be synced between all players.
The originally-intended use-case was for syncing my config options. All clients copy the host's options that are marked to be synced.

(Yes, I spent 5 hours writing Expression trees to slightly optimize this feature designed to save me from one minute of copy/pasting. Am I Lazy or just foolish?)


## Rain Meadow Data

### EasyResourceState and EasyEntityState
Makes attaching data to resources and entities as easy as possible.
See [StaticVarSyncData](EasyModSetup/MeadowCompat/StaticVarSyncData.cs) as an example for EasyResourceState,
and [PlayerInfoSyncState](https://github.com/TheLazyCowboy1/MetroidvaniaMode/blob/Dragons/PlayerInfoSyncState.cs) (external link) as an example for EasyEntityState.


If the AttachTo method returns true, then the data will automatically be added to the resource/entity when it is created (or roughly around that time).

Instructions:
Use the AttachTo method to specify whether to add the data to a resource/entity.
Create a class that extends EasyResourceState. In it, declare some fields with the OnlineField attribute.
Assign values to these fields in WriteTo and read their values in ReadTo.
Profit?

### MeadowExtCompat
For soft-compatibility, it is *easiest* (not always necessary) to keep all files that include "using RainMeadow;" separate from everything else.
This file is where I actually reference Rain Meadow, and the functions here are only to be called by MeadowExt, which first checks whether Meadow is enabled.
There may be better ways to implement soft-compatibility, but I found this the most reliable and straightforward.



### Miscellaneous other features

### SimpleSaveData
A tool I made for organizing save data. You'll have to change the PREFIX constant if you use it.
I'm just including it in this repo so that I don't forget about it in the future.