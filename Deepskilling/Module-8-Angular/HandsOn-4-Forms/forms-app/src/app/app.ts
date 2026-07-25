import { Component } from '@angular/core';

import { TemplateForm } from './template-form/template-form';
import { ReactiveForm } from './reactive-form/reactive-form';

@Component({
  selector: 'app-root',

  imports: [
    TemplateForm,
    ReactiveForm
  ],

  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {

  title = 'Angular Forms Hands-On';

}
