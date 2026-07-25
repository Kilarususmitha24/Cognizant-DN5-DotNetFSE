import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-root',
  imports: [CommonModule],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {

  title = 'Angular Directives and Pipes';

  showEmployees = true;

  employees = [
    {
      id: 101,
      name: 'John',
      department: 'Development',
      salary: 50000,
      joiningDate: new Date(2024, 5, 15)
    },
    {
      id: 102,
      name: 'David',
      department: 'Testing',
      salary: 45000,
      joiningDate: new Date(2025, 1, 10)
    },
    {
      id: 103,
      name: 'Robert',
      department: 'Cloud',
      salary: 60000,
      joiningDate: new Date(2023, 8, 20)
    }
  ];

  toggleEmployees(): void {
    this.showEmployees = !this.showEmployees;
  }
}
