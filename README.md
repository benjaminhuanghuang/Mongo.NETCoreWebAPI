# MongoDB and .NET core Web API
Reference:
    Dotnet Core - MongoDb - A simple Web API


## Overview
* Controller -> Service -> Model    


## How to
* Add MongoDB.Driver v2.3.0 to project.json
* Add model
* Add servcie
* Add Controller


## How to test
* GET
    Content-Type : application/json
    localhost:5000/api/todos
    
* POST
    Content-Type : application/json   // Set it in postman or other client application
    localhost:5000/api/todos
    {"title":"aa", }