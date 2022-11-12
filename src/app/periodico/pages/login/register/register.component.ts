import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { UsuarioService } from '../../../services/usuario.service';
import { Pais, Respuesta } from '../../../interfaces/usuario.interface';
import { Router } from '@angular/router';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  registerForm = new FormGroup({
    rolE_ID: new FormControl(3, [Validators.required]),
    paiS_ID: new FormControl('', [Validators.required]),
    useR_NAME: new FormControl('', [Validators.required]),
    password: new FormControl('', [Validators.required]),
    nombre: new FormControl('', [Validators.required]),
    apellido: new FormControl('', [Validators.required]),
    telefono: new FormControl('', [Validators.required]),
    correo: new FormControl('', [Validators.required, Validators.email]),
    correO_CONFIMACION: new FormControl('', [Validators.required, Validators.email]),
    direccion: new FormControl('', [Validators.required]),
    nit: new FormControl('', [Validators.required]),
    estado: new FormControl(1, [Validators.required]),

  })

  pais: Pais[] = [];
  respuesta: Respuesta[] = [];

  showAlert = true;
  confirmacionPassword: string = '';


  public registerMessage?: String;
  constructor(private serviceUsuario: UsuarioService, private router: Router) {
  }

  ngOnInit(): void {
    this.serviceUsuario.getPais().subscribe(res => {
      this.pais = res
    })
  }


  onSubmit() {

    if (this.registerForm.value.password === this.confirmacionPassword) {
      this.registerForm.value.Pais = Number(this.registerForm.value.Pais);
      this.serviceUsuario.crearUsuario(this.registerForm.value).subscribe(res => {
        this.respuesta = res;
        alert(this.respuesta[0].MSG);
        this.router.navigate(['/login'])
      })
    } else {
      this.registerMessage = "Las contraseñas no coinciden"
    }
  }
}
