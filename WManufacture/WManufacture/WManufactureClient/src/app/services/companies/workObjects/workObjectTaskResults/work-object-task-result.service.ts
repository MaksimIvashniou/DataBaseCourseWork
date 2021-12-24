import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { WorkObjectTaskResult } from 'src/app/models/workObjects/workObjectTaskResult';

@Injectable({
  providedIn: 'root'
})
export class WorkObjectTaskResultService {

  private url = `${window.location.href}api/workObjectTaskResults`;

  constructor(private http: HttpClient) { }

  get(id: number): Observable<WorkObjectTaskResult> {
    return this.http.get<WorkObjectTaskResult>(`${this.url}/${id}`);
  }

  create(data: WorkObjectTaskResult): Observable<void> {
    return this.http.post<void>(this.url, data);
  }

  update(data: WorkObjectTaskResult): Observable<void> {
    return this.http.put<void>(`${this.url}/${data.id}`, data);
  }

  delete(id: number): Observable<void> {
    return this.http.delete<void>(`${this.url}/${id}`);
  }
}
