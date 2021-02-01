using SQLHelperDB;
using System;


namespace UD18_BD_VS
{
    class Program
    {
        static void Main(string[] args)
        {
            //GenerarEjercicio1();
            //GenerarEjercicio2();
            //GenerarEjercicio3();
            //GenerarEjercicio4();
            //GenerarEjercicio5();
            //GenerarEjercicio6();
            //GenerarEjercicio7();
            //GenerarEjercicio8();
            //GenerarEjercicio9();
        }
        public static void GenerarEjercicio1()
        {
            Operacion op = new Operacion();

            string cadena = "";
            string nombreBD = "UD18_EJ1";

            op.CrearBD(nombreBD);
            op.ConectarBD(nombreBD);

            cadena = "USE UD18_EJ1;";
            op.Ejecutar(cadena);

            cadena = @"CREATE TABLE fabricantes (
                codigo int NOT NULL IDENTITY(1,1) PRIMARY KEY,
                nombre nvarchar(100)
            )";
            op.Ejecutar(cadena);

            cadena = @"CREATE TABLE articulos(
                codigo int NOT NULL IDENTITY(1,1) PRIMARY KEY,
                nombre nvarchar(100) ,
                precio int,
                fabricante int FOREIGN KEY REFERENCES fabricantes(codigo)
            )";
            op.Ejecutar(cadena);

            cadena = @"INSERT INTO fabricantes(nombre) VALUES ('fabricante1')";
            op.Ejecutar(cadena);
            cadena = @"INSERT INTO fabricantes(nombre) VALUES ('fabricante2')";
            op.Ejecutar(cadena);
            cadena = @"INSERT INTO fabricantes(nombre) VALUES ('fabricante3')";
            op.Ejecutar(cadena);
            cadena = @"INSERT INTO fabricantes(nombre) VALUES ('fabricante4')";
            op.Ejecutar(cadena);
            cadena = @"INSERT INTO fabricantes(nombre) VALUES ('fabricante5')";
            op.Ejecutar(cadena);

            cadena = @"INSERT INTO articulos(nombre, precio, fabricante) VALUES ('articulo1', 10, 1)";
            op.Ejecutar(cadena);
            cadena = @"INSERT INTO articulos(nombre, precio, fabricante) VALUES ('articulo2', 20, 2)";
            op.Ejecutar(cadena);
            cadena = @"INSERT INTO articulos(nombre, precio, fabricante) VALUES ('articulo3', 30, 3)";
            op.Ejecutar(cadena);
            cadena = @"INSERT INTO articulos(nombre, precio, fabricante) VALUES ('articulo4', 40, 4)";
            op.Ejecutar(cadena);
            cadena = @"INSERT INTO articulos(nombre, precio, fabricante) VALUES ('articulo5', 50, 5)";
            op.Ejecutar(cadena);

            cadena = "SELECT * FROM fabricantes";
            op.Leer(cadena);

            cadena = "SELECT * FROM articulos";
            op.Leer(cadena);

