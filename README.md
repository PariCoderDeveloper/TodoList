# TodoList – Task Management Web Application

## Overview
**TodoList** is a single-page web application (SPA) designed to manage daily tasks efficiently. The main goal of this app is to provide a clean and simple user interface for adding, viewing, editing, and deleting tasks. Each task can have a title, a due date, and a completion status. The application is ideal for organizing personal or work-related to-do lists.

---

## Why Single Page Application (SPA)?
TodoList is implemented as a **Single Page Application (SPA)**. This means that after the initial page load, all subsequent interactions (e.g., adding or removing tasks) are handled dynamically using JavaScript without requiring a full page refresh.

- The initial page loads a single HTML document.
- All updates to the content are made via AJAX or Fetch API requests.
- Razor Pages controllers (e.g., `Index.cshtml`) return data as JSON.
- The frontend updates the UI dynamically based on the response, creating a seamless user experience.

For more information, see [MDN's SPA definition](https://developer.mozilla.org/en-US/docs/Glossary/SPA).

---

## Features
- **View Tasks List**: The main page (“My Tasks”) displays all tasks, grouped into **Today’s Tasks** and **Past Tasks**.
- **Add New Task**: Users can add new tasks by specifying a title and date.
- **Edit Task**: Tasks can be edited to update title, due date, or status.
- **Delete Task**: Tasks can be removed from the list.
- **Toggle Task Status**: Tasks can be marked as “Done” or “In Progress”.
- **Dynamic UI**: All operations are performed via JavaScript and AJAX/Fetch calls, without reloading the page.

---

## Technologies Used
This project follows a **layered (Clean Architecture)** pattern and uses the following technologies:

-   **ASP.NET Core Razor Pages**: Simplified page-based programming model ideal for small to medium web applications.  
    [Learn More](https://learn.microsoft.com/en-us/aspnet/core/razor-pages)

-   **Entity Framework Core (EF Core)**: ORM for interacting with the database using C# models.  
    [Learn More](https://learn.microsoft.com/en-us/ef/core/)

-   **.NET 9.0**: Built with the latest .NET 9 SDK for performance and modern features.

-   **JavaScript & AJAX (Fetch)**: Used for asynchronous requests and real-time UI updates.

-   **Clean Architecture Layers**:
    -   **Domain**: Contains core models and business rules.
    -   **Application**: Contains services, DTOs, and business logic.
    -   **Infrastructure**: Data access implementations and EF Core configurations.
    -   **Presentation**: UI built using Razor Pages.

---

## Folder Structure
```bash
TodoList/
├── Domain/           # Domain models (e.g., Task entity)
├── Application/      # Services, DTOs, commands, queries
├── Infrastructure/   # Data access layer, DbContext, EF configs
├── Presentation/    # UI layer (Razor Pages, wwwroot for static files)
├── TodoListSource.sln
├── README.md
├── .gitignore
└── ...
```
## Installation & Running Locally

### Prerequisites
* .NET 9.0 SDK
* Visual Studio 2022+ or Visual Studio Code

### Steps
1.  **Clone the Repository**
    ```bash
    git clone [https://github.com/PariCoderDeveloper/TodoList.git](https://github.com/PariCoderDeveloper/TodoList.git)
    cd TodoList
    ```
2.  **Open in IDE**

    Open `TodoListSource.sln` in Visual Studio or VS Code.
3.  **Restore Packages & Build**
    ```bash
    dotnet restore
    dotnet build
    ```
4.  **Configure the Database**

    Update the database connection string in `appsettings.json` or in your `DbContext` class as needed. The default setup may use SQLite or LocalDB.
5.  **Run the Application**
    ```bash
    dotnet run --project Presentation/Presentation.csproj
    ```
    The application will start on `https://localhost:5001` by default.

---

## How to Use

### View Tasks
Open the browser and navigate to `https://localhost:5001`. The homepage (My Tasks) lists all tasks categorized by date.

### Add Task
Click the “+ Add” button and fill out the title and due date.

### Edit Task
Click on a task or the Edit icon to update its title, date, or status.

### Delete Task
Click the Delete (Trash) icon to remove a task.

### Real-Time Updates
All operations are instantly reflected on the same page without any reload.

---

## Developer Tips

* **Follow Clean Architecture**: Place business logic in `Application` or `Domain`, and keep UI-related code in `Presentation`.
* **Use Design Patterns**: The project uses a simple Facade pattern (`IFacadPattern`) to access services. Extend using Dependency Injection and other patterns as needed.
* **Customize UI**: Modify Razor Pages (`.cshtml`) in `Presentation/Pages/`. Static assets (CSS, JS) can be found under `wwwroot/`.
* **Data Layer Testing**: Use EF Core's in-memory providers for unit tests. You can switch databases easily (e.g., to SQLite or SQL Server) by updating the `Infrastructure` layer.
* **Extendability**: Add features such as task categories, user authentication, or admin panels by creating new pages or services. Clean separation of concerns ensures minimal conflicts during feature additions.

---

## Screenshots

Currently, there are no screenshots in the repository. After running the app, you’ll see a clean UI titled “My Tasks” with two task sections and control buttons (Add/Edit/Delete). You can add your own screenshots or replace this section with sample images.

---

## References

* [ASP.NET Core Razor Pages – Microsoft Docs](https://learn.microsoft.com/en-us/aspnet/core/razor-pages)
* [Entity Framework Core – Microsoft Docs](https://learn.microsoft.com/en-us/ef/core/)
* [Single Page Application (SPA) – MDN](https://developer.mozilla.org/en-US/docs/Glossary/SPA)
* [.NET CLI Documentation](https://learn.microsoft.com/en-us/dotnet/core/tools/)
* Project architecture inspired by [Clean Architecture model](https://docs.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/common-web-application-architectures#clean-architecture).

---

## License

MIT License (or specify based on your actual repository setup)
