import { Injectable } from '@angular/core';
import { Employee } from '../models/employee';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  private employees: Employee[] = [
    {
      id: 101,
      name: 'John',
      department: 'Development',
      salary: 50000
    },
    {
      id: 102,
      name: 'David',
      department: 'Testing',
      salary: 45000
    },
    {
      id: 103,
      name: 'Robert',
      department: 'Cloud',
      salary: 60000
    },
    {
      id: 104,
      name: 'Mary',
      department: 'Human Resources',
      salary: 40000
    }
  ];

  getEmployees(): Employee[] {
    return this.employees;
  }

  getEmployeeById(id: number): Employee | undefined {
    return this.employees.find(
      employee => employee.id === id
    );
  }
}
