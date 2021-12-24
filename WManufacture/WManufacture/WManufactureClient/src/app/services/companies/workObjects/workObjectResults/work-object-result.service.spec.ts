import { TestBed } from '@angular/core/testing';

import { WorkObjectResultService } from './work-object-result.service';

describe('WorkObjectResultService', () => {
  let service: WorkObjectResultService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(WorkObjectResultService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
