# Tienda CRUD

Proyecto de Programacion Orientada a Objetos, CRUD para una Tienda usando C# y MySql

![gatitoBesando](https://github.com/user-attachments/assets/96511b00-b58e-4311-b192-2e2a5351f374)

# Crear Base de Datos

Crear la base de datos **Tienda** usando **MySQL Workbench** o **MySQL Server**.
```bash
CREATE DATABASE tienda;
```

Seleccionar la base de datos recien creada para poder crear las tablas.
```bash
USE tienda;
```

Crear tabla **Categorias**.
```bash
CREATE TABLE categorias (
    categoria_id int primary key auto_increment,
    nombre varchar(45) not null,
    precio_minimo double not null
);
```

Crear tabla **Productos**.
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

# Conectar Base de Datos a la Aplicacion

Abre el archivo `App.config` y edita el `connectionString` para que coincida con los datos de tu servidor de MySql
```bash
connectionString="Server=localhost;Database=tienda;User Id=tuUsuario;Password=tuContraseña;"
```
