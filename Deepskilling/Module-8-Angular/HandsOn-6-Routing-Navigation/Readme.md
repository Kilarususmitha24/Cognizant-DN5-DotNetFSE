# Module 8 - Angular

## Hands-On 6 - Routing and Navigation

### Objective

Create an Angular application demonstrating routing,
navigation, route parameters, and wildcard routes.

### Concepts Covered

- Angular Router
- RouterOutlet
- RouterLink
- RouterLinkActive
- Route Configuration
- Route Parameters
- ActivatedRoute
- Wildcard Routes
- 404 Page
- Navigation

### Routes

| Route | Component |
|---|---|
| `/` | Home |
| `/employees` | Employees |
| `/employees/:id` | Employee Detail |
| `/about` | About |
| `**` | Page Not Found |

### Route Parameter

Employee details use a dynamic route:

```text
/employees/:id
```

Example:

```text
/employees/101
```

The ID is retrieved using `ActivatedRoute`.

### Run

```bash
cd routing-app
npm install
ng serve
```

Open:

```text
http://localhost:4200
```

### Test

Home:

```text
http://localhost:4200/
```

Employees:

```text
http://localhost:4200/employees
```

Employee Detail:

```text
http://localhost:4200/employees/101
```

About:

```text
http://localhost:4200/about
```

404:

```text
http://localhost:4200/invalid-page
```

### Technologies

- Angular 20
- Angular Router
- TypeScript
- HTML
- CSS

### Author

Susmitha Kilaru
