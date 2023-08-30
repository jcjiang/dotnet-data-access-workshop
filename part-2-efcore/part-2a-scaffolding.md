# Step 2a - Generate scaffolding for an existing database (Database-first)

In this approach, we work with the existing populated PostgreSQL database from [Part 1](/part-1-dab/README.md). We can generate code based on the data already in the database using just your connection string. EF Core will do all the work for us in terms of mapping data types to C# code.

Our database will be the source of truth, with the code changing to match any updates to the database.

## Inspect your database

Let's take a look at the contents of our database. This should be generated from the script in Part 1, a copy of which can be found [here]().

## Scaffold your models with .NET CLI

```dotnetcli

dotnet ef dbcontext scaffold "Data Source={ConnectionString}" Microsoft.EntityFrameworkCore.Npgsql --context-dir Data --output-dir Models

```

This command:

- Scaffolds DbContext and model classes based on your database by using the provided connection string.
- Specifies to use the Microsoft.EntityFrameworkCore.Npgsql database provider, as we are connecting to a PostgreSQL database.
- Defines the directories that our generated DbContext and model classes will live.

## Inspect your code

Let's take a look at the results of running that command. Open up the `Model.cs` file. It should look something ilke this:

```csharp

```
