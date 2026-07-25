import { Routes } from '@angular/router';

import { Home } from './home/home';
import { Employees } from './employees/employees';
import { EmployeeDetail } from './employee-detail/employee-detail';
import { About } from './about/about';
import { PageNotFound } from './page-not-found/page-not-found';

export const routes: Routes = [

  {
    path: '',
    component: Home
  },

  {
    path: 'employees',
    component: Employees
  },

  {
    path: 'employees/:id',
    component: EmployeeDetail
  },

  {
    path: 'about',
    component: About
  },

  {
    path: '**',
    component: PageNotFound
  }

];
