# Module 8 - Angular

## Hands-On 2 - Components and Data Binding

### Objective

Create an Angular application demonstrating components and
different forms of data binding.

### Concepts Covered

- Angular Components
- Standalone Components
- Component Properties
- Interpolation
- Event Binding
- Component Communication
- TypeScript
- HTML Templates
- CSS Styling

### Application

Employee Management Application

The Employee component displays:

- Employee ID
- Employee Name
- Department
- Salary
- Permanent Status

### Data Binding

Interpolation is used to display component data:

```html
{{ employeeName }}
```

Event binding is used for button click events:

```html
<button (click)="showMessage()">
  Show Message
</button>
```

### Run

```bash
cd employee-app
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
- Angular CLI

### Author

Susmitha Kilaru
