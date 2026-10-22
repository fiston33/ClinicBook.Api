# ClinicBook.Api
A clinic appointment management REST API built with ASP.NET Core, Entity Framework Core, and SQLite, exploring persistence, validation, pagination, authentication, roles, and resource ownership. Topics: csharp · dotnet · aspnet-core · web-api · entity-framework-core · sqlite · rest-api · authentication · pagination


# ClinicBook.Api 🏥

**A Clinic Appointment Management REST API built with ASP.NET Core.**

ClinicBook.Api is a learning and portfolio project focused on building a structured, secure, and maintainable RESTful API for managing doctors and clinic appointments.

The project demonstrates core backend development concepts, including entity modeling, database persistence, request validation, pagination, authentication, role-based authorization, and resource ownership.

The long-term goal is to connect the API to an amazing mobile application.

## 🎯 Project Objectives

- Build RESTful endpoints using ASP.NET Core Web API.
- Model relationships between doctors and appointments.
- Persist application data using Entity Framework Core and SQLite.
- Implement validation and consistent API responses.
- Support pagination for collection endpoints.
- Secure endpoints with authentication and authorization.
- Enforce role permissions and resource ownership.
- Prepare a reliable backend for a future mobile client.

## 🛠️ Technology Stack

- **Language:** C#
- **Framework:** ASP.NET Core Web API on .NET 10
- **ORM:** Entity Framework Core with SQLite
- **Database:** SQLite
- **API Format:** REST / JSON
- **API documentation:** OpenAPI and Scalar (development only)
- **Future Client:** Mobile application

## Development Setup

The API is configured to use SQLite through the `DefaultConnection` setting in
`appsettings.json`. When running in the Development environment, the app creates
the database if it does not exist and serves OpenAPI at `/openapi/v1.json` and
Scalar at `/scalar/v1`.

Database creation and interactive API documentation are intentionally disabled
outside Development. Before deploying with real data, add and apply EF Core
migrations rather than relying on `EnsureCreated`; configure the production
connection string through environment-specific configuration or a secret store.

## 📚 Development Roadmap

### Module 1 — Core Resources

Establish the fundamental API resources and response structures.

- **Doctor:** Represent doctors and their information.
- **Appointment:** Represent appointments and their associated data.
- **Paged Response:** Define a consistent response structure for paginated collections.

### Module 2 — Persistence and Data Quality

Extend the development database setup into production-ready persistence and improve request handling.

- Add and apply EF Core migrations for schema changes.
- Implement database persistence.
- Add request validation.
- Implement pagination for collection endpoints.
- Build appointment management operations.
- Handle invalid requests and missing resources appropriately.

### Module 3 — Authentication and Authorization

Protect API resources and enforce access rules.

- Implement user authentication.
- Introduce role-based authorization.
- Enforce resource ownership.
- Restrict protected operations according to permissions.
- Ensure users can access or manage only the resources they are authorized to use.

### Module 4 — Extensions and Improvements

Extend the API beyond its initial requirements.

- Improve API structure and maintainability.
- Strengthen error handling and response consistency.
- Add automated tests.
- Improve documentation and security.
- Prepare the API for integration with a mobile application.

## 🏗️ Architecture

The project is organized around clear responsibilities:

- **Controllers:** Handle HTTP requests and responses.
- **Models:** Represent domain resources such as doctors and appointments.
- **Data / DbContext:** Configure and manage database access through EF Core.
- **Validation:** Check incoming data before processing.
- **Authorization:** Protect resources and enforce access policies.

The exact folder structure may evolve as the project grows.

## 🚀 Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download)
- A code editor such as Visual Studio Code
- Git

### Run Locally

Clone the repository:

```bash
git clone https://github.com/fiston33/ClinicBook.Api.git
```

Navigate into the project directory:

```bash
cd ClinicBook.Api
```

Restore dependencies:

```bash
dotnet restore
```

Build the project:

```bash
dotnet build
```

Run the API:

```bash
dotnet run
```

Use the local URL printed in the terminal to access the API. If Scalar or another API documentation interface is configured, use its configured endpoint to explore and test the available operations.

> Setup instructions may evolve as database configuration, authentication, and other modules are implemented.

## 📱 Future Direction

After completing the API modules, the next goal is to develop a mobile application that communicates with ClinicBook.Api.

The mobile application will provide a user-friendly interface for interacting with the clinic appointment system, while the API remains responsible for business rules, persistence, and access control.

## 📖 Learning Focus

This project is an opportunity to apply backend development concepts through practical implementation, testing, debugging, and continuous improvement.

The emphasis is on understanding not only how to build endpoints, but also how to design APIs that are maintainable, secure, and ready for real application clients.

## 👨‍💻 Author

**Fiston BYIRINGIRO**

GitHub: [@fiston33](https://github.com/fiston33)

---

*Building practical software, one module at a time.*
