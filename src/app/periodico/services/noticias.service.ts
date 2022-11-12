import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Categoria, Noticia, Subcategoria, Visibilidad, Estado, NoticiaNueva, NoticiaID, Imagen, ImagenAgregar } from '../interfaces/noticia.interface';

@Injectable({
  providedIn: 'root'
})
export class NoticiasService {


  constructor(private http: HttpClient) { }

  getNoticias(): Observable<Noticia[]>{
    return this.http.get<Noticia[]>(`https://desarrollowebumg.azurewebsites.net/Articulo`)
  }
  

  getNoticiaPorId(id: string): Observable<NoticiaID[]>{
    return this.http.get<NoticiaID[]>(`https://desarrollowebumg.azurewebsites.net/Articulo/${id}`);
  }
  
  editarNoticia(noticia: NoticiaNueva): Observable<any>{
    return this.http.put<any>(`https://desarrollowebumg.azurewebsites.net/Articulo`, noticia);
  }

  agregarNoticia(noticia: NoticiaNueva): Observable<any>{
    return this.http.post<any>(`https://desarrollowebumg.azurewebsites.net/Articulo`, noticia);
  }

  actualizarNoticia(noticia: Noticia): Observable<Noticia>{
    return this.http.put<Noticia>(`https://desarrollowebumg.azurewebsites.net/Articulo?ID_ARTICULO=${noticia.ID_ARTICULO}`, noticia);
  }

  borrarNoticia(id: string): Observable<any>{
    return this.http.delete<any>(`https://desarrollowebumg.azurewebsites.net/Articulo/${id}`);
  }

  getCategorias():  Observable<Categoria[]>{
    return this.http.get<Categoria[]>(`https://desarrollowebumg.azurewebsites.net/Categorias`)
  }

  getSubcategorias(id: any):  Observable<Subcategoria[]>{
    return this.http.get<Subcategoria[]>(`https://desarrollowebumg.azurewebsites.net/SubCategorias/${id}`);
  }
  getListaSubCategorias():  Observable<Subcategoria[]>{
    return this.http.get<Subcategoria[]>(`https://desarrollowebumg.azurewebsites.net/SubCategorias`);
  }

  getVisibilidad():  Observable<Visibilidad[]>{
    return this.http.get<Visibilidad[]>(`https://desarrollowebumg.azurewebsites.net/Articulo/Visibilidad`)
  }

  getEstados():  Observable<Estado[]>{
    return this.http.get<Estado[]>(`https://desarrollowebumg.azurewebsites.net/Articulo/Estados`)
  }

  getArticuloSubCategoria(id: any):  Observable<Noticia[]>{
    return this.http.get<Noticia[]>(`https://desarrollowebumg.azurewebsites.net/Articulo/SubCategoria/${id}`);
  }

  getImagenes(id: any):  Observable<Imagen[]>{
    return this.http.get<Imagen[]>(`https://desarrollowebumg.azurewebsites.net/Articulo/Imagenes/${id}`);
  }


  agregarImagen(imagen: ImagenAgregar): Observable<any>{
    return this.http.post<any>(`https://desarrollowebumg.azurewebsites.net/Articulo/Imagenes/`, imagen);
  }
}
