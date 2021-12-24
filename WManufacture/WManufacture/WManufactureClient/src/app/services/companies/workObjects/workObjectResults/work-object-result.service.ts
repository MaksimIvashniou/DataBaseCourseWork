import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { WorkObjectResult } from 'src/app/models/workObjects/workObjectResult';

@Injectable({
  providedIn: 'root'
})
export class WorkObjectResultService {

  private url = `${window.location.href}api/workObjectResults`;

  constructor(private http: HttpClient) { }

  get(id: number): Observable<WorkObjectResult> {
    return this.http.get<WorkObjectResult>(`${this.url}/${id}`);
  }

  create(data: WorkObjectResult): Observable<void> {
    return this.http.post<void>(this.url, data);
  }

  update(data: WorkObjectResult): Observable<void> {
    return this.http.put<void>(`${this.url}/${data.id}`, data);
  }

  delete(id: number): Observable<void> {
    return this.http.delete<void>(`${this.url}/${id}`);
  }
}
