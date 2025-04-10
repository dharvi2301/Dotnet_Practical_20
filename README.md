# 🧪 Practical 20 - ASP.NET Core MVC Application

## 📚 Description

This practical demonstrates the development of a structured **ASP.NET Core MVC** web application that integrates the following software engineering concepts:

- ✅ **Global Exception Handling** using custom middleware
- ✅ **Auditing and Logging** into both **SQL Database** and **file-based logs**
- ✅ **Generic Repository Pattern** along with the **Unit of Work Pattern**
- ✅ Fully **Asynchronous** database operations using `async/await`
- ✅ Complete **debugging flow** using breakpoints, watches, code stepping, and inspecting

---

## 🛠️ Technologies Used

- ASP.NET Core MVC (.NET 8)
- Entity Framework Core
- SQL Server or LocalDB
- Serilog for logging to files
- Bootstrap for basic styling
- Razor Views
- Dependency Injection

---

## 📁 Project Structure

```plaintext
Practical_20/
│
├── Controllers/
│   └── HomeController.cs
│
├── Data/
│   ├── ApplicationDbContext.cs
│   └── LoggingMiddleware.cs
│
├── Interface/
│   ├── IGenericRepository.cs
│   └── IUnitOfWork.cs
│
├── Repository/
│   ├── GenericRepository.cs
│   └── UnitOfWork.cs
│
├── Middleware/
│   └── ErrorHandlingMiddleware.cs
│
├── Models/
│   ├── User.cs
│   └── AuditLog.cs
│
├── Views/
│   └── Home/
│       ├── Index.cshtml
│       └── Create.cshtml
│
├── Logs/
│   └── log-yyyy-MM-dd.txt
│
├── Program.cs
└── appsettings.json
```
### 🧪 Global Exception Handling Test

The error was triggered by breaking the DB connection string. The middleware caught the exception and logged it.
![image](https://github.com/user-attachments/assets/20d518ce-c4b6-4b6b-ae3e-55c94751f7e7)

