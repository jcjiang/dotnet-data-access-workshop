using Microsoft.EntityFrameworkCore; //download Microsoft.EntityFrameworkCore.SqlServer

await using var db = new LibraryContext();

// Read
Console.WriteLine("Querying");

var book_results =
    from book in await db.books.ToListAsync()
    where book.id == 1016
    select book;

var author_results =
    from author in await db.authors.ToListAsync()
    where author.id == 500
    select author;

if (book_results.Count() == 0)
{
    Console.WriteLine("No results found for this book ID.");
    return;
}
else
{
    foreach (var s in book_results)
    {
        Console.WriteLine("Book found: id: " + s.id + "    Book title: " + s.title);
    }
}

if (author_results.Count() == 0)
{
    Console.WriteLine("No results found for this author ID.");
    return;
}
else
{
    foreach (var s in author_results)
    {
        var name = "";
        if (s.middle_name == null)
        {
            name = s.first_name + " " + s.last_name;
        }
        else
        {
            name = s.first_name + " " + s.middle_name + " " + s.last_name;
        }

        Console.WriteLine("Author found: id: " + s.id + "    Author name: " + name);
    }
}

// Write
Console.WriteLine("Inserting data");

db.books.Add(new Book { id = 500, title = "Using Npgsql with Entity Framework Core" });

db.authors.Add(new Author { id = 500, first_name = "John", middle_name = "Anonymous", last_name = "Smith" });

// Update
await db.SaveChangesAsync();

