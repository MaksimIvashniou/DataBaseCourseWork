import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { WorkObject } from 'src/app/models/workObjects/workObject';

@Injectable({
  providedIn: 'root'
})
export class WorkObjectService {

  private url = `${window.location.href}api/workObjects`;

  constructor(private http: HttpClient) { }

  getList(): Observable<WorkObject[]> {
    return this.http.get<WorkObject[]>(this.url);
  }

  get(id: number): Observable<WorkObject> {
    return this.http.get<WorkObject>(`${this.url}/${id}`);
  }

  create(data: WorkObject): Observable<void> {
    return this.http.post<void>(this.url, data);
  }

  update(data: WorkObject): Observable<void> {
    return this.http.put<void>(`${this.url}/${data.id}`, data);
  }

  delete(id: number): Observable<void> {
    return this.http.delete<void>(`${this.url}/${id}`);
  }
}
