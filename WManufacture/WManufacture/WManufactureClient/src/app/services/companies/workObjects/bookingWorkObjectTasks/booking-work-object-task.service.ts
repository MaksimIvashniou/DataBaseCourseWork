import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { BookingWorkObjectTask } from 'src/app/models/workObjects/bookingWorkObjectTask';

@Injectable({
  providedIn: 'root'
})
export class BookingWorkObjectTaskService {

  private url = `${window.location.href}api/bookingWorkObjectTasks`;

  constructor(private http: HttpClient) { }

  getList(): Observable<BookingWorkObjectTask[]> {
    return this.http.get<BookingWorkObjectTask[]>(this.url);
  }

  get(id: number): Observable<BookingWorkObjectTask> {
    return this.http.get<BookingWorkObjectTask>(`${this.url}/${id}`);
  }

  create(data: BookingWorkObjectTask): Observable<void> {
    return this.http.post<void>(this.url, data);
  }

  update(data: BookingWorkObjectTask): Observable<void> {
    return this.http.put<void>(`${this.url}/${data.id}`, data);
  }

  delete(id: number): Observable<void> {
    return this.http.delete<void>(`${this.url}/${id}`);
  }
}
