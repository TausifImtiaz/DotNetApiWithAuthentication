# DotNet API with Authentication

## Overview

The **DotNet API with Authentication** project is an ASP.NET Core API that demonstrates how to implement Bearer token authentication and manage Master-Details CRUD operations. This project provides a robust example of securing an API with JWT Bearer tokens while showcasing a Master-Details data management approach using ASP.NET Core MVC.

## Features

- **Bearer Token Authentication:** Secures API endpoints using JSON Web Tokens (JWT) for authentication and authorization.
- **Master-Details CRUD Operations:** Implements Create, Read, Update, and Delete operations with a Master-Details approach to handle related data.
- **ASP.NET Core MVC:** Utilizes ASP.NET Core MVC framework for building scalable and high-performance web APIs.

## Technologies Used

- ASP.NET Core MVC
- JWT Bearer Token Authentication
- Entity Framework Core (for data access)
- SQL Server or other supported databases
- Swagger for API documentation

## Project Structure

- **Controllers:** Defines API endpoints for handling HTTP requests and CRUD operations.
- **Models:** Contains data structures and business logic used throughout the application.
- **Data Access Layer:** Implements Entity Framework Core context and repository patterns for database interactions.
- **Authentication:** Configures JWT authentication and authorization.
- **Migrations:** Includes Entity Framework Core migrations for managing database schema changes.

## Getting Started

### Prerequisites

- .NET SDK 6.0 or later
- SQL Server or another supported database
- Visual Studio 2022 or later (or any other preferred IDE)

### Cloning the Repository

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/TausifImtiaz/DotNetApiWithAuthentication.git
   ```

### Installation

1. **Navigate to the Project Directory:**
   ```bash
   cd DotNetApiWithAuthentication
   ```

2. **Open the Solution:**
   Open the `.sln` file in Visual Studio or your preferred IDE.

3. **Restore NuGet Packages:**
   Restore all required NuGet packages by building the solution or using the NuGet Package Manager.

4. **Configure the Database:**
   - Open `appsettings.json` and update the connection string to point to your SQL Server instance or preferred database.
   - Apply Entity Framework Core migrations to set up the database schema:
     ```bash
     dotnet ef migrations add InitialCreate
     dotnet ef database update
     ```

5. **Configure JWT Authentication:**
   - Open `Startup.cs` or `Program.cs` (depending on your .NET version) and configure JWT authentication with your secret key.

6. **Run the Application:**
   Press `F5` or use the command line to start the application:
   ```bash
   dotnet run
   ```

### Testing the API

1. **Access Swagger Documentation:**
   - Once the application is running, navigate to `http://localhost:5000/swagger` (or the URL specified in `launchSettings.json`) to view and test the API endpoints interactively.

2. **Authenticate Requests:**
   - Obtain a JWT token by logging in through the authentication endpoints provided in the API.
   - Include the token in the `Authorization` header as `Bearer [YourToken]` for accessing protected endpoints.

## Usage

1. **CRUD Operations:**
   - **Create:** POST requests to create new master and detail records.
   - **Read:** GET requests to retrieve master and detail records.
   - **Update:** PUT requests to update existing records.
   - **Delete:** DELETE requests to remove records.

2. **Authentication:**
   - Use the provided authentication endpoints to generate and use JWT tokens.
   - Ensure the token is included in the `Authorization` header for protected routes.

## Contributing

Contributions are welcome! To contribute:
- Fork the repository.
- Create a feature branch.
- Commit your changes.
- Push to the branch.
- Open a pull request with a description of your changes.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgements

- ASP.NET Core documentation
- JWT authentication resources
- Entity Framework Core documentation

## Contact

For any questions or support, please contact [Tausif Imtiaz](mailto:tausifimtiaz@gmail.com).
