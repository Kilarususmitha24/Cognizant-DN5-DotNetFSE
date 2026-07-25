import { Component, OnInit } from '@angular/core';

import {
  ActivatedRoute,
  RouterLink
} from '@angular/router';

@Component({
  selector: 'app-employee-detail',

  imports: [
    RouterLink
  ],

  templateUrl: './employee-detail.html',
  styleUrl: './employee-detail.css'
})
export class EmployeeDetail implements OnInit {

  employeeId = 0;

  constructor(
    private route: ActivatedRoute
  ) {}

  ngOnInit(): void {

    this.employeeId = Number(
      this.route.snapshot.paramMap.get('id')
    );

  }

}
