import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Candidato } from '../dominio/candidato';

@Injectable({
  providedIn: 'root'
})
export class CandidatoService {

  constructor(private http: HttpClient) { }

  url = `${environment.apiUrl}/candidatos`;

  buscarCandidato(): Observable<Candidato[]> {
    return this.http.get<Candidato[]>(`${this.url}`);
  }

  salvarCandidato(candidato: Candidato): Observable<Candidato> {
    return this.http.post<Candidato>(this.url, candidato);
  }

  deletarCandidato(id: number): Observable<any> {
    return this.http.delete<Candidato>(`${this.url}/${id}`);
  }
  
  editarCandidato(candidato: Candidato): Observable<Candidato> {
    return this.http.put<Candidato>(this.url, candidato);
  }
}