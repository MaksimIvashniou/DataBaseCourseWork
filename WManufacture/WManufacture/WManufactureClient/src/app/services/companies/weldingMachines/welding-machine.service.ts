import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { WeldingMachine } from 'src/app/models/weldingMachines/weldingMachine';

@Injectable({
  providedIn: 'root'
})
export class WeldingMachineService {

  private url = `${window.location.href}api/weldingMachines`;

  constructor(private http: HttpClient) { }

  getList(): Observable<WeldingMachine[]> {
    return this.http.get<WeldingMachine[]>(this.url);
  }

  get(id: number): Observable<WeldingMachine> {
    return this.http.get<WeldingMachine>(`${this.url}/${id}`);
  }

  create(data: WeldingMachine): Observable<void> {
    return this.http.post<void>(this.url, data);
  }

  update(data: WeldingMachine): Observable<void> {
    return this.http.put<void>(`${this.url}/${data.id}`, data);
  }

  delete(id: number): Observable<void> {
    return this.http.delete<void>(`${this.url}/${id}`);
  }
}
