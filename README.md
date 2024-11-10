# Tienda CRUD

Proyecto de Programacion Orientada a Objetos, CRUD para una Tienda usando C# y MySql

![gatitoBesando](https://github.com/user-attachments/assets/96511b00-b58e-4311-b192-2e2a5351f374)

<br>

# Descargar proyecto
Utiliza la opcion de `Download Zip` dentro del boton `Code` en la parte superior del repositorio o si tienes `Git` instalado utiliza el siguiente comando en tu consola.
```bash
git clone https://github.com/Suprimir/TiendaCRUD.git
```
> Para pasar del login usa estas credenciales: [Usuario: admin - Contraseña: 123]

<br>

# Crear Base de Datos

Crear la base de datos `Tienda` usando `MySQL Workbench` o `MySQL Server`.
```bash
CREATE DATABASE tienda;
```

Seleccionar la base de datos recien creada para poder crear las tablas.
```bash
USE tienda;
```

Crear tabla `Categorias`.
```bash
CREATE TABLE categorias (
    categoria_id int primary key auto_increment,
    nombre varchar(45) not null,
    precio_minimo double not null
);
```

Crear tabla `Productos`.
```bash
CREATE TABLE productos (
    producto_id int primary key auto_increment,
    nombre varchar(60) not null,
    precio double not null,
    codigoBarras varchar(20) not null,
    categoria_id int not null,
    FOREIGN KEY (categoria_id) REFERENCES categorias(categoria_id)
);
```

<br>

# Conectar Base de Datos a la Aplicacion

Abre el archivo `App.config` y edita el `connectionString` para que coincida con los datos de tu servidor de MySql
```bash
connectionString="Server=localhost;Database=tienda;User Id=tuUsuario;Password=tuContraseña;"
```
