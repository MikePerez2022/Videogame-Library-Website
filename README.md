# Videogame-Library-Website

## Purpose

This project is a web-based Video Game Library application developed as part of the CSC260 course. It enables users to manage a collection of video games, including functionalities to add, edit, and view game entries. The application is built using the ASP.NET Core MVC framework, adhering to the Model-View-Controller (MVC) architectural pattern.

## Features

- **Game Management**: Add new games, edit existing entries, and view details.
- **MVC Structure**: Organized into Controllers, Models, and Views for maintainability.
- **Data Validation**: Ensures that user inputs meet specified criteria.
- **Responsive Design**: Utilizes HTML, CSS, and JavaScript for an interactive user interface.

## How to Use

### Prerequisites

- [.NET SDK 6.0 or later](https://dotnet.microsoft.com/download)
- A code editor like [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)

### Setup Instructions

1. **Clone the Repository**:

   ```bash
   git clone https://github.com/MikePerez2022/CSC260-GL.git
   cd CSC260-GL
   ```

2. **Restore Dependencies**:

   ```bash
   dotnet restore
   ```

3. **Build the Application**:

   ```bash
   dotnet build
   ```

4. **Run the Application**:

   ```bash
   dotnet run
   ```

5. **Access the Application**:

   Open your web browser and navigate to `https://localhost:5001` or the URL specified in the console output.

## Project Structure

- `Controllers/`: Handles HTTP requests and application logic.
- `Models/`: Defines the data structures and business logic.
- `Views/`: Contains the Razor views for the user interface.
- `Data/`: Manages data access and context.
- `Validators/`: Includes custom validation logic.
- `wwwroot/`: Hosts static files like CSS, JavaScript, and images.
- `Program.cs`: Configures and starts the application.
- `VideoGameLibrary.csproj`: Project file containing metadata and dependencies.

## Dependencies

- **ASP.NET Core MVC**: Framework for building web applications.
- **Entity Framework Core**: Object-relational mapper for database interactions.
- **Razor Pages**: For dynamic web page generation.

## Contributing

Contributions are welcome! Please fork the repository and submit a pull request for any enhancements or bug fixes.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

