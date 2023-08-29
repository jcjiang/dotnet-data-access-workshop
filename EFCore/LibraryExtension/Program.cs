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

