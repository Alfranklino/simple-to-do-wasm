# Simple TODO

## Overview

Simple TODO is a minimalistic and intuitive task management application built using Blazor WebApp. The app allows users to efficiently manage their daily tasks, providing a simple interface for creating, editing, and deleting tasks.

## Features

- **Task Management**: Add, edit, and delete tasks effortlessly.
- **Responsive Design**: Works seamlessly on desktop and mobile devices.
- **Real-time Updates**: Changes are instantly reflected without the need for page reloads.
- **Offline Support**: Continue to manage your tasks even without an internet connection.

## Getting Started

### Prerequisites

Before you begin, ensure you have the following installed:

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Node.js](https://nodejs.org/) (for package management)
- [Visual Studio Code](https://code.visualstudio.com/) or any C# supported IDE

### Installation

1. **Clone the Repository**

   ```sh
   git clone https://github.com/yourusername/simple-todo.git
   cd simple-todo
   ```

2. **Install Dependencies**

   ```sh
   dotnet restore
   npm install
   ```

3. **Run the Application**

   ```sh
   dotnet run
   ```

   Open your browser and navigate to `https://localhost:5001`.

## Project Structure

- `/Pages`: Contains the Blazor components for the application.
  - `Index.razor`: Main page of the application.
  - `TaskList.razor`: Component for displaying the list of tasks.
  - `TaskItem.razor`: Component for individual task items.
- `/wwwroot`: Static files such as CSS, JS, and images.
- `/Shared`: Shared components like the layout and navigation menu.
- `/Data`: Contains the data models and services for managing tasks.

## Contributing

We welcome contributions! Please fork the repository and create a pull request with your changes. Make sure to follow the existing code style and include tests for any new functionality.

### Steps to Contribute

1. **Fork the Repository**
2. **Create a Feature Branch**

   ```sh
   git checkout -b feature/your-feature-name
   ```

3. **Commit Your Changes**

   ```sh
   git commit -m "Add some feature"
   ```

4. **Push to the Branch**

   ```sh
   git push origin feature/your-feature-name
   ```

5. **Open a Pull Request**

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgments

- [Blazor](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)
- [FontAwesome](https://fontawesome.com/)
- [Bootstrap](https://getbootstrap.com/)

---

Feel free to customize this README file to better fit your project's needs. If you need any additional sections or information, let me know!