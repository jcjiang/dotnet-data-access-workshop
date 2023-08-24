# Part 1 - Debug, log, and test your API with EF Core

## What is Entity Framework (EF) Core?

![Entity Framework Core](https://learn.microsoft.com/en-us/ef/) is a .NET tool that lets you build clean, portable, and high-level data access layers that work with a variety of databases and application types. EF Core lets you take the same intuitive approach to working with all data - no need to learn database-specific knowledge like SQL.

### Benefits of EF Core

- EF Core supports a huge range of SQL and NoSQL databases including SQL Database (on-premises and Azure), PostgreSQL, SQLite, MySQL, Azure Cosmos DB, and more! A full list of compatible data sources can be found ![here](https://learn.microsoft.com/en-us/ef/core/providers/?tabs=dotnet-core-cli).
- EF Core lets you work with databases intuitively by putting data in the form of objects, which are much easier to work with than raw output.
- Data access layers written using EF Core integrate seamlessly with any C# application, from console to mobile. You can also write multiple applications on top of the same back-end!
- EF Core offers important capabilities for application development (especially as you scale) like debugging, logging, testing, change tracking, and much more.

EF Core works great whether you have an existing database or need to create and populate a new database.

- To create and populate a new database, ![start here](#create-and-populate-a-new-database).
- If you want to work with an existing database and feel confident with code, consider ![using migrations](#generate-code-for-an-existing-database-with-migrations) to generate your data models quickly.
- If you want to want to work with an existing database but do not feel confident with code, consider ![defining your data models manually](#write-code-for-an-existing-database-manually).

### Create and populate a new database

### Generate code for an existing database with migrations

In this approach, we work with the PostgreSQL database from Part 1. Using the migrations feature of EF Core, we generate code based on the data already in the database. By the end of this section, 

### Write code for an existing database manually
