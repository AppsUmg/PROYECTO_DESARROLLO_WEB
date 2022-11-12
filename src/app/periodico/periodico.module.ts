import {CUSTOM_ELEMENTS_SCHEMA, NgModule} from '@angular/core';
import { CommonModule } from '@angular/common';
import { AgregarComponent } from './pages/agregar/agregar.component';
import { NoticiaComponent } from './pages/noticia/noticia.component';
import { HomeComponent } from './pages/home/home.component';
import { ListadoComponent } from './pages/listado/listado.component';
import { PeriodicoRoutingModule } from './periodico-routing.module';
import { FlexLayoutModule } from '@angular/flex-layout';
import { MaterialModule } from '../material/material.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { LoginComponent } from './pages/login/login.component';
import { NoticiaTarjetaComponent } from './components/noticia-tarjeta/noticia-tarjeta.component';
import { RegisterComponent } from './pages/login/register/register.component';
import { EditarComponent } from './editar/editar.component';
import { DialogoComponent } from './components/dialogo/dialogo.component';
import { MatDialogModule } from '@angular/material/dialog';
import { MatTableModule } from '@angular/material/table';



@NgModule({
  declarations: [
    AgregarComponent,
    NoticiaComponent,
    HomeComponent,
    ListadoComponent,
    NoticiaTarjetaComponent,
    LoginComponent,
    RegisterComponent,
    EditarComponent,
    DialogoComponent,
  ],
  imports: [
    CommonModule,
    FormsModule,
    FlexLayoutModule,
    MaterialModule,
    PeriodicoRoutingModule,
    ReactiveFormsModule,
    MatDialogModule,
    MatTableModule
  ],
  schemas: [
    CUSTOM_ELEMENTS_SCHEMA
  ],
})
export class PeriodicoModule { }
