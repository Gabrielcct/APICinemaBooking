import { Routes } from '@angular/router';
import { LoginComponent } from './User/login/login.component';
import { RegisterComponent } from './User/register/register.component';

export const routes: Routes = [
    { path: 'login', component: LoginComponent },
    { path: 'register', component: RegisterComponent },
];
