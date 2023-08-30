# Part 3 - Query and manage your data with EF Core

Before you start this section, you should have completed [Part 2](/part-2-efcore/README.md) and have a database that contains data. Now, you will learn how to query and manage that data. 

With the language-integrated query (LINQ) capabilities offered by EF Core, you can work with data with C# code like it is any other object. Here is an example of what you can do with LINQ.

```csharp

using (var context = new LibraryContext())
{
    var books = context.Books
        .Where(b => b.Title.Contains("dotnet"))
        .ToList();
}

```

Let's walk through this code together. This code filters for all books with a title containing "dotnet". `context` is the DbContext instance for this unit of work, which contains the `DbSet<Book> books`that we defined earlier in our `Model.cs` file. We then write code to search through the set and output the results to a list.

## Program.cs

Our application will live in the `Program.cs` file.

### Import the DbContext

Include the following line of code at the top of your file.

```csharp
await using var db = new LibraryContext();
```

We use the constructor that we defined in the `Model.cs` file to instantiate a new `LibraryContext` named `db`. From now on, `db` will represent our current database working session.

### Create

Now that we have our database imported, we will insert data into it.

```csharp
// Create
Console.WriteLine("Inserting a new book");
db.Add(new Book { title = "" });
db.SaveChanges();
```

This code writes to the console, adds a new data entity under the `Book` class, and then saves the changes made to the database.

### Read

Now, we will read the data inside of our database.

```csharp
// Read
Console.WriteLine("Querying for a book");
var book = db.books
    .OrderBy(b => b.id)
    .First();
```

This code writes to the console, grabs the `DbSet` named `db.books` (which contains all the `Book` entities from the database), and works with the contents. Specifically, we order the set by the `id` field of each book and set the first one to the variable `book`.

### Update

Next, we will change some data already in the database.

```csharp
// Update
Console.WriteLine("Updating the book and adding an author with a relation to the book");
book.title = "https://devblogs.microsoft.com/dotnet";
book.Authors.Add(
    new Author { first_name = "", middle_name = "", last_name = "", Books = {book}};
db.SaveChanges();
```
This code writes to the console, changes the `title` field of the `book` variable defined above, and then adds a new `Author` to the list of `Author` entities that it has a relationship with. Finally, we save the changes we made to the database.

### Delete

Finally, we will delete data from our database.

```csharp
// Delete
Console.WriteLine("Delete the book");
db.Remove(book);
db.SaveChanges();
```

This code writes to the console, removes the `book` entity that we have been working with from the database, and save the changes we made to the database.

## Running your application

By now, your `Program.cs` file should look something like this:

```csharp
await using var db = new LibraryContext();

// Create
Console.WriteLine("Inserting a new book");
db.Add(new Book { title = "" });
db.SaveChanges();

// Read
Console.WriteLine("Querying for a book");
var book = db.books
    .OrderBy(b => b.id)
    .First();

// Update
Console.WriteLine("Updating the book and adding an author with a relation to the book");
book.title = "Intro to .NET";
book.Authors.Add(
    new Author { first_name = "Jane", middle_name = "P.", last_name = "Doe", Books = { book } };
db.SaveChanges();

// Delete
Console.WriteLine("Delete the book");
db.Remove(book);
db.SaveChanges();

```

Now that you've written all the code, let's see what your data access layer looks like in action!

```dotnetcli
dotnet run
```

Because we turned on logging during configuration earlier, you should see a wall of text output from your console. You can get a sense of how much work EF Core does for you that you would otherwise have to handle manually if you were using a less high-level tool.

Here are a few examples:

```dotnetcli
dbug: 8/30/2023 11:49:56.467 RelationalEventId.CommandExecuting[20100] (Microsoft.EntityFrameworkCore.Database.Command)
      Executing DbCommand [Parameters=[], CommandType='Text', CommandTimeout='30']
      SELECT a.id, a.first_name, a.last_name, a.middle_name
      FROM authors AS a
```

This is the SQL query that was generated from the C# code you wrote earlier.

```dotnetcli
dbug: 8/30/2023 11:49:56.341 CoreEventId.StartedTracking[10806] (Microsoft.EntityFrameworkCore.ChangeTracking)
      Context 'BloggingContext' started tracking 'Book' entity. Consider using 'DbContextOptionsBuilder.EnableSensitiveDataLogging' to see key values.
```

One of the most useful features of EF Core is its change tracking capabilities. EF Core keeps track of how you work with your entities, including whether they have been added, modified, or deleted. This can be useful when the database is being worked with from different sources.

## Next Steps

Now that you have created a data access layer in EF Core, you have a lot of options for how to build on your knowledge.

- You can [build a website application](https://learn.microsoft.com/en-us/aspnet/core/data/ef-rp/intro?view=aspnetcore-7.0&tabs=visual-studio) that uses your API using Razor Pages in ASP.NET Core.
- You can [build a mobile application](https://learn.microsoft.com/en-us/ef/core/get-started/xamarin) using .NET MAUI (formerly known as Xamarin.)
