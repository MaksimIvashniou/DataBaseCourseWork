import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ModelOfWeldingMachine } from 'src/app/models/weldingMachines/modelOfWeldingMachine';

@Injectable({
  providedIn: 'root'
})
export class ModelOfWeldingMachineService {

  private url = `${window.location.href}api/modelOfWeldingMachines`;

  constructor(private http: HttpClient) { }

  getList(): Observable<ModelOfWeldingMachine[]> {
    return this.http.get<ModelOfWeldingMachine[]>(this.url);
  }

  get(id: number): Observable<ModelOfWeldingMachine> {
    return this.http.get<ModelOfWeldingMachine>(`${this.url}/${id}`);
  }

  create(data: ModelOfWeldingMachine): Observable<void> {
    return this.http.post<void>(this.url, data);
  }

  update(data: ModelOfWeldingMachine): Observable<void> {
    return this.http.put<void>(`${this.url}/${data.id}`, data);
  }

  delete(id: number): Observable<void> {
    return this.http.delete<void>(`${this.url}/${id}`)
  }
}
