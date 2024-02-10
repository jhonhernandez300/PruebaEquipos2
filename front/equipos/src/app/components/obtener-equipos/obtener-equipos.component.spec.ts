import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ObtenerEquiposComponent } from './obtener-equipos.component';

describe('ObtenerEquiposComponent', () => {
  let component: ObtenerEquiposComponent;
  let fixture: ComponentFixture<ObtenerEquiposComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ObtenerEquiposComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ObtenerEquiposComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
