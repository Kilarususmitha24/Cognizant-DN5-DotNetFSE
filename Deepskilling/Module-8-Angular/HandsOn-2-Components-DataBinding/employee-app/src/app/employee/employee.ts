import { Component } from '@angular/core';

@Component({
  selector: 'app-employee',
  imports: [],
  templateUrl: './employee.html',
  styleUrl: './employee.css'
})
export class Employee {

  employeeId: number = 101;
  employeeName: string = 'John';
  department: string = 'Software Development';
  salary: number = 50000;
  permanent: boolean = true;

  message: string = '';

  showMessage(): void {
    this.message = 'Employee details loaded successfully!';
  }
}
