import { IEquipo } from '../../data/IEquipo';
import { EquipoService } from '../../data/equipo.service.js';
import {RouterModule} from '@angular/router';
import { Component, OnInit } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { FormsModule } from '@angular/forms';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-obtener-equipos',
  templateUrl: './obtener-equipos.component.html',
  styleUrl: './obtener-equipos.component.css'
})
export class ObtenerEquiposComponent implements OnInit {
  equipo: IEquipo = {
    CodigoEvento: 0,
    Fecha: new Date(),
    Propietario: '',
    CTE: '', 
    Subestacion: '',
    Elemento: '',
    TipoDeEquipo: '',
    NombreEquipo: '',
    PL1: '',
    PL2: '',
    Rdf: '',
    SOE: '',
    Opciones: ''
  };

  items!: any[];
  myForm!: FormGroup;    
  submitted = false;

  constructor(private equipoService: EquipoService, private formBuilder: FormBuilder) { }

  iniciarFormulario(){
    this.myForm = this.formBuilder.group({                     
      mes: ['', ]      
    });
}

  ngOnInit(): void {
    this.iniciarFormulario();
  }

  get form(): { [key: string]: AbstractControl; }
  {
      return this.myForm.controls;
  }

  onSubmit() {    
    this.submitted = true;
    console.log("Form value ", this.myForm.value);    

    this.equipoService.EquiposPorMes(this.myForm.value.mes).then((response) => {
      console.log('Respuesta de EquiposPorMes ', response);
      this.items = response;
    })
    .catch((error) => {
      console.error(': ', error);
    })
  }  
}
