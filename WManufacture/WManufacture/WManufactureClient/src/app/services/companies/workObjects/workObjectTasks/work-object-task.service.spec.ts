import { TestBed } from '@angular/core/testing';

import { WorkObjectTaskService } from './work-object-task.service';

describe('WorkObjectTaskService', () => {
  let service: WorkObjectTaskService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(WorkObjectTaskService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
