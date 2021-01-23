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

This application will allow the user to enter call data on National Parks from a backend API equipped with Swagger Documentation, CORS and Versioning. It will be backend only, but may become a full fledged site should time permit.

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

  # AppSettings

  1) Create a new file in the CoffeeTrackerAPI.Solution/CoffeeTrackerAPI directory named `appsettings.json`
  2) Add in the following code snippet to the new appsettings.json file:
  
  `
{
    "Logging": {
        "LogLevel": {
        "Default": "Warning"
        }
    },
    "AllowedHosts": "*",
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=coffee_tracker_api;uid=root;pwd=YourPassword;"
    }
}
  `
  3) Change the server, port, and user id as necessary. Replace 'YourPassword' with relevant MySQL password (set at installation of MySQL).

* Update the Server, Port, and User ID as needed.

Import Database using Entity Framework Core
* Type `dotnet ef database update` into the terminal to create your database tables.

## 🛰️ API Documentation
Explore the API endpoints in Postman or a browser. You will not be able to utilize authentication in a browser.

### Note on CORS
CORS is a W3C standard that allows a server to relax the same-origin policy. It is not a security feature, CORS relaxes security. It allows a server to explicitly allow some cross-origin requests while rejecting others. An API is not safer by allowing CORS.
For more information or to see how CORS functions, see the [Microsoft documentation](https://docs.microsoft.com/en-us/aspnet/core/security/cors?view=aspnetcore-2.2#how-cors).

### Using Swagger Documentation 
To explore the CoffeeTracker API with NSwag, launch the project using `dotnet run` with the Terminal or Powershell, and input the following URL into your browser: `http://localhost:5000/swagger`

### Endpoints
Base URL: `https://localhost:5000`

#### HTTP Request Structure
```
GET /api/{component}
POST /api/{component}
GET /api/{component}/{id}
PUT /api/{component}/{id}
DELETE /api/{component}/{id}
```

#### Example Query
```
https://localhost:5000/api/park/3
```

#### Sample JSON Response
```
{
    "ParkId": 3,
    "ParkName": "Crater Lake National Park",
    "ParkLocation": "Southern Oregon, USA",
    "Description": "A massive lake that lies in the remnants of the ancient volcano Mazama. The ninth deepest lake in the world..",
}
```

### Parks
Access information on state and national parks.

#### HTTP Request
```
GET /api/park
POST /api/park
GET /api/park/{id}
PUT /api/park/{id}
DELETE /api/park/{id}
```

#### Path Parameters
| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| ParkName | string | none | false | Return matches by name.
| ParkLocation | string | none | false | Return any park from a specific location. |
| ParkId | int | none | false | Return park matches with a specific ID. |
| Description | string | none | false | Return matches by description text... Not recommended as you have to type the whole chunk of text from the data, but included for good measure. |

#### Example Query
```
https://localhost:5000/api/park/?parkname=fortwordenstatepark&location=porttownsendwashington
```

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
* Swashbuckle
* Swagger
* Nuget Versioning
* MySql
* MySql Workbench
* CORS

</details>

# ©️ License & Copyright

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Copyright (c) 2021 **_Garrett Brown_**