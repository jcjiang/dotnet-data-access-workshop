# Part 3 - Query and manage your data with EF Core

Before you start this section, you should have completed [Part 2](/part-2-efcore/README.md) and have a database that contains data. Now, you will learn how to query and manage that data. 

With the language-integrated query (LINQ) capabilities offered by EF Core, you can work with data with C# code like it is any other object. Here is an example of what you can do with LINQ.

```csharp

using (var context = new BloggingContext())
{
    var blogs = context.Blogs
        .Where(b => b.Url.Contains("dotnet"))
        .ToList();
}

```

This code filters for all blogs with a URL containing "dotnet." `context` is the DbContext instance for this unit of work, which contains the `DbSet<Blog> Blogs`that we defined earlier in our `Model.cs` file. We then write code to search through the set and output the results to a list.

## Create 

First, we will insert data into our database.

```csharp
// Create
Console.WriteLine("Inserting a new book");
db.Add(new Book { Title = "" });
db.SaveChanges();
```

## Read

Now, we will read the data inside of our database.

```csharp
// Read
Console.WriteLine("Querying for a book");
var book = db.Books
    .OrderBy(b => b.id)
    .First();
```

## Update

Next, we will change some data already in the database.

```csharp
// Update
Console.WriteLine("Updating the book and adding an author with a relation to the book");
book.title = "https://devblogs.microsoft.com/dotnet";
book.Authors.Add(
    new Author { first_name = "", middle_name = "", last_name = "", Books = {book}};
db.SaveChanges();
```

## Delete

Finally, we will delete data from our database.

```csharp
// Delete
Console.WriteLine("Delete the book");
db.Remove(book);
db.SaveChanges();
```
