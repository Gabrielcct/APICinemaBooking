import { Component } from '@angular/core';
import { RegisterService } from './register.service';

import { FormsModule, ReactiveFormsModule } from '@angular/forms';
@Component({
  selector: 'app-register',
  standalone: true,
  imports: [FormsModule, ReactiveFormsModule],
  templateUrl: './register.component.html',
  styleUrl: './register.component.scss'
})
export class RegisterComponent {
    userName: string = '';
    password :string = '';

  constructor(
    private registerService: RegisterService
  ) { }

  onSubmit(): void {
    let body = {
      userName: this.userName,
      password: this.password,
      userId: 0,
      accountType: 'User'
    };
    
    this.registerService.register(body);
  }
}
