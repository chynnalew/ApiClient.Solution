<div align="center">

[![Language][language-shield]][language-url]
[![Language][languageH-shield]][languageH-url]
[![Language][languageC-shield]][languageC-url]
[![Language][languageS-shield]][languageS-url]
[![MIT License][license-shield]][license-url]

# Book Client MVC


#### an Epicodus project that allows the user to create, update and delete books from a local API using MySQL.

#### Created By: Chynna Lew and Paige Tiedeman
</div>

## Technologies Used

* C#
* .NET 5
* NuGet
* ASP.NET Core
* Entity Framework Core
* MySql
* MySql Workbench
* PostMan
* SCSS
* Bootstrap
* CSS
* Live Sass Compiler Extension
* jQuery
* JavaScript

## Description

This application was created to show proficiency in ASP.Net Core MVC API creation and access using mySql, Entity, and Razor. This app allows the user full CRUD functionality for their own reviews and search functionality for all reviews in the API.

## Setup and Usage Instructions

### Technology Requirements

* Download and install [.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0)
* Download and install a code text editor. Ex: [VS Code](https://code.visualstudio.com/)
* Download, install, and complete setup for [MySql Community Server](https://dev.mysql.com/downloads/file/?id=484914) and [MySql Workbench](https://dev.mysql.com/downloads/file/?id=484391).

### Installation

* Download and run [this](https://github.com/chynnalew/Travel.Solution) API, following the instructions in the API README.md
  -This application REQUIRES the api to be running during use
* Clone [this](https://github.com/chynnalew/TravelClient.Solution) repository, or download and open the Zip on your local machine
* Open the TravelClient.Solution folder in your preferred text editor
* To install required packages, navigate to TravelClient.Solution/TravelClient in the terminal and type the following commands:
  - dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0
  - dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2
  - dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0
  - dotnet tool install --global dotnet-ef --version 3.0.0

* To Restore, build, and launch the project:
  - Navigate to the TravelClient.Solution/TravelClient folder in the command line or terminal
    - Run the command `$ dotnet restore` to restore the project dependencies
    - Run the command `$ dotnet build` to build and compile the project
    - Run the command `$ dotnet run` to build and compile the project
    - The ASP.NET Core MVC is viewable in the browser at http://localhost:5000 
    - If the styling is not appearing in the browser, open http://localhost:5000 in an incognito browser or clear your browser cache

## Review Endpoints

Base URL: `http://localhost:5004`


## Known Bugs

* none at this time

### License

[MIT License](https://opensource.org/licenses/MIT)
Copyright 2021 Chynna Lew, Paige Tiedeman

## Support and contact details

* [Chynna Lew](github.com/chynnalew) <ChynnaLew@yahoo.com>
* [Paige Tiedeman](github.com/paigetiedeman)  


[license-shield]: https://img.shields.io/badge/License-MIT-blue
[license-url]: https://opensource.org/licenses/MIT
[language-shield]: https://img.shields.io/badge/Language-C%23-green
[language-url]: https://docs.microsoft.com/en-us/dotnet/csharp/
[LanguageH-shield]: https://img.shields.io/badge/Language-HTML-red
[LanguageH-url]: https://developer.mozilla.org/en-US/docs/Web/HTML
[LanguageC-shield]: https://img.shields.io/badge/Language-CSS-blueviolet
[LanguageC-url]: https://developer.mozilla.org/en-US/docs/Web/CSS
[LanguageS-shield]: https://img.shields.io/badge/Language-SCSS-ff69b4
[LanguageS-url]: https://sass-lang.com/documentation