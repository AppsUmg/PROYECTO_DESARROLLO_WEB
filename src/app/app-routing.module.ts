import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './periodico/pages/login/login.component';
import { ErrorPageComponent } from './shared/error-page/error-page.component';
import { RegisterComponent } from './periodico/pages/login/register/register.component';

const routes: Routes = [
  {
    path: 'periodico',
    loadChildren: () => import('./periodico/periodico.module').then(m => m.PeriodicoModule)
  },
  {
    path: '404',
    component: ErrorPageComponent
  },
  {
    path: 'login',
    component: LoginComponent
  },
  {
    path: 'register',
    component: RegisterComponent
  },
  {
    path: '**',
    redirectTo: 'login'
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
