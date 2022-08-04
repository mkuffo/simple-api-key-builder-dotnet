# Simple .NET Core C# API Key Builder

## Overview

This is an example on how to create a .NET Core server that generates an API Key for developers using C# on a macOS. Please do not save any api key in plain text into the the database. Use best practices to save sensitive data and password into a database.
 
## Pre Requisites
* Visual Studio for Mac.
* .Net Core for macOS
* Postman
* Git

## Installation

```
git clone https://github.com/mkuffo/simple-api-key-builder-dotnet.git
```
```
cd simple-api-key-builder-dotnet
```
```
dotnet run
```

Also, you can open visual studio and run the project.

## Test Server
You can use postman to check the server api
```
Method: POST
URL: https://localhost:5001/api/developer/request-api-key?companyName=Tacos
```


## Security

IMPORTANT: Please do not save the api key in plain text into any database. 

## Reference

Please refer to the full article for more information. [Link](https://medium.com/@mkuffo/net-core-on-a-mac-lets-build-an-api-server-that-generates-api-keys-using-c-9067e6be084d).







