import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Noticia } from '../../interfaces/noticia.interface';

@Component({
  selector: 'app-noticia-tarjeta',
  templateUrl: './noticia-tarjeta.component.html',
  styleUrls: ['./noticia-tarjeta.component.css']
})
export class NoticiaTarjetaComponent implements OnInit {

  @Input() item!: Noticia;

  show: boolean = false;
  rol: string = '';
  

  constructor(private router: Router) {
  }

  ngOnInit(): void {
    this.rol = sessionStorage.getItem('rol')!;
    this.item.CONTENIDO = this.item.CONTENIDO.substring(0, 300);

    if(this.rol == 'ADMINISTRADOR'){
      this.show = true;
    }
  }


  ir(){
    this.router.navigate(['/periodico', this.item.ID_ARTICULO]);
  }

}
