import { TestBed } from '@angular/core/testing';

import { WorkObjectTaskResultService } from './work-object-task-result.service';

describe('WorkObjectTaskResultService', () => {
  let service: WorkObjectTaskResultService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(WorkObjectTaskResultService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
