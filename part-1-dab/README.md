# Part 1 - Build a simple CRUD API with the Data API Builder CLI (no code!)

## What is Data API Builder (DAB)?

[Data API Builder](https://devblogs.microsoft.com/cosmosdb/announcing-data-api-builder-for-azure-cosmos-db/) is a .command-line tool written with .NET that lets you securely build simple CRUD APIs without writing code.

It works by generating a configuration file with information about the data model, including classes and their relationships, which the CLI then uses to build the API.

### Benefits of DAB

- DAB supports many different SQL and NoSQL databases including Azure SQL, SQL Server, PostgreSQL, Azure Cosmos DB, and MySQL.
- Database objects can be exposed with REST or GraphQL endpoints so they can be accessed on any platform, language, and device.
- DAB lets you define and test out your data classes and relationships without having to write any code.

DAB does have its limitations. For example, it cannot be extended beyond Create, Read, Update, and Delete functionalities. It also does not allow for manipulation of the received query results. 

In this workshop, we first create our API with DAB in order to visualize and test our data classes and relationships before we implement them in code. We then build our API with EF Core for a data access layer that is more scalable, extensible, and powerful. This approach also allows for easier debugging, logging, and testing.

If you are comfortable with code and want to build your API with EF Core to start, you can skip this section and go directly to [Part 2](part-2-efcore/README.md).  

### GraphQL vs. REST

DAB supports both GraphQL and REST endpoints. REST uses a set of endpoints that responds to specific HTTP requests, while GraphQL uses a single endpoint to respond to queries. GraphQL is generally more efficient and flexible than REST, and is supported by Entity Framework Core.

For the purpose of this tutorial, we will be setting up GraphQL endpoints.

### Choosing a database

DAB supports a number of databases across local and cloud scenarios. For the purpose of this tutorial, we will be using a PostgreSQL database that can be worked with locally and on the cloud.

The local PostgreSQL instance can be found at `library.postgresql.sql`.

## Setting up a local PostgreSQL database

[This tutorial](https://www.postgresql.org/docs/current/tutorial-createdb.html) will walk you through setting up a new local PostgreSQL database using `psql`.

Then, populate it with data using the following script: [library.postgresql.sql](/library.postgresql.sql)

## Use DAB to build a CRUD API

The remainder of this tutorial can be found on the [Getting Started](https://learn.microsoft.com/en-us/azure/data-api-builder/get-started/get-started-azure-postgresql) page for DAB. This will guide you through installation of DAB, populating your database, configuration, exposing your data, and adding create, read, update, and delete functionality to your API.

## Next Steps

At the completion of this tutorial, you should have a configuration file named `dab-config.json` that describes a data model with two classes, Author and Book, with many-to-one relationships between them - i.e. a book can have multiple authors and an author can have multiple books. You can find an example in this repository at [dab-config.json](/dab-config.json).

Now that we have tested and validated our data model, we will implement the API using a DIY, code solution with EF Core in [Part 2](../part-2-efcore/README.md).

If you want to keep building on your DAB API and see your data access layer in a published application, you can follow this tutorial on [how to build a Todo app with Azure Static Web Apps and Azure SQL Database](https://github.com/Azure-Samples/dab-swa-todo).
