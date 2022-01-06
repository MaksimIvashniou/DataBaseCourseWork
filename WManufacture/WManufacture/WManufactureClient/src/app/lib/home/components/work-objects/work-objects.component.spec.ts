import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WorkObjectsComponent } from './work-objects.component';

describe('WorkObjectsComponent', () => {
  let component: WorkObjectsComponent;
  let fixture: ComponentFixture<WorkObjectsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WorkObjectsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(WorkObjectsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
