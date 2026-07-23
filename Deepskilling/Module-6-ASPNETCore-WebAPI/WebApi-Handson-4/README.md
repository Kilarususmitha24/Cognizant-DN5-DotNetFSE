# Module 6 - ASP.NET Core Web API

# Handson 4 - CRUD Operations

## Objective

Develop an ASP.NET Core Web API that performs CRUD (Create, Read, Update, Delete) operations on Employee data using an in-memory collection.

---

## Project Name

EmployeeApi

---

## Technologies Used

- ASP.NET Core 8.0
- C#
- REST API
- Swagger UI

---

## Project Structure

```
EmployeeApi
│
├── Controllers
│   └── EmployeeController.cs
│
├── Models
│   ├── Employee.cs
│   ├── Department.cs
│   └── Skill.cs
│
├── Program.cs
├── appsettings.json
├── EmployeeApi.csproj
└── Properties
```

---

## API Endpoints

### GET

```
GET /api/employee
```

Returns all employees.

---

### GET By Id

```
GET /api/employee/{id}
```

Returns a single employee.

---

### POST

```
POST /api/employee
```

Adds a new employee.

---

### PUT

```
PUT /api/employee/{id}
```

Updates an existing employee.

---

### DELETE

```
DELETE /api/employee/{id}
```

Deletes an employee.

---

## Sample JSON

```json
{
  "id": 3,
  "name": "Sai",
  "salary": 60000,
  "permanent": true,
  "department": {
    "id": 3,
    "name": "Development"
  },
  "skills": [
    {
      "id": 1,
      "name": "ASP.NET Core"
    }
  ],
  "dateOfBirth": "2003-06-20T00:00:00"
}
```

---

## Run Project

```bash
dotnet restore

dotnet build

dotnet run
```

---

## Swagger

```
https://localhost:<port>/swagger
```

---

## Learning Outcomes

- RESTful API Development
- CRUD Operations
- Routing
- Action Results
- Swagger Documentation
- Model Binding

---

## Author

Susmitha Kilaru
