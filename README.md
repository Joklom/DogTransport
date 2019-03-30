# DogTransport

## How to run the application locally

In production the application makes use of environmental variables to obscure the AzureSQL connection string. In development on your local machine you will be using a disposible SQLite database so you will probably need to do a database migration before the application will run locally.

When you clone the repository, there should not be a `Migrations/` folder or a database (`app.db`) but you may end up with these files from previous work, or accidental addition to the repository. If you have these files locally you may not need to do a migration, but the database will probably get cluttered fast and need to be deleted.

You can pretty much just delete `Migrations/` and `app.db` whenever you want and it will not break anything. There are also limitations to SQLite that will force you to delete them because you can't update the database to do what you need to do. You *will* lose all of the data in the database so this does not work in production.

To perform a database migration go to the project folder and run the following Bash command:
```bash
dotnet ef migrations add CreateDatabase --context DogTransport.Data.ApplicationDBContext
dotnet ef database update --context DogTransport.Data.ApplicationDBContext
```

## Useful Bash commands

### ASP .Net Core

Build project and its dependencies:
```bash
dotnet build
```

Run the application:
```bash
dotnet run
```

### Entity Framework

Delete the last ef migration:
```bash
dotnet ef migrations remove --context DogTransport.Models.ModelsContext
```

Create a new ef migration:
```bash
dotnet ef migrations add MigrationName --context DogTransport.Data.ApplicationDBContext
// Be sure to change the migration name as necessary
```

Update the database with new migration:
```bash
dotnet ef database update --context DogTransport.Data.ApplicationDBContext
```

### ASP .NET Code Generator

List files available to be generated:
```bash
dotnet aspnet-codegenerator identity --listFiles
```

Generate code:
```bash
dotnet aspnet-codegenerator identity --files "Files.To.Be.Generated"
// Be sure to change the files to be generated string as necessary
```

## Helpful YouTube videos

[GIT Workflow - Georgia Tech - Software Development Process](https://www.youtube.com/watch?v=3a2x1iJFJWc)

[GitHub Flow Tutorial: Basic workflow for git](https://www.youtube.com/watch?v=GgjIvUrOpmg)