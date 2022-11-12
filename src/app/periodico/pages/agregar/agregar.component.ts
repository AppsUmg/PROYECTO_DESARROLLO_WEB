import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { NoticiasService } from '../../services/noticias.service';
import { Categoria, Estado, NoticiaNueva, Subcategoria, Visibilidad } from '../../interfaces/noticia.interface';

@Component({
  selector: 'app-agregar',
  templateUrl: './agregar.component.html',
  styleUrls: ['./agregar.component.css']
})
export class AgregarComponent implements OnInit {

  formAdd = new FormGroup({
    user: new FormControl('', [Validators.required]),
    password: new FormControl('', [Validators.required])
  })

  status: Estado [] = [];

  category: Categoria [] = [];

  subcategory: Subcategoria [] = [];


  visibility: Visibilidad [] = [];


  submit() {

  }
  @Input() error: string | null;

  @Output() submitEM = new EventEmitter();

  idNuevo!: string;

  noticiaNueva: NoticiaNueva = {
    titulo: '',
    iD_SUB_CATEGORIA: 0,
    iD_VISIBILIDAD: 0,
    iD_USUARIO_PUBLICADOR: 0,
    iD_ESTADO: 0,
    contenido: '',
  }  

  categoria: number = 0;
  constructor(private noticiasService: NoticiasService, private activatedRoute: ActivatedRoute, private router: Router) { 
    this.error = 'error'
  }

  ngOnInit(): void {

    this.noticiasService.getCategorias().subscribe(res => {
      this.category = res;
    })

    this.noticiasService.getVisibilidad().subscribe(res => {
      this.visibility = res;
    })

    this.noticiasService.getEstados().subscribe(res => {
      this.status = res;
    })
  }

  guardar(){
      this.noticiaNueva.iD_USUARIO_PUBLICADOR =  parseInt(sessionStorage.getItem('id_usuario')!);
      this.noticiasService.agregarNoticia(this.noticiaNueva).subscribe(res => {
        console.log(res)
        alert("¡Noticia Agregada!");
        this.router.navigate(['/periodico/listado']);
      });
      
  }

  regresar(){
    this.router.navigate(['/periodico/listado'])
  }

  onChange(id: number){
    this.noticiasService.getSubcategorias(id).subscribe(res => {
      this.subcategory = res;
    })
  }

}
