import { HttpClient } from '@angular/common/http'
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Employee } from 'src/app/models/employees/employee';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  private url = `${window.location.href}api/employees`;

  constructor(private http: HttpClient) { }

  getList(): Observable<Employee[]> {
    return this.http.get<Employee[]>(this.url);
  }

  get(id: number): Observable<Employee> {
    return this.http.get<Employee>(`${this.url}/${id}`);
  }

  create(data: Employee): Observable<void> {
    return this.http.post<void>(this.url, data);
  }

  update(data: Employee): Observable<void> {
    return this.http.put<void>(`${this.url}/${data.id}`, data);
  }

  delete(id: number): Observable<void> {
    return this.http.delete<void>(`${this.url}/${id}`);
  }
}
