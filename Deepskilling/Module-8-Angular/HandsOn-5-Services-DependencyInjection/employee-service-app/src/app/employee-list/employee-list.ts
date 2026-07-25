import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';

import { Employee } from '../models/employee';
import { EmployeeService } from '../services/employee';

@Component({
  selector: 'app-employee-list',
  imports: [CommonModule],
  templateUrl: './employee-list.html',
  styleUrl: './employee-list.css'
})
export class EmployeeList implements OnInit {

  employees: Employee[] = [];

  constructor(
    private employeeService: EmployeeService
  ) {}

  ngOnInit(): void {
    this.employees =
      this.employeeService.getEmployees();
  }
}
