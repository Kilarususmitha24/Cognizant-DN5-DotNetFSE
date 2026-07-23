# Module 6 - ASP.NET Core Web API

## Handson 2 - Swagger Web API

### Objective

Create an ASP.NET Core Web API application and integrate Swagger (OpenAPI) to document and test Web API endpoints. Verify the APIs using both Swagger UI and Postman.

---

## Project Name

SwaggerDemo

---

## Technologies Used

- ASP.NET Core 8.0
- C#
- Swagger (Swashbuckle.AspNetCore)
- Postman
- Visual Studio Code
- .NET CLI

---

## Project Structure

```
SwaggerDemo
│
├── Controllers
│   └── EmployeeController.cs
│
├── Models
│   └── Employee.cs
│
├── Properties
│   └── launchSettings.json
│
├── Program.cs
├── appsettings.json
├── appsettings.Development.json
├── SwaggerDemo.csproj
└── README.md
```

---

## Features

- Employee Web API
- GET all employees
- GET employee by ID
- POST new employee
- Swagger UI Integration
- ProducesResponseType attribute
- Route customization
- API testing using Postman

---

## API Endpoints

| Method | Endpoint | Description |
|---------|----------|-------------|
| GET | /api/employee | Get all employees |
| GET | /api/employee/{id} | Get employee by ID |
| POST | /api/employee | Add employee |

---

## Sample JSON

```json
{
  "id": 4,
  "name": "Sai",
  "department": "Development",
  "salary": 65000
}
```

---

## Required NuGet Package

```
Swashbuckle.AspNetCore
```

Install using:

```bash
dotnet add package Swashbuckle.AspNetCore
```

---

## Build Project

```bash
dotnet restore

dotnet build
```

---

## Run Project

```bash
dotnet run
```

---

## Swagger URL

```
https://localhost:<port>/swagger
```

---

## Testing

### Swagger

- Execute GET request
- Execute POST request
- Verify HTTP Status Codes

### Postman

- Test GET request
- Test POST request
- Verify JSON response

---

## Route Modification

Change

```csharp
[Route("api/[controller]")]
```

to

```csharp
[Route("api/Emp")]
```

Access the API using:

```
GET /api/Emp
```

---

## Expected Output

### GET

```json
[
  {
    "id": 1,
    "name": "John",
    "department": "IT",
    "salary": 50000
  },
  {
    "id": 2,
    "name": "David",
    "department": "HR",
    "salary": 45000
  },
  {
    "id": 3,
    "name": "Alice",
    "department": "Finance",
    "salary": 60000
  }
]
```

---

## Git Commands

```bash
git add .

git commit -m "Completed Module 6 Handson 2 - Swagger Web API"

git push origin main
```

---

## Learning Outcomes

- Understand Swagger/OpenAPI
- Document REST APIs
- Test APIs using Swagger UI
- Test APIs using Postman
- Use HTTP action verbs
- Configure API routes

---

## Author

Susmitha Kilaru
