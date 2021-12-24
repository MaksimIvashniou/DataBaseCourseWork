import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Company } from 'src/app/models/company';

@Injectable({
  providedIn: 'root'
})
export class CompanyService {

  private url = `${window.location.href}api/companies`;

  constructor(private http: HttpClient) { }

  getList(): Observable<Company[]> {
    return this.http.get<Company[]>(this.url);
  }

  get(id: number): Observable<Company> {
    return this.http.get<Company>(`${this.url}/${id}`);
  }

  create(data: Company): Observable<void> {
    return this.http.post<void>(this.url, data);
  }

  update(data: Company): Observable<void> {
    return this.http.put<void>(`${this.url}/${data.id}`, data);
  }

  delete(id: number): Observable<void> {
    return this.http.delete<void>(`${this.url}/${id}`);
  }
}
