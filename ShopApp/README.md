# Multi-Language E-commerce ASP.NET Project

## Summary
This project is an ASP.NET MVC-based web application that demonstrates e-commerce functionality with support for multiple languages. It includes features like user account management, shopping cart functionality, and language resource management.

## Project Description
The Multi-Language E-commerce ASP.NET Project is a web-based application built using the ASP.NET MVC framework. The application allows users to browse products, add items to a shopping cart, and manage their accounts. Additionally, it supports multiple languages, allowing users to switch between different language settings seamlessly. This is achieved using resource files for various language translations.

The project is designed to showcase how to handle localization in a web application and implement basic e-commerce functionalities using ASP.NET MVC.

## Features
- **User Account Management**: Handle user registration, login, and profile management.
- **Shopping Cart**: Users can add, view, and manage items in their shopping carts.
- **Language Management**: Supports multiple languages using resource files for localization (.resx files).
- **Database Integration**: Includes models for products and users, backed by SQL Server databases.
- **Modular Controllers**: Separate controllers for account management, shopping, and user actions.

## Installation
1. Clone the repository:
git clone https://github.com/MToader/ShopApp.git
2. Open the project in Visual Studio.
3. Restore NuGet packages.
4. Set up the database:
- Ensure SQL Server is running.
- Update the connection strings in `Web.config` to point to your local SQL Server instance.
5. Build and run the project.

## Usage
1. Run the project in Visual Studio.
2. Open a browser and navigate to the local URL provided by Visual Studio.
3. You can register a new user, log in, and browse products.
4. Use the language selector to switch between available languages.

## Project Structure
- **Controllers**: Manages the flow of data between views and models (e.g., `AccountController.cs`, `CartController.cs`).
- **Models**: Contains the structure for data objects like users and products.
- **Views**: Displays the data to the user.
- **Resources**: Handles localization for multiple languages with .resx files (e.g., `Resource.ro.resx`, `Resource.de.resx`).
- **Database Contexts**: Two database contexts for handling product and user data (`ProductModelDbContext`, `UserModelDbContext`).

## Technologies Used
- **ASP.NET MVC**: Framework for building the web application.
- **C#**: Used for backend logic.
- **Entity Framework**: ORM for interacting with the database.
- **SQL Server**: Database for storing user and product data.
- **jQuery and Bootstrap**: For front-end interaction and styling.

## License
This project is open-source under the MIT License. Feel free to modify and use it for educational purposes.
