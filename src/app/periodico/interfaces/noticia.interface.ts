export interface Noticia {
  ID_ARTICULO?: string;
  TITULO: string;
  SUB_CATEGORIA: string;
  TIPO_VISUALIZACION: string;
  AUTOR: string;
  FECHA: string;
  ESTADO: boolean;
  ESTADO_DESCRIPCION:  string;
  CONTENIDO: string;
  IMAGEN_URL: string;
}

export interface NoticiaID {
  ID_ARTICULO: string;
  ID_CATEGORIA: string;
  ID_SUB_CATEGORIA: string,
  TITULO: string;
  SUB_CATEGORIA: string;
  TIPO_VISUALIZACION: string;
  AUTOR: string;
  FECHA: string;
  ESTADO: string;
  ESTADO_DESCRIPCION:  string;
  CONTENIDO: string;
  CATEGORIA: string;
  IMAGEN_URL: string;
  ID_VISUALIZACION: string;
}

export interface NoticiaNueva {
  titulo: string;
  iD_SUB_CATEGORIA: number;
  iD_VISIBILIDAD: number;
  iD_USUARIO_PUBLICADOR: number;
  iD_ESTADO: number;
  contenido: string;
}



export interface NoticiaEditada {
  iD_ARTICULO: number;
  titulo: string;
  iD_SUB_CATEGORIA: number;
  iD_VISIBILIDAD: number;
  iD_USUARIO_PUBLICADOR: number;
  iD_ESTADO: number;
  contenido: string;
}

export interface Categoria {
  ID: string;
  CATEGORIA: string;
}


export interface Subcategoria {
  ID_CATEGORIA: string;
  CATEGORIA: string;
  ID_SUB_CATEGORIA: string;
  SUB_CATEGORIA: string;
  ESTADO: boolean
}



export interface Visibilidad {
  ID: string;
  NOMBRE: string;
  DESCRIPCION: string
}

export interface Estado {
  ESTADO: string;
  DESCRIPCION: string;
}

export interface Imagen {
  ID_ARTICULO: string;
  URL_IMAGEN: string;
  ESTADO: string;
}



export interface ImagenAgregar {
  iD_ARTICULO: number;
  url: string;
  estado: boolean;
}

