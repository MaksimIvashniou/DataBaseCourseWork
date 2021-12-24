import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { PersonalInfo } from 'src/app/models/employees/personalInfo'

@Injectable({
  providedIn: 'root'
})
export class ProfileInfoService {

  private url = `${window.location.href}api/profileInfos`;

  constructor(private http: HttpClient) { }

  get(id: number): Observable<PersonalInfo> {
    return this.http.get<PersonalInfo>(`${this.url}/${id}`);
  }

  create(data: PersonalInfo): Observable<void> {
    return this.http.post<void>(this.url, data);
  }

  update(data: PersonalInfo): Observable<void> {
    return this.http.put<void>(`${this.url}/${data.id}`, data);
  }

  delete(id: number): Observable<void> {
    return this.http.delete<void>(`${this.url}/${id}`);
  }
}
