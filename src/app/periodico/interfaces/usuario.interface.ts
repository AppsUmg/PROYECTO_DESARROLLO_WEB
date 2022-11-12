export interface Usuario {
    rolE_ID: number;
    paiS_ID: number;
    useR_NAME: string;
    password: string;
    nombre: string;
    apellido: string;
    telefono: string;
    correo: string;
    correO_CONFIRMACION: string;
    direccion: string;
    nit: string;
    estado: number;
}


export interface Respuesta {
    MSG: string;
    USUARIO: string
}


export interface Login {
    usuario: string;
    password: string;
    token?: string;
}


export interface Pais {
    ID: number;
    PAIS: string;
}

export interface LoginRespuesta {
    id_Usuario: string;
    usuario: string;
    rol: string;
    nombre: string;
    apellido: string;
    estado: number;
    message: string;
    token: string;
    jsonResult: string;

}