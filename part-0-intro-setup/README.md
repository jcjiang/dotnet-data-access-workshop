# Part 0 - Intro to data access in .NET

Data access is at the core of all data work. At a high level, it includes getting data from a source (such as a database), modifying the data, and using that data somewhere else (such as a mobile or web application.) Data access can be as simple as storing information from an application or as complex as managing and maintaining a massive database with hundreds of thousands of relationships.

The .NET ecosystem has a lot of options for developers looking to work with data. Our tooling comes with longterm support and integrate seamlessly within the platform, as well as with other Microsoft offerings like Azure.

## Prerequisites

Before starting this tutorial, you should have a few things installed.

- PC or Mac
- [.NET 7](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
- IDE of your choice, such as [Visual Studio Code](https://code.visualstudio.com/) (optional, if you want to look through the code)

For Part 2, you will need:

- [Version 17.4 or newer of Visual Studio 2022 or Visual Studio for Mac 2022](https://visualstudio.microsoft.com/downloads/)
- [.NET SDK](https://dotnet.microsoft.com/en-us/download/visual-studio-sdks)

## Next Steps

If you would like to start with a no code approach to building a CRUD API, go to [Part 1](/part-1-dab/README.md). You will get to define and test your data model, which you can build off of with a more scalable DIY solution like EF Core.

If you would like to start with code and build a CRUD API that integrates with a console app, go to [Part 2](/part-2-efcore/).

## Frequently Asked Questions (FAQ)

### Does using .NET (C#) mean I can only work with Microsoft tech?

- .NET works with all major database management systems, even non-Microsoft options like SQLite and Oracle. In addition, it is open source and has a thriving community beyond Microsoft with a long history of contributing to and investing in the platform. For example, StackOverflow writes its data access layer in C# and built/maintains [Dapper](https://github.com/DapperLib/Dapper), one of the most popular tools for data access in .NET.

### Do I have to be a C# developer in order to start working with data using .NET?

- Knowledge of C# will definitely be helpful, but there are ways to get started with little to no code and learn the language by building with it. .NET tools like EF Core let you choose how much to abstract so instead of learning everything just to get started, you can scale up your knowledge only when you need it.

### What are some examples of what can be built with a .NET data access layer?

- [Geocaching](https://www.youtube.com/watch?v=xKnW6llLyig) supports millions of users across the globe, as well as a mobile app with multiple websites, with a back-end built entirely on .NET APIs.

> “It’s reliable. It does what I want It to do. It’s secure. Everybody knows how to use it. It performs. It’s my favorite platform.”

- [Chipotle](https://customers.microsoft.com/en-us/story/787157-chipotle-retailers-azure) uses C# for the back-end of its customer-facing website due to its efficiency and consistency.

> “Instead of spending a lot of time debating theories and approaches with no prior experience to rely on, we had a working demo ready to drive decision making in minutes."

- [The Postage]() is a startup that uses C# for full-stack web development so that the same developers can build every part of the product.

> ".NET let us use C# across the entire application stack, from front end to back end to mobile — an approach that has proven to be very effective in terms of both speed and cost."
