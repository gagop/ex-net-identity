# ASP.NET Core Identity Sample Application

A sample application demonstrating ASP.NET Core Identity implementation with Entity Framework Core and PostgreSQL.

## Features

- User registration and authentication
- Custom user model with extended properties
- Entity Framework Core with PostgreSQL
- RESTful API endpoints for account management

## Technology Stack

- .NET 9.0
- ASP.NET Core Identity
- Entity Framework Core 9.0
- PostgreSQL
- OpenAPI/Swagger

## Prerequisites

- .NET 9.0 SDK
- PostgreSQL database
- Docker (optional, for containerized PostgreSQL)

## Getting Started

### Database Setup

1. Ensure PostgreSQL is running and accessible
2. Update the connection string in `appsettings.json` if needed:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Host=localhost;Port=5432;Username=postgres;Password=mysecretpassword;Database=sample_db"
   }
   ```

### Running the Application

1. Clone the repository
   ```
   git clone https://github.com/yourusername/ex-net-identity.git
   cd ex-net-identity
   ```

2. Navigate to the project directory
   ```
   cd SampleApp
   ```

3. Run database migrations
   ```
   dotnet ef database update
   ```

4. Start the application
   ```
   dotnet run
   ```

5. Access the API at `https://localhost:5001` or `http://localhost:5000`

## API Endpoints

- `POST /api/account/register` - Register a new user

## Project Structure

- `Controllers/` - API controllers
- `Models/` - Data models including custom Identity user
- `DAL/` - Data Access Layer with DbContext
- `Migrations/` - EF Core migrations

## Identity Configuration

This sample configures Identity with the following password requirements:
- Minimum length: 8 characters
- Requires digits
- Requires lowercase letters
- Requires uppercase letters
- Requires non-alphanumeric characters

## License

MIT