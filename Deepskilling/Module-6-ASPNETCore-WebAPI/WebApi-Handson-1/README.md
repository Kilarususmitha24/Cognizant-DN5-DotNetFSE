# Module 6 - ASP.NET Core Web API

## Handson 1 - First Web API

### Objective
Create a simple ASP.NET Core Web API application using the Web API template. Implement a controller with CRUD (Read, Create, Update, Delete) operations using HTTP action verbs.

---

## Project Name

FirstWebApi

---

## Technologies Used

- ASP.NET Core 8.0
- C#
- Swagger (OpenAPI)
- Visual Studio Code
- .NET CLI

---

## Project Structure

```
FirstWebApi
│
├── Controllers
│   └── ValuesController.cs
│
├── Properties
│   └── launchSettings.json
│
├── Program.cs
├── appsettings.json
├── appsettings.Development.json
├── FirstWebApi.csproj
└── README.md
```

---

## Features

- GET all values
- GET value by ID
- POST new value
- PUT update value
- DELETE value
- Swagger UI support

---

## HTTP Methods

| Method | Endpoint | Description |
|---------|----------|-------------|
| GET | /api/values | Get all values |
| GET | /api/values/{id} | Get value by id |
| POST | /api/values | Add new value |
| PUT | /api/values/{id} | Update value |
| DELETE | /api/values/{id} | Delete value |

---

## Packages

```
Swashbuckle.AspNetCore
```

---

## Build

```bash
dotnet restore

dotnet build
```

---

## Run

```bash
dotnet run
```

---

## Swagger URL

```
https://localhost:<port>/swagger
```

---

## Expected Output

GET Request

```json
[
  "Value One",
  "Value Two",
  "Value Three"
]
```

---

## Git Commands

```bash
git add .

git commit -m "Completed Module 6 Handson 1 - First Web API"

git push origin main
```

---

## Author

Susmitha Kilaru
