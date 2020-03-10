# _Parcel Delivery Service_

#### _ASP.NET Core MVC practice for Epicodus_, _Mar. 10, 2020_

#### By _**Patrick Kille, Michelle Morin**_

## Description

_This project includes a form where a user can enter dimensions and weight of a package to ship, and then receive more information about shipping their package (price, volume) when they submit the form._ 

## Specifications:

| Specification | Example Input | Example Output |
| ------------- |:-------------:| -------------:| 
| Application creates instance of parcel object when user submits form | user enters height, length, width, and weight of parcel then submits form| new parcel object created |
| Application determines price of parcel | user submits form | Application navigates to different view that displays price |
| Application determines volume of parcel | user submits form | Application navigates to different view that displays parcel volume |

## Setup/Installation Requirements

### Install .NET Core

#### on macOS:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download a .NET Core SDK from Microsoft Corp._
* _Open the file (this will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.)_

#### on Windows:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp._
* _Open the .exe file and follow the steps provided by the installer for your OS._

#### Install dotnet script
_Enter the command ``dotnet tool install -g dotnet-script`` in Terminal (macOS) or PowerShell (Windows)._

### Clone this repository

_Enter the following commands in Terminal (macOS) or PowerShell (Windows):_
* ``cd desktop``
* ``git clone`` followed by the URL to this repository.
* ``cd ParcelDelivery.Solution``

_Confirm that you have navigated to the ParcelDelivery.Solution directory (e.g., by entering the command_ ``pwd`` _in Terminal)._

_To view/edit the source code of this application, open the contents of the ParcelDelivery.Solution directory in a text editor or IDE of your choice (e.g., to open all contents of the directory in Visual Studio Code on macOS, enter the command_ ``code .`` _in Terminal)._

_Run this console application by entering the following commands in Terminal (macOS) or PowerShell (Windows):_
* ``cd ParcelDelivery`
* ``dotnet run``

## Technologies Used
* _Git_
* _C#_
* _ASP.NET Core MVC_
* _dotnet script_

### License

*This webpage is licensed under the MIT license.*

Copyright (c) 2020 **_Patrick Kille, Michelle Morin_**