import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Profissao } from '../dominio/profissao';

@Injectable({
  providedIn: 'root'
})
export class ProfissaoService {

  constructor(private http: HttpClient) { }

  url = `${environment.apiUrl}/profissoes`;

  buscarTodasProfisao(): Observable<Profissao[]> {
    return this.http.get<Profissao[]>(`${this.url}`);
  }

  salvarProfissao(profissao: Profissao): Observable<Profissao> {
    return this.http.post<Profissao>(this.url, profissao);
  }

  deletarProfissao(id: number): Observable<any> {
    return this.http.delete<Profissao>(`${this.url}/${id}`);
  }

  editarProfissao(profissao: Profissao): Observable<Profissao> {
    return this.http.put<Profissao>(this.url, profissao);
  }
  
}
