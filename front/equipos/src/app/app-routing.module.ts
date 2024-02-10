import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ObtenerEquiposComponent } from '../app/components/obtener-equipos/obtener-equipos.component';

const routes: Routes = [
  { path: 'obtener-equipos', component: ObtenerEquiposComponent },
  { path: '', component: ObtenerEquiposComponent }, 
  { path: '**', component: ObtenerEquiposComponent } 
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
