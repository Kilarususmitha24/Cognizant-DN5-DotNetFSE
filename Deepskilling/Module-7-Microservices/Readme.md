# Module 7 - Microservices

## JWT Authentication and Authorization

This hands-on demonstrates authentication and authorization
in an ASP.NET Core Web API microservice using JWT.

## Exercises

1. Implement JWT Authentication
2. Secure API Endpoint Using JWT
3. Role-Based Authorization
4. JWT Token Expiry Handling

## Features

- Login API
- JWT Token Generation
- Protected Endpoints
- Role-Based Authorization
- Admin Authorization
- Token Expiration Validation
- Custom Unauthorized Response
- Swagger JWT Authentication

## Login

POST:

```text
/api/Auth/login
```

Request:

```json
{
  "username": "admin",
  "password": "admin123"
}
```

## Protected Endpoint

```text
GET /api/Secure/data
```

Requires a valid JWT token.

## Admin Endpoint

```text
GET /api/Admin/dashboard
```

Requires the `Admin` role.

## Run

```bash
dotnet restore
dotnet build
dotnet run
```

Open Swagger and use the Authorize button to provide
the generated JWT token.

## Technologies

- ASP.NET Core Web API
- C#
- JWT
- Authentication
- Authorization
- Swagger
