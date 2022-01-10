import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WManufactureComponent } from './wmanufacture.component';

describe('WManufactureComponent', () => {
  let component: WManufactureComponent;
  let fixture: ComponentFixture<WManufactureComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WManufactureComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(WManufactureComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
