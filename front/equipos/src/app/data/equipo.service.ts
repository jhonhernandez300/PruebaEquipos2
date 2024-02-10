import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
//import { IEquipo } from '../data/IEquipo.ts';

@Injectable({
  providedIn: 'root'
})
export class EquipoService {

  constructor(private http: HttpClient) { }

  EquiposPorMes(mes: number): Promise<any> {
    console.log("servicio EquiposPorMes ");
    return this.http.get<any>('https://localhost:7212/api/Equipo/EquiposPorMes' + "/" + mes)    
    .toPromise();
  }

}
