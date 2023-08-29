# Step 2c - Create and populate a new database (Code-first)

In this approach, we use the migrations feature of EF Core to make a new database by writing code that describes the contents (classes, tables, relationships.) Our code will be the source of truth, with the database updated to match any changes we make to our code.

First, we will define the data model classes and relationships of our database in our `Model.cs` file. EF Core will use this code to generate our database.

To get a deeper understanding of this code and what each part does, check out [Part 2b: Hand code your data model](/part-2-efcore/part-2b-handcode.md).

```csharp
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

public class BloggingContext : DbContext
{
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }

    public string DbPath { get; }

    public BloggingContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "blogging.db");
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}

public class Blog
{
    public int BlogId { get; set; }
    public string Url { get; set; }

    public List<Post> Posts { get; } = new();
}

public class Post
{
    public int PostId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }

    public int BlogId { get; set; }
    public Blog Blog { get; set; }
}
```

Now, we are ready to create and populate our database. Use the .NET CLI to run the following commands.

```dotnetcli

dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet ef migrations add InitialCreate
dotnet ef database update

```

These commands do the following:

- You install the tool and package you need to use migrations.
- You use a migration to create a set of tables that we can build on.
- You create a new database and populate it with those tables.

## Inspect your database

Let's take a look at what our database looks like.

## Next Steps

Now that your database has been created and populated, it is time to work with and manage your data! When you are ready to move on, check out [Part 3](/part-3-efcore-query-manage-data/README.md).