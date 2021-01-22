# _Travel Blog_

<p align="center">
    <br>
        <a href="https://github.com/GarrettBrown-dev">
        <img style="border-radius: 100%; height: 50px; width: auto" src="https://avatars1.githubusercontent.com/u/69095640?s=460&u=eefe493b85312d332eedc271ee24a39d586446ae&v=4">
    </a>
</p>

<p align="center">
  <small>Last Updated: January 22nd, 2021</small>
</p>

#### _Building an Api with Versioning, and/or Swagger._ 

# 🧑‍💻 Contributers

| Name | GitHub Profile |
|------|----------------|
|[Garrett Brown](https://www.linkedin.com/in/garrett-brown-d/) |[GarrettBrown-dev](https://github.com/GarrettBrown-dev) |

# ℹ️ Description

This application will allow the user to enter call data on National Parks from a backend API equipped with Swagger Documentation and Versioning. It will be backend only, but may become a full fledged site should time permit.

# 💾 Installation Requirements

Software Requirements
* An internet browser of your choice; I prefer Chrome
* A code editor; I prefer VSCode
* .NET Core
* MySQL
* MySQL Workbench

# 🖥️ Opening the Project on your Local System

Open by Downloading or Cloning
- [Click to view Github repository](https://github.com/GarrettBrown-dev/ParksAPI.Solution.git) Or simply paste the following url into your prefered browser https://github.com/GarrettBrown-dev/ParksAPI.Solution.git
- To Clone repository simply click the green Code button and copy the url.
- Using a preferred terminal(Such as GitBash) use the command `git clone paste-url-here` in which ever directory you wish.
- Open the newly cloned repo with your text editor, and open a terminal with GitBash.
- In the terminal run command `cd ParksAPI`
- In the terminal run command `dotnet restore`
- In the terminal run command `dotnet build`
- In the terminal run command `dotnet run`

AppSettings
* This project requires an AppSettings file. Create your `appsettings.json` file in the main `ParksAPI` directory. 
* Format your `appsettings.json` file as follows including your unique password that was created at MySqlWorkbench installation:
```
{
  "ConnectionStrings":{
      "DefaultConnection": "Server=localhost;Port=3306;database=travel;uid=root;pwd=<YourPassword>;"
  }
}
```

* Update the Server, Port, and User ID as needed.

Import Database using Entity Framework Core
* Type `dotnet ef database update` into the terminal to create your database tables.

# 🪲 Bugs / Issues

* None currently to note

# ☎️ Support / Contact Details

* Please feel free to reach out to <gman9mm@live.com>

# ⚙️ Technologies Used

<details>
  <summary>Expand Tech/tools</summary>

* [Bootstrap Components](https://getbootstrap.com/docs/3.3/components/)
* C#
* Razor
* Entity Framework Core
* Swagger
* Nuget Versioning
* MySql
* MySql Workbench

</details>

# ©️ License & Copyright

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Copyright (c) 2021 **_Garrett Brown_**