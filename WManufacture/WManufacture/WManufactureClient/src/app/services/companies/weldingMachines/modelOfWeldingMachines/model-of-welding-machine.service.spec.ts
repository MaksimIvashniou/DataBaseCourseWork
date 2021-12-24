import { TestBed } from '@angular/core/testing';

import { ModelOfWeldingMachineService } from './model-of-welding-machine.service';

describe('ModelOfWeldingMachineService', () => {
  let service: ModelOfWeldingMachineService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ModelOfWeldingMachineService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
