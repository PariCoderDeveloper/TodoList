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

- **ASP.NET Core Razor Pages**: Simplified page-based programming model ideal for small to medium web applications.  
  [Learn More](https://learn.microsoft.com/en-us/aspnet/core/razor-pages)
  
- **Entity Framework Core (EF Core)**: ORM for interacting with the database using C# models.  
  [Learn More](https://learn.microsoft.com/en-us/ef/core/)

- **.NET 9.0**: Built with the latest .NET 9 SDK for performance and modern features.

- **JavaScript & AJAX (Fetch)**: Used for asynchronous requests and real-time UI updates.

- **Clean Architecture Layers**:
  - **Domain**: Contains core models and business rules.
  - **Application**: Contains services, DTOs, and business logic.
  - **Infrastructure**: Data access implementations and EF Core configurations.
  - **Presentation**: UI built using Razor Pages.

---

## Folder Structure
```bash
TodoList/
├── Domain/           # Domain models (e.g., Task entity)
├── Application/      # Services, DTOs, commands, queries
├── Infrastructure/   # Data access layer, DbContext, EF configs
├── Peresentation/    # UI layer (Razor Pages, wwwroot for static files)
├── TodoListSource.sln
├── README.md
├── .gitignore
└── ...
