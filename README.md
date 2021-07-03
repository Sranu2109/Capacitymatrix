# A User Interface for handling Capacity Matrix of TATA STEEL.
#### A web based project on "User Interface for Master Data Maintenance"

[![GitHub code size in bytes](https://img.shields.io/github/languages/code-size/Sranu2109/Capacitymatrix.svg?logo=git&style=social)](https://Sranu2109.github.io/Capacitymatrix/) [![GitHub license](https://img.shields.io/github/license/Sranu2109/Capacitymatrix.svg?style=social&logo=github)](https://github.com/Sranu2109/Capacitymatrix/blob/master/LICENSE)

## Abstract

![User Interface for TATA STEEL](https://img.shields.io/badge/Capacity--Matrx-System-orange.svg?style=flat-square) 
![DBMS Project](https://img.shields.io/badge/DBMS-project-yellowgreen.svg?style=flat-square)
![Open Source Programming](https://img.shields.io/badge/open--source-programming-ff69b4.svg?style=flat-square)

For different plants inside the **TATA STEEL** company, we have different plant codes for each. Also an individual plant has different process codes like HM, CPL, DS. For a particular year week each plant will produce certain quantity of material ordered by the industry in tons. But the plant also has it's own capacity to produce in a particular year week. ATP will give us the difference between the plant_capacity and ordered_quantity. To record this,  **User Interface for Master Data Maintenance**  has been developed.

[![Video](https://img.shields.io/static/v1.svg?label=Project&message=Video&logo=google-drive&style=social)]( https://drive.google.com/file/d/1xhptht9vZm3W0ccQUUc8aFYebWO_oJyY/view?usp=sharing)

> **You can download the working video [here]( https://drive.google.com/file/d/1xhptht9vZm3W0ccQUUc8aFYebWO_oJyY/view?usp=sharing).**

> **You can check the screenshots of User Interface [here](https://github.com/Sranu2109/Capacitymatrix/tree/master/screenshots).**

## Core Features

![User](https://img.shields.io/badge/User-login-teal.svg?style=flat-square) 
![Dashboard](https://img.shields.io/badge/Dashboard-yellowgreen.svg?style=flat-square)
![Capacity](https://img.shields.io/badge/Capacity-Matrix-ff69b4.svg?style=flat-square)
![Data](https://img.shields.io/badge/Data-Table-dodgerblue.svg?style=flat-square) 
![Edit](https://img.shields.io/badge/Edit-Data-orange.svg?style=flat-square) 

- **User Login** will have username and password(in hidden format) of 8-digits.
- **Dashboard** will contain master data management.
- Under master data management we'll have **Capacity Matrix**.
- **Capacity Matrix** will have fields like plant code, process code, year week from-to.
- Display button will show us the entire **Data Table**.
- On clicking each field of the data table we can have **Edit Table** option.

## Additional Features

- If login credentials are wrong then an error popup will appear.

- **Dashboard** will contain a logout field.

- In **Capacity matrix** plant code and process code will be the necessary fields.

- Display will show the **Data Table** containing attributes:- Plant_code, Process_code, Year_week, Plant_capacity, Order_quantity, ATP.

- You can only edit two fields:- Year_week and Plant_capacity.

## Technology Stack Used

![Bootstrap](https://img.shields.io/badge/Frontend-Bootstrap-orange.svg?logo=bootstrap&logoColor=orange&style=flat-square) 
![MySql](https://img.shields.io/badge/Database-Mysql-yellowgreen.svg?logo=mysql&logoColor=yellowgreen&style=flat-square)
![C-sharp](https://img.shields.io/badge/backend-Csharp-blue.svg?logo=Csharp&logoColor=blue&style=flat-square) 

- Front End - **Bootstrap**
- Back End - **C#**
- Database - **MySql**

## Requirements

[![C#](https://img.shields.io/static/v1.svg?label=Source%20Code&message=Csharp&logo=Csharp&style=social)](https://Sranu2109.github.io/Capacitymatrix/)

The source code of this project is written in **C#**. So, you'll require **Windows .NET framework** to run this project.

## Installing

[![.NET Framework](https://img.shields.io/badge/.NET-Framework-red.svg?style=flat-square)](https://dotnet.microsoft.com/download/dotnet-framework) [![Visual Studio](https://img.shields.io/badge/Visual-Studio-blue.svg?style=flat-square)](https://visualstudio.microsoft.com/) [![Mysql](https://img.shields.io/badge/Mysql-lightgrey.svg?style=flat-square)](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver15)

- Download [.NET Framework](https://dotnet.microsoft.com/download/dotnet-framework)
- Download [Visual Studio](https://visualstudio.microsoft.com/)
- Download [Microsoft SQL Server Management Studio](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver15)

## How to run?

1. Download this repo and extract **[WebProject.zip](https://github.com/Sranu2109/Capacitymatrix/blob/master/WebProject.zip)** file in your system. 
2. Import the [database] from **WebProject.zip** folder. 
3. Make **Sqlconnection** with the cs files. 
4. Run **`Capacitymatrix.sln`**

## Thanks!

I am extremely grateful for the practical hands-on experience along with the theoretical knowledge by the mentors in the web development summer internship at [tatasteel](https://www.tatasteel.com/) though being in the onset of global pandemic time.

<a href="https://www.linkedin.com/in/ranu-singh-792ba91b4"><img href="images5/linkedin.png" width="32px" height="32px"></a> <a href="https://github.com/Sranu2109"><img href="images5/github.png" width="32px" height="32px"></a> <a href=""><img href="images5/twitter.png" width="32px" height="32px"></a>
