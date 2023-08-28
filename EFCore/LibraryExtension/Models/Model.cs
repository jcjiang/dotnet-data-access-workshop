using Microsoft.EntityFrameworkCore;

public class LibraryContext : DbContext
{
    public DbSet<Book> books { get; set; }
    public DbSet<Author> authors { get; set; }

    // The following configures EF to use a locally hosted postgres database
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=dabworkshop");
        // simple logging to console
        // optionsBuilder.LogTo(Console.WriteLine);
        // logging to console with log level
        optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
    }
}

public class Book
{
    public int id { get; set; }
    public string title { get; set; }

    public List<Author> Authors { get; } = new();
}

public class Author
{
    public int id { get; set; }
    public string first_name { get; set; }
    public string? middle_name { get; set; }
    public string last_name { get; set; }

    public List<Book> Books { get; } = new();
}
