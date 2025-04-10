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

![image](https://github.com/user-attachments/assets/b12081af-de75-4b59-9454-389960bc45dd)


**Audit Log Table:**
![image](https://github.com/user-attachments/assets/1d6a5a90-c8cb-4ef9-9628-bf55b8cdc601)


![image](https://github.com/user-attachments/assets/c761604c-4f49-4f5a-abfd-04c473307d09)

![image](https://github.com/user-attachments/assets/53d3f4f7-0e76-48e0-a288-d4f36bf29af3)

![image](https://github.com/user-attachments/assets/e887d1aa-b9ac-46d0-84d1-154696dc78b4)





