import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { collaborateur } from '../Models/collaborateur';

@Injectable({
  providedIn: 'root'
})
export class CollaborateurService {
  readonly mySIRHAPIUrl = 'https://localhost:7019/api';
  constructor(private http: HttpClient) { }
  
  getCollaborateurList(): Observable<collaborateur[]> {
    return this.http.get<collaborateur[]>(this.mySIRHAPIUrl + '/Collaboraters');
  }
}