            op.DesconectarBD();
        }

        public static void GenerarEjercicio2()
        {
            Operacion op = new Operacion();

            string cadena = "";
            string nombreBD = "UD18_EJ2";

            op.CrearBD(nombreBD);
            op.ConectarBD(nombreBD);

            cadena = "USE UD18_EJ2;";
            op.Ejecutar(cadena);

            cadena = @"CREATE TABLE departamentos (
                codigo int not null PRIMARY KEY,
	            nombre nvarchar(100),
	            presupuesto int
            )";
            op.Ejecutar(cadena);

            cadena = @"CREATE TABLE empleados(
                	dni varchar(8) not null PRIMARY KEY,
	                nombre nvarchar(100),
	                apellidos nvarchar(255),
	                departamento int FOREIGN KEY REFERENCES departamentos(codigo)
	                ON UPDATE CASCADE
            )";
            op.Ejecutar(cadena);

            cadena = @"INSERT INTO departamentos VALUES (1,'departamentos1',10000)";
            op.Ejecutar(cadena);
            cadena = @"INSERT INTO departamentos VALUES (2,'departamentos2',20000)";
            op.Ejecutar(cadena);
            cadena = @"INSERT INTO departamentos VALUES (3,'departamentos3',30000)";
            op.Ejecutar(cadena);
            cadena = @"INSERT INTO departamentos VALUES (4,'departamentos4',40000)";
            op.Ejecutar(cadena);
            cadena = @"INSERT INTO departamentos VALUES (5,'departamentos5',50000)";
            op.Ejecutar(cadena);

            cadena = @"INSERT INTO empleados VALUES ('11111111', 'nombre', 'apellido', 1)";
            op.Ejecutar(cadena);
            cadena = @"INSERT INTO empleados VALUES ('22222222', 'nombre', 'apellido', 2)";
            op.Ejecutar(cadena);
            cadena = @"INSERT INTO empleados VALUES ('33333333', 'nombre', 'apellido', 3)";
            op.Ejecutar(cadena);
            cadena = @"INSERT INTO empleados VALUES ('44444444', 'nombre', 'apellido', 4)";
            op.Ejecutar(cadena);
            cadena = @"INSERT INTO empleados VALUES ('55555555', 'nombre', 'apellido', 5)";
            op.Ejecutar(cadena);


            cadena = "SELECT * FROM departamentos";
            op.Leer(cadena);

            cadena = "SELECT * FROM empleados";
            op.Leer(cadena);

            op.DesconectarBD();
        }

        public static void GenerarEjercicio3()
        {
            Operacion op = new Operacion();

            string cadena = "";
            string nombreBD = "UD18_EJ3";

            op.CrearBD(nombreBD);
            op.ConectarBD(nombreBD);

            cadena = "USE UD18_EJ3;";
            op.Ejecutar(cadena);

            cadena = @"CREATE TABLE almacenes (
                codigo int identity(1,1) NOT NULL PRIMARY KEY,
             lugar nvarchar(100),
             capacidad int
            )";
            op.Ejecutar(cadena);

            cadena = @"CREATE TABLE cajas(
                	numReferencia char(5) NOT NULL PRIMARY KEY,
                 contenido nvarchar(100),
                 valor int,
                 almacen int FOREIGN KEY REFERENCES almacenes(codigo)
                 ON UPDATE CASCADE
            )";
            op.Ejecutar(cadena);

            cadena = @"INSERT INTO almacenes VALUES
                        ('Tarragona', 3),
                        ('Barcelona', 5),
                        ('Cambrils', 8),
                        ('Salou', 9),
                        ('Reus', 4)
            ";
            op.Ejecutar(cadena);

            cadena = @"INSERT INTO cajas VALUES
                        ('AAAAA', 'Papel', 10, 1),
                        ('BBBBB', 'Papel', 20, 5),
                        ('CCCCC', 'Papel', 40, 4),
                        ('DDDDD', 'Papel', 50, 3),
                        ('EEEEE', 'Papel', 90, 1)
            ";
            op.Ejecutar(cadena);

            cadena = "SELECT * FROM almacenes";
            op.Leer(cadena);

            cadena = "SELECT * FROM cajas";
            op.Leer(cadena);

            op.DesconectarBD();
        }

        public static void GenerarEjercicio4()
        {
            Operacion op = new Operacion();

            string cadena = "";
            string nombreBD = "UD18_EJ4";

            op.CrearBD(nombreBD);
            op.ConectarBD(nombreBD);

            cadena = "USE UD18_EJ4;";
            op.Ejecutar(cadena);

            cadena = @"CREATE TABLE peliculas (
                        codigo int identity(1,1) NOT NULL PRIMARY KEY,
	                    nombre nvarchar(100),
	                    calificacionEdad int
            )";
            op.Ejecutar(cadena);

            cadena = @"CREATE TABLE salas(
                	    codigo int identity(1,1) NOT NULL PRIMARY KEY,
	                    nombre nvarchar(100),
	                    pelicula int FOREIGN KEY REFERENCES peliculas(codigo)
	                    ON UPDATE CASCADE
            )";
            op.Ejecutar(cadena);

            cadena = @"INSERT INTO peliculas VALUES
                        ('Pelicula1', 0),
                        ('Pelicula2', 7),
                        ('Pelicula3', 0),
                        ('Pelicula4', 0),
                        ('Pelicula5', 18)
            ";
            op.Ejecutar(cadena);

            cadena = @"INSERT INTO salas VALUES
                        ('sala1', 1),
                        ('sala2', 2),
                        ('sala3', 5),
                        ('sala4', 4),
                        ('sala5', 3)
            ";
            op.Ejecutar(cadena);

            cadena = "SELECT * FROM peliculas";
            op.Leer(cadena);

            cadena = "SELECT * FROM salas";
            op.Leer(cadena);

            op.DesconectarBD();
        }

        public static void GenerarEjercicio5()
        {
            Operacion op = new Operacion();

            string cadena = "";
            string nombreBD = "UD18_EJ5";

            op.CrearBD(nombreBD);
            op.ConectarBD(nombreBD);

            cadena = "USE UD18_EJ5;";
            op.Ejecutar(cadena);

            cadena = @"CREATE TABLE despachos(
                         numero int identity(1,1) NOT NULL PRIMARY KEY,
                         capacidad int
            )";
            op.Ejecutar(cadena);

            cadena = @"CREATE TABLE directores (
                         dni varchar(8) NOT NULL PRIMARY KEY,
                         nomApels nvarchar(255),
                         DNIJefe varchar(8) FOREIGN KEY REFERENCES directores(dni),
                         despacho int FOREIGN KEY REFERENCES despachos(numero)
                         ON UPDATE CASCADE
            )";
            op.Ejecutar(cadena);

            cadena = @"INSERT INTO despachos VALUES
                        (1),
                        (2),
                        (3),
                        (4),
                        (5)
            ";
            op.Ejecutar(cadena);

            cadena = @"INSERT INTO directores VALUES
                        ('11111111', 'nombre', '55555555', 1),
                        ('22222222', 'nombre', '11111111', 2),
                        ('33333333', 'nombre', '55555555', 3),
                        ('44444444', 'nombre', '11111111', 4),
                        ('55555555', 'nombre', '55555555', 5)
                        ";
            op.Ejecutar(cadena);

            cadena = "SELECT * FROM despachos";
            op.Leer(cadena);

            cadena = "SELECT * FROM directores";
            op.Leer(cadena);

            op.DesconectarBD();
        }

        public static void GenerarEjercicio6()
        {
            Operacion op = new Operacion();

            string cadena = "";
            string nombreBD = "UD18_EJ6";

            op.CrearBD(nombreBD);
            op.ConectarBD(nombreBD);

            cadena = "USE UD18_EJ6;";
            op.Ejecutar(cadena);

            cadena = @"CREATE TABLE piezas(
	                    codigo int identity(1,1) NOT NULL PRIMARY KEY,
	                    nombre nvarchar(100)
            )";
            op.Ejecutar(cadena);

            cadena = @"CREATE TABLE proveedores(
	                    id char(4) NOT NULL PRIMARY KEY,
	                    nombre nvarchar(100)
            )";
            op.Ejecutar(cadena);

            cadena = @"CREATE TABLE suministra (
	                    codigoPieza int NOT NULL FOREIGN KEY REFERENCES piezas(codigo),
	                    idProveedor char(4) NOT NULL FOREIGN KEY REFERENCES proveedores (id),
	                    precio int,
	                    CONSTRAINT PK PRIMARY KEY (codigoPieza, idProveedor)
            )";
            op.Ejecutar(cadena);

            cadena = @"INSERT INTO piezas VALUES
                        ('pieza1'),
                        ('pieza2'),
                        ('pieza3'),
                        ('pieza4'),
                        ('pieza5')
            ";
            op.Ejecutar(cadena);

            cadena = @"INSERT INTO proveedores VALUES
                        ('AAAA', 'prov1'),
                        ('BBBB', 'prov2'),
                        ('CCCC', 'prov3'),
                        ('DDDD', 'prov4'),
                        ('EEEE', 'prov5')
            ";
            op.Ejecutar(cadena);

            cadena = @"INSERT INTO suministra VALUES
                        (1, 'AAAA', 100),
                        (2, 'BBBB', 200),
                        (3, 'CCCC', 300),
                        (4, 'DDDD', 400),
                        (5, 'EEEE', 500)
            ";
            op.Ejecutar(cadena);

            cadena = "SELECT * FROM piezas";
            op.Leer(cadena);

            cadena = "SELECT * FROM proveedores";
            op.Leer(cadena);

            cadena = "SELECT * FROM suministra";
            op.Leer(cadena);

            op.DesconectarBD();
        }

        public static void GenerarEjercicio7()
        {
            Operacion op = new Operacion();

            string cadena = "";
            string nombreBD = "UD18_EJ7";

            op.CrearBD(nombreBD);
            op.ConectarBD(nombreBD);

            cadena = "USE UD18_EJ7;";
            op.Ejecutar(cadena);

            cadena = @"CREATE TABLE cientificos(
	                    dni varchar(8) NOT NULL PRIMARY KEY,
	                    NomApels nvarchar(100)
            )";
            op.Ejecutar(cadena);

            cadena = @"CREATE TABLE proyecto(
	                    id char(4) NOT NULL PRIMARY KEY,
	                    nombre nvarchar(255),
	                    horas int
            )";
            op.Ejecutar(cadena);

            cadena = @"CREATE TABLE asignado_a (
	                    cientifico varchar(8) NOT NULL FOREIGN KEY REFERENCES cientificos(dni),
	                    proyecto char(4) NOT NULL FOREIGN KEY REFERENCES proyecto (id),
	                    CONSTRAINT PK PRIMARY KEY (cientifico, proyecto)
            )";
            op.Ejecutar(cadena);

            cadena = @"INSERT INTO cientificos VALUES
                        ('11111111', 'nombre1'),
                        ('22222222', 'nombre2'),
                        ('33333333', 'nombre3'),
                        ('44444444', 'nombre4'),
                        ('55555555', 'nombre5')
            ";
            op.Ejecutar(cadena);

            cadena = @"INSERT INTO proyecto VALUES
                        ('AAAA', 'pro1', 10),
                        ('BBBB', 'pro2', 5),
                        ('CCCC', 'pro3', 20),
                        ('DDDD', 'pro4', 30),
                        ('EEEE', 'pro5', 7)
            ";
            op.Ejecutar(cadena);

            cadena = @"INSERT INTO asignado_a VALUES
                        ('11111111', 'AAAA'),
                        ('22222222', 'BBBB'),
                        ('33333333', 'CCCC'),
                        ('44444444', 'DDDD'),
                        ('55555555', 'EEEE')
            ";
            op.Ejecutar(cadena);

            cadena = "SELECT * FROM cientificos";
            op.Leer(cadena);

            cadena = "SELECT * FROM proyecto";
            op.Leer(cadena);

            cadena = "SELECT * FROM asignado_a";
            op.Leer(cadena);

            op.DesconectarBD();
        }

        public static void GenerarEjercicio8()
        {
            Operacion op = new Operacion();

            string cadena = "";
            string nombreBD = "UD18_EJ8";

            op.CrearBD(nombreBD);
            op.ConectarBD(nombreBD);

            cadena = "USE UD18_EJ8;";
            op.Ejecutar(cadena);

            cadena = @"CREATE TABLE cajeros(
	                    codigo int identity(1,1) NOT NULL PRIMARY KEY,
	                    NomApels nvarchar(255)
            )";
            op.Ejecutar(cadena);

            cadena = @"CREATE TABLE productos(
	                    codigo int identity(1,1) NOT NULL PRIMARY KEY,
	                    nombre nvarchar(100),
	                    precio int
            )";
            op.Ejecutar(cadena);

            cadena = @"CREATE TABLE maquinas_registradoras (
	                    codigo int identity(1,1) NOT NULL PRIMARY KEY,
	                    piso int
            )";
            op.Ejecutar(cadena);

            cadena = @"CREATE TABLE venta (
	                    cajero int NOT NULL FOREIGN KEY REFERENCES cajeros(codigo),
	                    maquina int NOT NULL FOREIGN KEY REFERENCES maquinas_registradoras(codigo),
	                    producto int NOT NULL FOREIGN KEY REFERENCES productos(codigo)
	                    CONSTRAINT PK PRIMARY KEY (cajero, maquina, producto)
            )";
            op.Ejecutar(cadena);

            cadena = @"INSERT INTO cajeros VALUES
                        ('nombre1'),
                        ('nombre2'),
                        ('nombre3'),
                        ('nombre4'),
                        ('nombre5')
            ";
            op.Ejecutar(cadena);

            cadena = @"INSERT INTO productos VALUES
                        ('pro1', 10),
                        ('pro2', 5),
                        ('pro3', 20),
                        ('pro4', 30),
                        ('pro5', 7)
            ";
            op.Ejecutar(cadena);

            cadena = @"INSERT INTO maquinas_registradoras VALUES
                        (1),
                        (5),
                        (9),
                        (10),
                        (12)
            ";
            op.Ejecutar(cadena);

            cadena = @"INSERT INTO venta VALUES
                        (1,1,1),
                        (2,2,2),
                        (3,3,3),
                        (4,4,4),
                        (5,5,5)
            ";
            op.Ejecutar(cadena);

            cadena = "SELECT * FROM cajeros";
            op.Leer(cadena);

            cadena = "SELECT * FROM productos";
            op.Leer(cadena);

            cadena = "SELECT * FROM maquinas_registradoras";
            op.Leer(cadena);

            cadena = "SELECT * FROM venta";
            op.Leer(cadena);

            op.DesconectarBD();
        }

        public static void GenerarEjercicio9()
        {
            Operacion op = new Operacion();

            string cadena = "";
            string nombreBD = "UD18_EJ9";

            op.CrearBD(nombreBD);
            op.ConectarBD(nombreBD);

            cadena = "USE UD18_EJ9;";
            op.Ejecutar(cadena);

            cadena = @"CREATE TABLE facultad(
	                    codigo int NOT NULL PRIMARY KEY,
	                    Nombre nvarchar(100)
            )";
            op.Ejecutar(cadena);

            cadena = @"CREATE TABLE investigadores(
	                    dni varchar(8) NOT NULL PRIMARY KEY,
	                    nom_pels nvarchar(255),
	                    facultad int FOREIGN KEY REFERENCES facultad(codigo)
            )";
            op.Ejecutar(cadena);

            cadena = @"CREATE TABLE equipos(
	                    numSerie char(4) NOT NULL PRIMARY KEY,
	                    nombre nvarchar(100),
	                    facultad int FOREIGN KEY REFERENCES facultad(codigo)
            )";
            op.Ejecutar(cadena);

            cadena = @"CREATE TABLE reserva (
	                    dni varchar(8) NOT NULL FOREIGN KEY REFERENCES investigadores(dni),
	                    numSerie char(4) NOT NULL FOREIGN KEY REFERENCES equipos(numSerie),
	                    comienzo datetime,
	                    fin datetime
            )";
            op.Ejecutar(cadena);

            cadena = @"INSERT INTO facultad VALUES
                        (1,'nombre1'),
                        (2,'nombre2'),
                        (3,'nombre3'),
                        (4,'nombre4'),
                        (5,'nombre5')
            ";
            op.Ejecutar(cadena);

            cadena = @"INSERT INTO investigadores VALUES
                        ('11111111', 'nombre1',1),
                        ('22222222', 'nombre2',2),
                        ('33333333', 'nombre3',3),
                        ('44444444', 'nombre4',4),
                        ('55555555', 'nombre5',5)
            ";
            op.Ejecutar(cadena);

            cadena = @"INSERT INTO equipos VALUES
                        ('AAAA', 'nombre1',1),
                        ('BBBB', 'nombre2',2),
                        ('CCCC', 'nombre3',3),
                        ('DDDD', 'nombre4',4),
                        ('EEEE', 'nombre5',5)
            ";
            op.Ejecutar(cadena);

            cadena = @"INSERT INTO reserva VALUES
                        ('11111111', 'AAAA', '20210120', '20210125'),
                        ('22222222', 'BBBB', '20210110', '20210115'),
                        ('33333333', 'CCCC', '20210111', '20210121'),
                        ('44444444', 'DDDD', '20210110', '20210121'),
                        ('55555555', 'EEEE', '20210105', '20210122')
            ";
            op.Ejecutar(cadena);

            cadena = "SELECT * FROM facultad";
            op.Leer(cadena);

            cadena = "SELECT * FROM investigadores";
            op.Leer(cadena);

            cadena = "SELECT * FROM equipos";
            op.Leer(cadena);

            cadena = "SELECT * FROM reserva";
            op.Leer(cadena);

            op.DesconectarBD();
        }
    }
}
