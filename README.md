# 🧩 ToDoApp - REST API Styles (Layered Architecture)

This repository demonstrates multiple implementations of REST APIs for a simple ToDo application, each following a different architectural style within a layered architecture pattern.

Each API variant is **self-contained**, with its **own solution (.sln) file** to enable independent development, testing, and comparison.

---

# Author

## Vishwa Kumar
- **Email:** vishwa@vishwa.me
- **GitHub:** [Vishwam](https://github.com/vishwamkumar)
- **LinkedIn:** [Vishwa Kumar](https://www.linkedin.com/in/vishwamohan)

Vishwa is the primary architect of the ToDoApp, responsible for the architecture and implementation of these features.


## 📦 Included Projects

### 1. `ToDoApp.Data.Sqlite`
- Shared data access library using **Entity Framework Core (EFC)** with **SQLite**.
- Includes `DbContext`, entity definitions, and migration setup.
- Used as a common data layer across all API implementations.

---

### 2. `ToDoApp.RestApi.MvcControllers`
- Traditional ASP.NET Core MVC-based API.
- Uses controller classes with `[ApiController]` and standard routing.
- Good for teams familiar with conventional ASP.NET Web API development.

---

### 3. `ToDoApp.RestApi.Minimal`
- Uses ASP.NET Core **Minimal APIs**.
- Lightweight and concise, perfect for microservices or smaller APIs.
- Demonstrates handler functions with route mappings.

---

### 4. `ToDoApp.RestApi.Endpoints`
- Implements **endpoint-per-file** pattern (like Carter or similar).
- Each endpoint is a separate class for better separation of concerns.
- Great balance between structure and simplicity.

---

### 5. `ToDoApp.RestApi.FastEndpoints`
- Built using the [FastEndpoints](https://fast-endpoints.com/) library.
- Encourages strong typing and clean separation of input, logic, and response.
- Ideal for high-performance, maintainable APIs.

---

## 🧪 How to Run & Test
Each API project:
- Has its **own solution file (.sln)**.
- Can be run independently via CLI or Visual Studio.
- Shares the same underlying SQLite data layer to enable consistent comparison.

### Prerequisites
- [.NET SDK 9+](https://dotnet.microsoft.com)
- Visual Studio 2022 or VS Code
- EF Core tools (if working with migrations)

---

## 🔍 Goals
- Help developers understand different REST API implementation patterns.
- Enable experimentation and benchmarking.
- Provide a base for extending to Clean Architecture or CQRS in the future.

---

## 📌 Roadmap
- [ ] Add MediatR-based APIs
- [ ] Add Clean Architecture sample
- [ ] Add Swagger/OpenAPI for all variants

---

## 📄 License
This project is licensed under the MIT License.
