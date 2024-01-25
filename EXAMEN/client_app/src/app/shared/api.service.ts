// src/app/shared/api.service.ts
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  private baseUrl = 'https://localhost:5001/api'; // Actualizați cu adresa API-ului .NET

  constructor(private http: HttpClient) {}

  getEvenimente(): Observable<any[]> {
    return this.http.get<any[]>(`${this.baseUrl}/eveniment`);
  }

  // Adăugați metode similare pentru Participanti, Clasa1, Clasa2 etc.
}
