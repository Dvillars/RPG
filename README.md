# Role Playing Game

#### _Role Playing Game built with .NET Core using Identity authentication_

#### By _**Alexandra Holcombe && Derek Villars**_

***

## Planning
### **1.  Configuration/Dependencies**  
  * .NET Core
  * Entity Framework
  * Identity Authorization Framework

### **2.  Specs**  

  * A user can create an account.
  * A user can edit their account
  * A user can delete their account.
  * A user can upload an avatar.
  * A user can change an avatar.
  * A user can delete an avatar.
  * A user can add items to their inventory.
  * A user can edit their inventory.
  * A user can delete items in their inventory.
  * A user can visit locations.

### **3.  Integration**  

 **Models**  
  * user (with an avatar, total hp, current hp, strength, defense)
  * inventory (list of items, can contain items or gear)
  * item (name, attribute to affect, strength of effect)
  * gear (name, attribute to affect, strength of effect, type)
  * location (name, attribute to affect, strength of effect)
  * enemy (name, total hp, current hp, strength, defense)

  **Roles**
  * Admin
    > CRUD locations
    > CRUD items
    > CRUD foes

  **Views**
  * Homepage/login
  * Account management/profile
  * Location View
  * Combat View

### **4.  UX/UI**  
  * Uses SCSS & Bootstrap

### **5.  Icebox**
  * Multiple Avatars
  * Items w/multiple attributes
  * Location types
  * Email verification

### **6.  Polish**  
  * See if refactoring is needed
  * Delete unused code
  * Revisit README
  * Clone project from github to ensure works correctly!!

***

## Installation

### Requirements
* Microsoft .NET Core Tools (Preview 2)
* (If using Visual Studio) Visual Studio 2015 Update 3

[Microsoft .NET Core 1.0.0 Release Notes](https://github.com/dotnet/core/blob/master/release-notes/1.0/1.0.0.md)  
[Release Announcement](https://blogs.msdn.microsoft.com/dotnet/2016/06/27/announcing-net-core-1-0/)

### To Build Database
In command line:  
    `> dotnet ef database update`


## Technologies Used
* C#
* Visual Studio 2015 Update 3
* Entity Framework 1.0.0 Preview 2
* .NET Core 1.0.0 Preview 2 003131
* Microsoft SQL Server Management Studio
* Styling inspired by [this template](https://www.templatemonster.com/demo/50982.html)

## Support and contact details
Please contact Allie Holcombe at alexandra.holcombe@gmail.com or Derek Villars at derekvillars@yahoo.com with any questions, concerns, or suggestions

### License

*This project is licensed under the MIT license.*

Copyright (c) 2017 **_Alexandra Holcombe && Derek Villars_**
