// app.service.ts
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class AppService {
  private apiUrl = 'localhost:5001'; 

  constructor(private http: HttpClient) {}

  getEvents(): Observable<any> {
    return this.http.get(`${this.apiUrl}/events`);
  }

  getParticipants(): Observable<any> {
    return this.http.get(`${this.apiUrl}/participants`);
  }
}

