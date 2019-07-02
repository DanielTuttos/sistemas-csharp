Use master
go

If(DB_ID('DemoNCapas')is not null)
Drop Database DemoNCapas
Create Database DemoNCapas
go

Use DemoNCapas
go

Create Table Alumnos(
IdAlumno int identity(1,1) primary key,
Dni char(8) not null,
Apellidos varchar(100) not null,
Nombres varchar(100) not null,
Sexo char(1) not null,
FechaNac date not null,
Direccion varchar(100) not null
)
go

Insert Alumnos values ('45667788','Campos Amador','Marcos','M','20/05/1994','Sáenz Peña 198 - Chiclayo Perú')
go

--Procedimientos Almacenados
Create Proc Registrar_Alumnos(
@Dni char(8),
@Apellidos varchar(100),
@Nombres varchar(100),
@Sexo char(1),
@FechaNac date,
@Direccion varchar(100),
@Mensaje varchar(100) out
)
as 
	begin
		if(exists(Select * from Alumnos where Dni=@Dni))
		set @Mensaje='Este DNI ya Existe'
		else
			begin
			Insert Alumnos values (@Dni,@Apellidos,@Nombres,@Sexo,@FechaNac,@Direccion)
			set @Mensaje='Se registró el Alumno Correctamente'
			end
	end
go

Create Proc Listado_Alumno
as
	Select * from Alumnos
go


	

















