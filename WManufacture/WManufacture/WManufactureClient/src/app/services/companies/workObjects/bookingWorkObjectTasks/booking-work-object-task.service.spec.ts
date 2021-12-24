import { TestBed } from '@angular/core/testing';

import { BookingWorkObjectTaskService } from './booking-work-object-task.service';

describe('BookingWorkObjectTaskService', () => {
  let service: BookingWorkObjectTaskService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(BookingWorkObjectTaskService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
