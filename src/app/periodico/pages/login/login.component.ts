import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Login } from '../../interfaces/usuario.interface';
import { UsuarioService } from '../../services/usuario.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  loginForm = new FormGroup({
    user: new FormControl('', [Validators.required]),
    password: new FormControl('', [Validators.required])
  })
  public loginError?: String;

  credenciales: Login = {
    usuario: '',
    password: '',
    token: ''
  }

  constructor(private router: Router, private serviceUsuario: UsuarioService) {
  }

  ngOnInit(): void {
  }

  onSubmit() {

    try {
      this.serviceUsuario.login(this.credenciales).subscribe(res => {
        sessionStorage.setItem('rol', res.rol);
        sessionStorage.setItem('id_usuario', res.id_Usuario);
        sessionStorage.setItem('jsonResult', res.jsonResult);
        sessionStorage.setItem('token', res.token!);
        alert("¡Sesión iniciada!");
        this.router.navigate(['/periodico/listado']);
      });
    } catch {
      this.loginError = "Credenciales incorrectas";
    }

  }
}


