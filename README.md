# DogTransport

## Useful Bash commands

**Entity Framework**

Delete the last ef migration:
```bash
dotnet ef migrations remove --context DogTransport.Models.ModelsContext
```

Create a new ef migration:
```bash
dotnet ef migrations add [MigrationNameNoQuotationMarks] --context DogTransport.Data.ApplicationDBContext
```

Update the database with new migration:
```bash
dotnet ef database update --context DogTransport.Data.ApplicationDBContext
```

**ASP.NET Code Generator**
List files available to be generated:
```bash
dotnet aspnet-codegenerator identity --listFiles
```

Generate code
```bash
dotnet aspnet-codegenerator identity --files "Files.To.Be.Generated"
```