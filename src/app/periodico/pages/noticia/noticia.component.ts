import {Component, Input, OnInit} from '@angular/core';
import { ActivatedRoute, Router } from "@angular/router";
import { Imagen, NoticiaID } from '../../interfaces/noticia.interface';
import { switchMap } from "rxjs/operators";
import { NoticiasService } from '../../services/noticias.service';

@Component({
  selector: 'app-noticia',
  templateUrl: './noticia.component.html',
  styleUrls: ['./noticia.component.css']
})
export class NoticiaComponent implements OnInit {

  @Input() noticia: NoticiaID [] = [];
  imagenes: Imagen[] =[];

  constructor(private activatedRoute: ActivatedRoute, private noticiasService: NoticiasService, private router: Router) { }

  ngOnInit(): void {
      this.activatedRoute.params.pipe(switchMap(({id}) => this.noticiasService.getNoticiaPorId(id))).subscribe(res => {
        this.noticia = res
        console.log(res);
      });


      this.activatedRoute.params.pipe(switchMap(({id}) => this.noticiasService.getImagenes(id))).subscribe(res => {
        this.imagenes = res
      });
  }

  regresar(){
    this.router.navigate(['/periodico/listado'])
  }

}
