# Module 6 - ASP.NET Core Web API

## Handson 5 - JWT Authentication

### Objective

Implement JWT Authentication in ASP.NET Core Web API.

### Features

- User Login
- JWT Token Generation
- JWT Authentication
- Role Based Authorization
- Swagger JWT Support

### Login Endpoint

POST

/api/auth/login

Sample Login

{
  "username":"admin",
  "password":"admin123"
}

Copy the generated JWT token.

Click **Authorize** in Swagger.

Enter

Bearer <token>

Now access

GET /api/employee

DELETE /api/employee/{id}

(Admin only)

### Technologies

- ASP.NET Core 8
- JWT Bearer Authentication
- Swagger
