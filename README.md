# Clean Architecture Template

This template demonstrates a basic service-based architecture using **ASP.NET Core 8** and **SQL Server**. It is organized into the following projects:

- **Domain** – domain entities
- **Application** – service logic and interfaces
- **Infrastructure** – EF Core DbContext and repository implementations
- **WebApi** – REST API entry point

The solution file `CleanArchitectureTemplate.sln` includes all projects.

## Getting Started

1. Ensure the .NET 8 SDK and SQL Server are installed.
2. Update the connection string in `WebApi/appsettings.json` if necessary.
3. Build the solution:
   ```bash
   dotnet build CleanArchitectureTemplate.sln
   ```
4. Run the API:
   ```bash
   dotnet run --project WebApi
   ```

The API exposes `/weatherforecast` endpoints for listing and adding forecasts. Swagger UI is enabled in development.
