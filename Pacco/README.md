![Pacco](https://raw.githubusercontent.com/devmentors/Pacco/master/assets/pacco_logo.png)

**What is Pacco?**
----------------

Pacco is an open source project using **microservices architecture** written in .NET Core 3.1. The domain tackles an exclusive parcels delivery which revolves around the general concept of limited resources availability. Pacco does use an **event-driven** approach in order to asynchronously integrate between the microservices.

![Pacco overview](https://raw.githubusercontent.com/devmentors/Pacco/master/assets/pacco_overview.png)
 
**How to start the solution?**
----------------

Open `Pacco/compose` directory and execute:

```
docker compose -f .\infrastructure.yml up -d
```

It will start the required infrastructure in the background. Then, you can start the services independently of each other via `dotnet run` or `./scripts/start.sh` command in each microservice repository or run them all at once using Docker:

```
docker compose -f .\services-local.yml up
```

**What HTTP requests can be sent to the API?**
----------------

You can find the list of all HTTP requests in [Pacco-sample-scenario.rest](https://github.com/devmentors/Pacco.APIGateway/blob/master/Pacco-sample-scenario.rest) file placed in the root folder of [Pacco.APIGateway](https://github.com/devmentors/Pacco.APIGateway) repository. 
This file is compatible with [REST Client](https://marketplace.visualstudio.com/items?itemName=humao.rest-client) plugin for [Visual Studio Code](https://code.visualstudio.com). 

**Mongo Client

Robo3T is a great place to start
https://robomongo.org/

connection: localhost:27017

**RabbitMQ

http://localhost:15672/
guest - guest
