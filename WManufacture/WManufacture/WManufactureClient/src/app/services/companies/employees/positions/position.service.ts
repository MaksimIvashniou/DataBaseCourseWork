import { HttpClient } from '@angular/common/http';
import { Position } from 'src/app/models/employees/position';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PositionService {

  private url = `${window.location.href}api/positions`;

  constructor(private http: HttpClient) { }

  getList(): Observable<Position[]> {
    return this.http.get<Position[]>(this.url);
  }

  get(id: number): Observable<Position> {
    return this.http.get<Position>(`${this.url}/${id}`);
  }

  create(data: Position): Observable<void> {
    return this.http.post<void>(this.url, data);
  }

  update(data: Position): Observable<void> {
    return this.http.put<void>(`${this.url}/${data.id}`, data);
  }

  delete(id: number): Observable<void> {
    return this.http.delete<void>(`${this.url}/${id}`);
  }
}
