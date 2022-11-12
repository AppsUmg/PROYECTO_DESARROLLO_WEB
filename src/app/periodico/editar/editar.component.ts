import { Component, EventEmitter, Input, OnInit, Output, ViewChild } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { switchMap } from "rxjs/operators";
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Estado, Imagen, ImagenAgregar, NoticiaEditada, NoticiaID, Subcategoria, Visibilidad } from '../interfaces/noticia.interface';
import { NoticiasService } from '../services/noticias.service';
import { MatDialog } from '@angular/material/dialog';
import { DialogoComponent } from '../components/dialogo/dialogo.component';
import { MatTable } from '@angular/material/table';


@Component({
  selector: 'app-editar',
  templateUrl: './editar.component.html',
  styleUrls: ['./editar.component.css']
})
export class EditarComponent implements OnInit {
  formAdd = new FormGroup({
    user: new FormControl('', [Validators.required]),
    password: new FormControl('', [Validators.required])
  })



  status: Estado[] = [];

  subcategory: Subcategoria[] = [];


  visibility: Visibilidad[] = [];


  submit() {

  }
  @Input() error: string | null;

  @Output() submitEM = new EventEmitter();

  idNuevo!: string;

  noticia: NoticiaID[] = [{
    ID_ARTICULO: '',
    ID_CATEGORIA: '',
    ID_SUB_CATEGORIA: '',
    TITULO: '',
    SUB_CATEGORIA: '',
    TIPO_VISUALIZACION: '',
    AUTOR: '',
    FECHA: '',
    ESTADO: '',
    ESTADO_DESCRIPCION: '',
    CONTENIDO: '',
    CATEGORIA: '',
    IMAGEN_URL: '',
    ID_VISUALIZACION: ''
  }]



  noticiaEditada: NoticiaEditada = {
    iD_ARTICULO: 0,
    titulo: '',
    iD_SUB_CATEGORIA: 0,
    iD_VISIBILIDAD: 0,
    iD_USUARIO_PUBLICADOR: 0,
    iD_ESTADO: 0,
    contenido: '',
  }


  categoria: number = 0;

  columnas: string[] = ['url'];
  imagenes: Imagen[] = []
  imagennueva: ImagenAgregar = { iD_ARTICULO: 0, url: "", estado: true };
  @ViewChild(MatTable) tabla1!: MatTable<Imagen>;

  constructor(private noticiasService: NoticiasService, private activatedRoute: ActivatedRoute, private router: Router, public dialogo: MatDialog) {
    this.error = 'error'
  }

  ngOnInit(): void {

    this.noticiasService.getListaSubCategorias().subscribe(res => {
      this.subcategory = res;
    })

    this.noticiasService.getVisibilidad().subscribe(res => {
      this.visibility = res;
    })

    this.noticiasService.getEstados().subscribe(res => {
      this.status = res;
    })

    this.activatedRoute.params.pipe(switchMap(({ id }) => this.noticiasService.getNoticiaPorId(id))).subscribe(res => {
      this.noticia = res;
      this.noticiasService.getImagenes(this.noticia[0].ID_ARTICULO).subscribe(res => {
        this.imagenes = res;
      })
    })
  }


  mostrarDialogo(): void {
    this.dialogo
      .open(DialogoComponent, {
        data: `¿Deseas eliminar esta noticia?`
      })
      .afterClosed()
      .subscribe((confirmado: Boolean) => {
        if (confirmado) {
          this.borrar();
          alert("¡Noticia eliminada!");
          this.router.navigate(['/periodico/listado'])
        } else {
        }
      });
  }


  borrar() {
    this.noticiasService.borrarNoticia(this.noticia[0].ID_ARTICULO!).subscribe(res => {
      this.router.navigate(['/periodico']);
    })
  }

  regresar() {
    this.router.navigate(['/periodico/listado'])
  }

  onSubmit() {
    this.noticiaEditada = {
      iD_ARTICULO: parseInt(this.noticia[0].ID_ARTICULO),
      titulo: this.noticia[0].TITULO,
      iD_SUB_CATEGORIA: parseInt(this.noticia[0].ID_SUB_CATEGORIA),
      iD_VISIBILIDAD: parseInt(this.noticia[0].ID_VISUALIZACION),
      iD_USUARIO_PUBLICADOR: parseInt(sessionStorage.getItem('id_usuario')!),
      iD_ESTADO: parseInt(this.noticia[0].ESTADO),
      contenido: this.noticia[0].CONTENIDO,
    }
    this.noticiasService.editarNoticia(this.noticiaEditada).subscribe(res => {
      this.imagennueva.iD_ARTICULO = parseInt(this.noticia[0].ID_ARTICULO);

      if (this.imagennueva.url !== "") {
        this.noticiasService.agregarImagen(this.imagennueva).subscribe(res => {
          alert("¡Noticia Editada!");
          this.router.navigate(['/periodico/listado']);
        });
      } else {
        alert("¡Noticia Editada!");
        this.router.navigate(['/periodico/listado']);
      }

    });
  }
}
