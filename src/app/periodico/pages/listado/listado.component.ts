import { Component, OnInit } from '@angular/core';
import { Noticia, Subcategoria } from '../../interfaces/noticia.interface';
import { NoticiasService } from '../../services/noticias.service';

@Component({
  selector: 'app-listado',
  templateUrl: './listado.component.html',
  styleUrls: ['./listado.component.css']
})
export class ListadoComponent implements OnInit {

  noticias: Noticia[] = [];

  subcategory: Subcategoria[] = [];
  subCategoryId: number = 0;

  constructor(private noticiasService: NoticiasService) { }

  ngOnInit(): void {

    this.getNoticias();

    this.noticiasService.getListaSubCategorias().subscribe(res => {
      this.subcategory = res;
      this.subcategory.unshift({ ID_CATEGORIA: '0', CATEGORIA: 'Todos', ID_SUB_CATEGORIA: '0', SUB_CATEGORIA: 'Todas las subcategorias', ESTADO: true });

    })

  }

  onChange(id: number) {
    if (id == 0) {
      this.getNoticias();
    } else {
      this.noticiasService.getArticuloSubCategoria(id).subscribe(res => {
        this.noticias = res;
      })
    }
  }

  getNoticias() {
    this.noticiasService.getNoticias().subscribe(res => {
      this.noticias = res;
    })
  }

}
