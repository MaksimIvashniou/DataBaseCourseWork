import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PManufactureComponent } from './pmanufacture.component';

describe('PManufactureComponent', () => {
  let component: PManufactureComponent;
  let fixture: ComponentFixture<PManufactureComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PManufactureComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PManufactureComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
