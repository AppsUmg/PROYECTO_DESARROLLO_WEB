import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Usuario, Login, Pais, Respuesta, LoginRespuesta } from '../interfaces/usuario.interface';

@Injectable({
    providedIn: 'root'
  })
  export class UsuarioService {
  
  
    constructor(private http: HttpClient) { }


    crearUsuario(usuario: Usuario): Observable<Respuesta[]>{
        return this.http.post<Respuesta[]>(`https://desarrollowebumg.azurewebsites.net/Usuario`, usuario)
      }


      
    login(login: Login): Observable<LoginRespuesta>{
        return this.http.post<LoginRespuesta>(`https://desarrollowebumg.azurewebsites.net/Login`, login)
      }


      getPais(): Observable<Pais[]>{
        return this.http.get<Pais[]>(`https://desarrollowebumg.azurewebsites.net/Region`)
      }
    
  }