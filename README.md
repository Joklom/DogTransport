# DogTransport

## How to run the application locally

The master branch of the GitHub repository is desgined to run in an Azure Webapp and makes use of environmental variables to obscure the AzureSQL connection string. So you may have to make some changes to the code to configure it to run using a local SQLite database.



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
```