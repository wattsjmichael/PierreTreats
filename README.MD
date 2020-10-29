# Sweet Treats 


👤 **Michael Watts**

* Twitter: [@michaelwatts13](https://twitter.com/michaelwatts13)
* Github: [@wattsjmichael](https://github.com/wattsjmichael)
* LinkedIn: [@wattsjimichael](https://linkedin.com/in/wattsjmichael)

## Description

Sweet Treats  is a C#/CSHTML Website that stores Treats and Flavors, and are able to edit, delete, create them if you are a logged in user.

## Setup/Installation Requirements

## Schema Set Up ##
* Type "dotnet ef migrations add Initial" in the terminal while in the SweetTreats Folder
* This will create a schema, double check MySql tables to make sure everything looks correct
* If everything is looking correct, type "dotnet ef database update" to finalize the database.




## Website Setup:
* Download or Clone project from Github repository.
* Open a terminal within SweetTreats folder within main project directory.
* Use Command, type in 'dotnet build'.
* After build, run the program with 'dotnet run' in the terminal.
* If you don't have it already, create a "appsettings.json" file in the "SweetTreats directory and Insert the code below with your user name and password for MySQL: 

> {
>  "ConnectionStrings": {
>      "DefaultConnection": "Server=localhost;Port=3306;database=michael_watts;uid={YOUR USERNAME};pwd={YOUR USERNAME}"
>  }
>}
## Known Bugs
None Known at the moment

## Support and contact details

Email me @ wattsjmichael@gmail.com

## Technologies Used

C#, LINQ, Entity Framework Core, MVC, MySql, CSHTML, CSS, Bootstrap, Identity and Markdown.

## Link To Active Site:
Not Applicable

### License

This software is licensed under the MIT license.

Copyright (c) 2020 **Michael Watts** - _Sweet Treats_