import { TestBed } from '@angular/core/testing';

import { WeldingMachineService } from './welding-machine.service';

describe('WeldingMachineService', () => {
  let service: WeldingMachineService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(WeldingMachineService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
