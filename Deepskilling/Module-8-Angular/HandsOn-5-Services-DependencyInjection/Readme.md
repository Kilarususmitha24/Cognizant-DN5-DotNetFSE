# Module 8 - Angular

## Hands-On 5 - Services and Dependency Injection

### Objective

Create an Angular application demonstrating services and
dependency injection.

### Concepts Covered

- Angular Services
- Injectable
- Dependency Injection
- providedIn root
- Interfaces
- Components
- OnInit
- Service Methods
- Angular Currency Pipe

### Application

The application uses an EmployeeService to provide employee
information to the EmployeeList component.

### EmployeeService

The service provides methods to retrieve employee data.

```typescript
getEmployees()
getEmployeeById()
```

### Dependency Injection

EmployeeService is injected into EmployeeList using
constructor injection.

```typescript
constructor(
  private employeeService: EmployeeService
) {}
```

### Run

```bash
cd employee-service-app

npm install

ng serve
```

Open:

```text
http://localhost:4200
```

### Technologies

- Angular 20
- TypeScript
- HTML
- CSS
- Angular Services
- Dependency Injection

### Author

Susmitha Kilaru
