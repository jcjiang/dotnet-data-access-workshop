# Step 2a - Generate scaffolding for an existing database (Database-first)

In this approach, we work with the existing populated PostgreSQL database from [Part 1](/part-1-dab/README.md). We can generate code based on the data already in the database using just your connection string.

## Inspect your database

## Scaffold your models with .NET CLI

```dotnetcli

dotnet ef dbcontext scaffold "Data Source={ConnectionString}" Microsoft.EntityFrameworkCore.Npgsql --context-dir Data --output-dir Models

```

This command:

- Scaffolds DbContext and model classes based on your database by using the provided connection string.
- Specifies to use the Microsoft.EntityFrameworkCore.Npgsql database provider, as we are connecting to a PostgreSQL database.
- Defines the directories that our generated DbContext and model classes will live.
