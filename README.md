# Onion Architecture Template for .NET Applications (Blazor WebAssembly & ASP.NET Core Web API)

This repository provides a robust Onion Architecture template for developing .NET applications, specifically tailored for Blazor WebAssembly projects in .NET 6 and ASP.NET Core Web API. Onion Architecture is a design pattern that promotes maintainability, testability, and scalability of your applications by organizing the codebase into layers.

## Features
- **Blazor WebAssembly:** Utilize the power of Blazor WebAssembly to create rich and interactive front-end applications that run in the browser.
- **ASP.NET Core Web API:** Build a secure and performant back-end API using ASP.NET Core, which serves as the central point of communication for your Blazor app.
- **Onion Architecture:** The project structure follows the Onion Architecture pattern, which separates your application into concentric layers, each with a specific responsibility. This promotes modularity and separation of concerns.
- **Dependency Injection:** Leverage the built-in Dependency Injection container in .NET to manage the application's dependencies efficiently.
- **Entity Framework Core:** Connect to a database using Entity Framework Core, an ORM that simplifies data access and provides a seamless way to interact with your data store.
- **Identity and Authorization:** Implement user authentication and authorization using ASP.NET Core Identity. Ensure secure access control for your application.
- **Swagger:** Use Swagger to automatically generate API documentation, making it easier to understand and test your Web API endpoints.
- **Sample Features:** The template includes sample features and CRUD operations, demonstrating how to work with data, validate inputs, and more.

## Getting Started
1. Clone this repository to your local development environment.
2. Open the solution in Visual Studio or your preferred code editor.
3. Build and run the Blazor WebAssembly project for the front-end.
4. Launch the ASP.NET Core Web API project for the back-end.
5. Explore the provided samples, and customize the codebase to fit your application requirements.

## Project Structure
The solution is organized using the Onion Architecture layers:

- **Core:** Contains application-specific business logic, entities, and domain models.
- **Infrastructure:** Handles data access, external services, and cross-cutting concerns like logging.
- **Web:** Includes the Blazor WebAssembly and ASP.NET Core Web API projects.

Feel free to expand and adapt the structure according to your project's complexity.

## Contributing
We welcome contributions to this project. Whether it's fixing bugs, adding new features, or improving documentation, your help is appreciated. Please review our [Contribution Guidelines](CONTRIBUTING.md) for more information on how to get involved.

## License
This Onion Architecture template is open-source and available under the [MIT License](LICENSE.md). You are free to use, modify, and distribute it as needed for your own projects.

Enjoy building your .NET applications with this Onion Architecture template, and feel free to reach out if you have any questions or need assistance!
