import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { time } from 'console';
import { Observable } from 'rxjs';
import { ModelCharacteristic } from 'src/app/models/weldingMachines/modelCharacteristic';

@Injectable({
  providedIn: 'root'
})
export class ModelCharacteristicService {

  private url = `${window.location.href}api/modelCharacteristics`;

  constructor(private http: HttpClient) { }

  get(id: number): Observable<ModelCharacteristic> {
    return this.http.get<ModelCharacteristic>(`${this.url}/${id}`);
  }

  create(data: ModelCharacteristic): Observable<void> {
    return this.http.post<void>(this.url, data);
  }

  update(data: ModelCharacteristic): Observable<void> {
    return this.http.put<void>(`${this.url}/${data.id}`, data);
  }

  delete(id: number): Observable<void> {
    return this.http.delete<void>(`${this.url}/${id}`);
  }
}
