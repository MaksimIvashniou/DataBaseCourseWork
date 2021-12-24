import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Permission } from 'src/app/models/employees/permission';

@Injectable({
  providedIn: 'root'
})
export class PermissionService {

  private url = `${window.location.href}api/permissions`;

  constructor(private http: HttpClient) { }

  get(id: number): Observable<Permission> {
    return this.http.get<Permission>(`${this.url}/${id}`);
  }

  create(data: Permission): Observable<void> {
    return this.http.post<void>(this.url, data);
  }

  update(data: Permission): Observable<void> {
    return this.http.put<void>(`${this.url}/${data.id}`, data);
  }

  delete(id: number): Observable<void> {
    return this.http.delete<void>(`${this.url}/${id}`);
  }
}
