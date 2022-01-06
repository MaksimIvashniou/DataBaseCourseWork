import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WeldingsComponent } from './weldings.component';

describe('WeldingsComponent', () => {
  let component: WeldingsComponent;
  let fixture: ComponentFixture<WeldingsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WeldingsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(WeldingsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
