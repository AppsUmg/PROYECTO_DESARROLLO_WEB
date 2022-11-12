import { Component, OnInit } from '@angular/core';
import { LoginRespuesta } from '../../interfaces/usuario.interface';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  userInfo= [{APELLIDO:'',NOMBRE: '', ROL: '', MSG: '',USUARIO:'', ESTADO: ''}];
  show: boolean = false;
  rol: string = '';
  constructor() { }

  ngOnInit(): void {
    this.rol = sessionStorage.getItem('rol')!;
    if(this.rol == 'ADMINISTRADOR'){
      this.show = true;
    }

    this.userInfo = JSON.parse(sessionStorage.getItem('jsonResult')!);
  }


  logout(){
    localStorage.removeItem('token');
  }

}
