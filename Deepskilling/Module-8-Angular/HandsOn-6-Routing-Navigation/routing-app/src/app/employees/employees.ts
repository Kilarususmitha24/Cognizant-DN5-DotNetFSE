import { Component } from '@angular/core';

import {
  RouterLink
} from '@angular/router';

@Component({
  selector: 'app-employees',

  imports: [
    RouterLink
  ],

  templateUrl: './employees.html',
  styleUrl: './employees.css'
})
export class Employees {

  employees = [

    {
      id: 101,
      name: 'John',
      department: 'Development'
    },

    {
      id: 102,
      name: 'David',
      department: 'Testing'
    },

    {
      id: 103,
      name: 'Robert',
      department: 'Cloud'
    },

    {
      id: 104,
      name: 'Mary',
      department: 'Human Resources'
    }

  ];

}
