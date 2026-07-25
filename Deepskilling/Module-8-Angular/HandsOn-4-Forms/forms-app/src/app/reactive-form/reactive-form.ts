import { Component } from '@angular/core';

import {
  FormControl,
  FormGroup,
  ReactiveFormsModule,
  Validators
} from '@angular/forms';

@Component({
  selector: 'app-reactive-form',
  imports: [ReactiveFormsModule],
  templateUrl: './reactive-form.html',
  styleUrl: './reactive-form.css'
})
export class ReactiveForm {

  submitted = false;

  employeeForm = new FormGroup({

    name: new FormControl('', [
      Validators.required,
      Validators.minLength(3)
    ]),

    email: new FormControl('', [
      Validators.required,
      Validators.email
    ]),

    salary: new FormControl<number | null>(
      null,
      [
        Validators.required,
        Validators.min(1)
      ]
    )

  });

  onSubmit(): void {

    if (this.employeeForm.valid) {

      this.submitted = true;

      console.log(
        'Reactive Form:',
        this.employeeForm.value
      );

    }

  }
}
