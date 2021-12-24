import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { WorkObjectTask } from 'src/app/models/workObjects/workObjectTask';

@Injectable({
  providedIn: 'root'
})
export class WorkObjectTaskService {

  private url = `${window.location.href}api/workObjectTasks`;

  constructor(private http: HttpClient) { }

  getList(): Observable<WorkObjectTask[]> {
    return this.http.get<WorkObjectTask[]>(this.url);
  }

  get(id: number): Observable<WorkObjectTask> {
    return this.http.get<WorkObjectTask>(`${this.url}/${id}`);
  }

  create(data: WorkObjectTask): Observable<void> {
    return this.http.post<void>(this.url, data);
  }

  update(data: WorkObjectTask): Observable<void> {
    return this.http.put<void>(`${this.url}/${data.id}`, data);
  }

  delete(id: number): Observable<void> {
    return this.http.delete<void>(`${this.url}/${id}`);
  }
}
