\# Madyan Commerce API



A RESTful Web API built with ASP.NET Core and Entity Framework Core to manage products and categories for a commerce application.



\## Technologies Used



\- C#

\- ASP.NET Core 8

\- Entity Framework Core 8

\- SQL Server

\- Swagger / OpenAPI



\## Features



\### Products

\- Get all products

\- Get a product by ID

\- Create a product

\- Update a product

\- Delete a product



\### Categories

\- Get all categories

\- Get a category by ID

\- Create a category

\- Delete a category



\## Database



The project uses SQL Server with Entity Framework Core Code First migrations.



To run the project, configure the `DefaultConnection` connection string in `appsettings.json` to match your local SQL Server instance.



Apply the migrations using the Package Manager Console:



```powershell

Update-Database

```



\## How to Run



1\. Install the .NET 8 SDK.

2\. Install SQL Server and configure your connection string.

3\. Open the project in Visual Studio.

4\. Restore NuGet packages.

5\. Apply the database migrations.

6\. Run the application.

7\. Open Swagger to explore and test the API endpoints.



\## API Documentation



Swagger UI is available while the application is running in Development mode.



\## Author



Moataz Madyan



GitHub: https://github.com/moataz-madyan

