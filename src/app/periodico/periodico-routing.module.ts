import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {RouterModule, Routes } from '@angular/router';
import { ListadoComponent } from './pages/listado/listado.component';
import { AgregarComponent } from './pages/agregar/agregar.component';
import { HomeComponent } from './pages/home/home.component';
import { NoticiaComponent } from './pages/noticia/noticia.component';
import { EditarComponent } from './editar/editar.component';

const routes: Routes = [
  {
    path: '',
    component: HomeComponent,
    children: [
      {
        path: 'listado', component: ListadoComponent
      },
      {
        path: 'agregar', component: AgregarComponent
      },
      {
        path: 'editar/:id', component: EditarComponent
      },
      {
        path: ':id', component: NoticiaComponent
      },
      {
        path: '**', redirectTo: 'listado'
      }
    ]
  }
]


@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forChild(routes)
  ],
  exports: [
    RouterModule
  ]
})
export class PeriodicoRoutingModule { }
