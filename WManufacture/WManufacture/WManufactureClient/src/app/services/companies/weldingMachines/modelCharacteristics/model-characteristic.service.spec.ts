import { TestBed } from '@angular/core/testing';

import { ModelCharacteristicService } from './model-characteristic.service';

describe('ModelCharacteristicService', () => {
  let service: ModelCharacteristicService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ModelCharacteristicService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
