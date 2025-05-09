import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';

import { RouterModule, Routes } from '@angular/router';
import { CitiesComponent } from './cities/cities.component';
import { LoginComponent } from './login/login.component';

const routes: Routes = [
  { path: "cities", component: CitiesComponent },
  { path: "login", component: LoginComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
