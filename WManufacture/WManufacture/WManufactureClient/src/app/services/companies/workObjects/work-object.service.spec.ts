import { TestBed } from '@angular/core/testing';

import { WorkObjectService } from './work-object.service';

describe('WorkObjectService', () => {
  let service: WorkObjectService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(WorkObjectService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
