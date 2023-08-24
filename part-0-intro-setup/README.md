# Part 0 - Intro to data access in .NET & Setup

Data access is at the core of all data work. At a high level, it includes getting data from a source (such as a database), modifying the data, and using that data somewhere else (such as a mobile or web application.) Data access can be as simple as storing information from an application or as complex as managing and maintaining a massive database with hundreds of thousands of relationships.

The .NET ecosystem has a lot of options for developers looking to work with data. Our tooling comes with longterm support and integrate seamlessly within the platform, as well as with other Microsoft offerings like Azure.

## Frequently Asked Questions (FAQ)

Does using .NET (C#) mean I can only work with Microsoft tech?

- .NET works with all major database management systems, from SQLite to Oracle. In addition, it is open source and has a thriving community beyond Microsoft with a long history of contributing to the platform. For example, StackOverflow writes its data access layer in C# and maintains ![Dapper](https://github.com/DapperLib/Dapper), one of the most popular tools for data access in .NET.

Do I have to be a C# developer in order to start working with data using .NET?

- Knowledge of C# will definitely help you out, but there are ways to get started with little to no code and learn by building. .NET tools like EF Core let you choose how much to abstract, so you can scale up your knowledge only when you need it as opposed to learning everything just to get started.

What are some examples of what I can build with a .NET data access layer?

- 