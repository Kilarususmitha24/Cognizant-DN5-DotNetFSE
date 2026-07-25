import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-template-form',
  imports: [FormsModule],
  templateUrl: './template-form.html',
  styleUrl: './template-form.css'
})
export class TemplateForm {

  employee = {
    name: '',
    email: '',
    department: ''
  };

  submitted = false;

  onSubmit(): void {
    this.submitted = true;

    console.log('Employee:', this.employee);
  }
}
