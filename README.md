# DogTransport

## How to run the application locally

The master branch of the GitHub repository is desgined to run in an Azure Webapp and makes use of environmental variables to obscure the AzureSQL connection string. So you may have to make some changes to the code to configure it to run using a local SQLite database.

### Step 1: Modify startup.cs

The `Startup.cs` file must be modified to use SQLite instead of SQL Server in order to run locally. At the time this was written lines 40 and 45 of `Startup.cs` must be commented out:
```c#
40  options.UseSqlServer(Configuration.GetConnectionString("AzureSQL")));  
...
45  options.UseSqlServer(Configuration.GetConnectionString("AzureSQL")));
```

Lines 41 and 46 should be uncommented out:
```c#
41  options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));
...
46  options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));
```

### Step 2: Create a database migration

When you clone the repository, there should not be a `Migrations/` folder or a database (`app.db`) but you may end up with these files from previous work, or accidental addition to the repository. If you have these files locally you may not need to do a migration, but the database will probably get cluttered fast and need to be deleted.

You can pretty much just delete `Migrations/` and `app.db` whenever you want and it will not break anything. There are also limitations to SQLite that will force you to delete them because you can't update the database to do what you need to do. You *will* lose all of the data in the database so this does not work in production.

To perform a database migration go to the project folder and run the following Bash command:
```bash
dotnet ef migrations add CreateDatabase --context DogTransport.Data.ApplicationDBContext
dotnet ef database update --context DogTransport.Data.ApplicationDBContext
```

## Useful Bash commands

### ASP.Net Core

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

### ASP.NET Code Generator

List files available to be generated:
```bash
dotnet aspnet-codegenerator identity --listFiles
```

Generate code
```bash
dotnet aspnet-codegenerator identity --files "Files.To.Be.Generated"
// Be sure to change the files to be generated string as necessary
```