USE MASTER
GO
IF(DB_ID('COLEGIO') IS NOT NULL)
DROP DATABASE COLEGIO
CREATE DATABASE COLEGIO
GO

USE COLEGIO
GO

CREATE TABLE APODERADO
(Dni CHAR(8) PRIMARY KEY,
Nombres VARCHAR(30) NOT NULL,
Apellidos VARCHAR(30) NOT NULL,
Edad INT NOT NULL,
Sexo CHAR(1) NOT NULL CHECK(Sexo IN('M','F')),
Ocupaci�n VARCHAR(50) NOT NULL,
Estado_Civil CHAR(30),
Grado_Instrucci�n VARCHAR(20) NOT NULL,
Tel�fono VARCHAR(12) NOT NULL,
Direcci�n VARCHAR(50) NOT NULL,
Fecha_Nacimiento DATE NOT NULL
)
GO

CREATE TABLE ALUMNO
(Dni CHAR(8)PRIMARY KEY,
Nombres VARCHAR(30) NOT NULL,
Ap_Paterno VARCHAR(12) NOT NULL,
Ap_Materno VARCHAR(12) NOT NULL,
Edad TINYINT NOT NULL,
Sexo CHAR(1) NOT NULL CHECK(Sexo IN('M','F')),
Direcci�n VARCHAR(50) NOT NULL,
Fecha_Nacimiento DATE NOT NULL
)
GO

CREATE TABLE PARENTESCO
(Cod_Parentesco  INT IDENTITY(1,1) PRIMARY KEY,
Parentesco VARCHAR(30) NOT NULL,
Dni_Alumno CHAR(8) FOREIGN KEY REFERENCES ALUMNO,
Dni_Apoderado CHAR(8) FOREIGN KEY REFERENCES APODERADO
)
GO

CREATE TABLE AULAS
(Cod_Aula Int Identity(1,1) PRIMARY KEY,
Capacidad TINYINT NOT NULL,
VacantesLib int
)
GO


CREATE TABLE A�O_ESCOLAR
(Num_A�o CHAR(4) PRIMARY KEY,
Fecha_Inicio DATE NOT NULL,
Fecha_T�rmino DATE NOT NULL
)
GO

CREATE TABLE MATRICULA
(N�_Matr�cula INT IDENTITY(1,1) PRIMARY KEY,
Fecha DATE NOT NULL,
Monto SMALLMONEY CHECK(Monto>0.00)NOT NULL,
Grado TINYINT CHECK(Grado between 1 AND 5) NOT NULL,
Secci�n CHAR(1)NOT NULL CHECK(Secci�n IN('A','B')),
Id_Aula Int FOREIGN KEY REFERENCES AULAS,
Dni_Alumno CHAR(8) FOREIGN KEY REFERENCES ALUMNO,
Num_A�o CHAR(4)  FOREIGN KEY REFERENCES A�O_ESCOLAR,
)
GO
Select * from MATRICULA

CREATE TABLE CURSO 
(Cod_Curso CHAR(5) PRIMARY KEY,
Nombres VARCHAR(45) NOT NULL,
)
GO

CREATE TABLE TRIMESTRES
(Cod_Trimestre INT IDENTITY(1,1) PRIMARY KEY,
Descripci�n VARCHAR (30) NOT NULL
)
GO

CREATE TABLE NOTAS
(Cod_Notas INT IDENTITY(1,1) PRIMARY KEY,
Nota DECIMAL CHECK(NOTA>=0 AND NOTA<=20 ),
Descripci�n VARCHAR (30) NOT NULL,
Id_Curso CHAR(5) FOREIGN KEY REFERENCES CURSO,
Dni_Alumno CHAR(8) FOREIGN KEY REFERENCES ALUMNO,
Id_Trimestre INT FOREIGN KEY REFERENCES TRIMESTRES
)
GO

CREATE TABLE ESPECIALIDAD
(Cod_Especialidad INT IDENTITY(1,1)PRIMARY KEY,
Especialidad VARCHAR (30) NOT NULL,
)
GO

CREATE TABLE DOCENTE
(Dni CHAR(8)PRIMARY KEY,
Nombres VARCHAR(30) NOT NULL,
Apellidos VARCHAR (30) NOT NULL,
Edad TINYINT NOT NULL,
Sexo CHAR(1) NOT NULL CHECK(Sexo IN('M','F')),
Direcci�n VARCHAR(50) NOT NULL,
Email VARCHAR (30) NOT NULL,
Tel�fono VARCHAR (12) NOT NULL,
Fecha_Nacimiento DATE NOT NULL,
Id_Especialidad INT FOREIGN KEY REFERENCES ESPECIALIDAD
)
GO

CREATE TABLE HORARIO
(D�a VARCHAR(12) NOT NULL,
Hora_Inicio TIME NOT NULL,
Hora_Fin TIME NOT NULL,
Secci�n CHAR(1)NOT NULL,
Id_Aula Int,
Dni_Docente CHAR(8)FOREIGN KEY REFERENCES DOCENTE,
ID_Curso CHAR(5) FOREIGN KEY REFERENCES CURSO
)
GO

--Nueva tabla para inicio de Sesion
Create Table Usuario(
Nombre varchar(20),
Contrase�a varchar(20)
)
go

--Insertamos Usuarios
Insert Into Usuario values('Admin','123456')
Insert Into Usuario values('UsuarioA','987654')
Insert Into Usuario values('UsuarioB','098765')
Insert Into Usuario values('UsuarioC','012345')
Insert Into Usuario values('Secretaria','654321')
Select * from Usuario

go

CREATE TABLE DOCUMENTACION
(Partida CHAR(1) CHECK (Partida='S' OR Partida='N' )not null,
Certificado CHAR(1) CHECK (Certificado='S' OR Certificado='N' ) not null,
Dni_Alumno char(8) FOREIGN KEY REFERENCES Alumno,
)
GO


---=========================================INSERCION DE DATOS========================================================
---=========================================INSERCION DE DATOS========================================================


--INSERT INTO APODERADO VALUES('12345678','Pedro','Castillo',52,'M','Pescador','S','Superior','452','Av. Balta','28/05/1990')
--INSERT INTO APODERADO VALUES('12345679','Tavara','Carvalo',52,'M','Alba�il','S','Primaria','452','Av. Angamos','28/05/1980')
--SELECT * FROM APODERADO
--GO

--INSERT INTO ALUMNO VALUES('47660746','Juan','Vasquez','Ventura',15,'M','LOS Sauces','28/05/1994')
--INSERT INTO ALUMNO VALUES('45815240','Luis','Seclen','Sampen',15,'M','Los Angeles','06/06/1994')
--SELECT* FROM ALUMNO
--GO

--INSERT INTO PARENTESCO VALUES('Primo','47660746','12345678')
--INSERT INTO PARENTESCO VALUES('T�o','45815240','12345679')
--SELECT * FROM PARENTESCO 
--GO

INSERT INTO AULAS VALUES(35,35)
INSERT INTO AULAS VALUES(35,35)
INSERT INTO AULAS VALUES(35,35)
INSERT INTO AULAS VALUES(35,35)
INSERT INTO AULAS VALUES(35,35)
SELECT * FROM AULAS
GO

--INSERT INTO A�O_ESCOLAR VALUES('2012','01/02/2012','21/12/2012')
--SELECT * FROM A�O_ESCOLAR 
--GO

--INSERT INTO MATRICULA VALUES('20/05/2012',25,'1','A','1','47660746','2012')
--Update Aulas set VacantesLib=VacantesLib-1 where Cod_Aula=1
--INSERT INTO MATRICULA VALUES('20/05/2012',25,'1','A','1','45815240','2012')
--Update Aulas set VacantesLib=VacantesLib-1 where Cod_Aula=1
--select * from AULAS where Cod_Aula='1'
--go
/*
INSERT INTO MATRICULA VALUES('21/05/2012',25,'1','A','2','45815240','2012')
Update Aula set VacantesLib=VacantesLib-1 where Cod_Aula=2
SELECT * FROM MATRICULA
GO*/
INSERT INTO CURSO VALUES('MAT01','Matem�tica')
INSERT INTO CURSO VALUES('CTA01','Ciencia Tecnolog�a Y Ambiente')
INSERT INTO CURSO VALUES('CS001','Ciencia Sociales')
INSERT INTO CURSO VALUES('COM01','Comunicaci�n')
INSERT INTO CURSO VALUES('PFR01','Persona Familia y Relaciones Humanas')
INSERT INTO CURSO VALUES('EF001','Educaci�n Fis�ca')
INSERT INTO CURSO VALUES('EA001','Educaci�n por Arte')
INSERT INTO CURSO VALUES('ET001','Educaci�n por Trabajo')
INSERT INTO CURSO VALUES('R0001','Religi�n')
INSERT INTO CURSO VALUES('I0001','Ingles')
SELECT * FROM CURSO
GO

--INSERT INTO TRIMESTRES VALUES(15,'PRIMER TRIMESTRE')
--INSERT INTO TRIMESTRES VALUES(14,'PRIMER TRIMESTRE')
--INSERT INTO TRIMESTRES VALUES(12,'PRIMER TRIMESTRE')
--SELECT*FROM TRIMESTRES
--GO
INSERT INTO TRIMESTRES VALUES('Primer Trimestre')
INSERT INTO TRIMESTRES VALUES('Segundo Trimestre')
INSERT INTO TRIMESTRES VALUES('Tercer Trimestre')
SELECT*FROM TRIMESTRES
GO

--INSERT INTO NOTAS VALUES (15,'Trabajos','MAT01','47660746','1')
--INSERT INTO NOTAS VALUES (15,'Exposiciones','MAT01','47660746','1')
--INSERT INTO NOTAS VALUES (15,'Pr�cticas','MAT01','47660746','1')
--INSERT INTO NOTAS VALUES (15,'Examen Final','MAT01','47660746','1')

--INSERT INTO NOTAS VALUES (14,'Trabajos','CTA01','47660746','1')
--INSERT INTO NOTAS VALUES (14,'Exposiciones','CTA01','47660746','1')
--INSERT INTO NOTAS VALUES (14,'Pr�cticas','CTA01','47660746','1')
--INSERT INTO NOTAS VALUES (14,'Examen Final','CTA01','47660746','1')

--INSERT INTO NOTAS VALUES (12,'Trabajos','CS001','47660746','1')
--INSERT INTO NOTAS VALUES (12,'Exposiciones','CS001','47660746','1')
--INSERT INTO NOTAS VALUES (12,'Pr�cticas','CS001','47660746','1')
--INSERT INTO NOTAS VALUES (12,'Examen Final','CS001','47660746','1')

--INSERT INTO NOTAS VALUES (16,'Trabajos','MAT01','47660746','2')
--INSERT INTO NOTAS VALUES (15,'Exposiciones','MAT01','47660746','2')
--INSERT INTO NOTAS VALUES (10,'Pr�cticas','MAT01','47660746','2')
--INSERT INTO NOTAS VALUES (20,'Examen Final','MAT01','47660746','2')

--INSERT INTO NOTAS VALUES (11,'Trabajos','CTA01','47660746','2')
--INSERT INTO NOTAS VALUES (13,'Exposiciones','CTA01','47660746','2')
--INSERT INTO NOTAS VALUES (19,'Pr�cticas','CTA01','47660746','2')
--INSERT INTO NOTAS VALUES (08,'Examen Final','CTA01','47660746','2')

--INSERT INTO NOTAS VALUES (05,'Trabajos','CS001','47660746','2')
--INSERT INTO NOTAS VALUES (12,'Exposiciones','CS001','47660746','2')
--INSERT INTO NOTAS VALUES (17,'Pr�cticas','CS001','47660746','2')
--INSERT INTO NOTAS VALUES (20,'Examen Final','CS001','47660746','2')

--INSERT INTO NOTAS VALUES (16,'Trabajos','MAT01','47660746','3')
--INSERT INTO NOTAS VALUES (11,'Exposiciones','MAT01','47660746','3')
--INSERT INTO NOTAS VALUES (10,'Pr�cticas','MAT01','47660746','3')
--INSERT INTO NOTAS VALUES (09,'Examen Final','MAT01','47660746','3')

--INSERT INTO NOTAS VALUES (10,'Trabajos','CTA01','47660746','2')
--INSERT INTO NOTAS VALUES (12,'Exposiciones','CTA01','47660746','3')
--INSERT INTO NOTAS VALUES (18,'Pr�cticas','CTA01','47660746','3')
--INSERT INTO NOTAS VALUES (14,'Examen Final','CTA01','47660746','3')

--INSERT INTO NOTAS VALUES (10,'Trabajos','CS001','47660746','3')
--INSERT INTO NOTAS VALUES (12,'Exposiciones','CS001','47660746','3')
--INSERT INTO NOTAS VALUES (17,'Pr�cticas','CS001','47660746','3')
--INSERT INTO NOTAS VALUES (15,'Examen Final','CS001','47660746','3')

--INSERT INTO NOTAS VALUES (8,'Trabajos','COM01','47660746','1')
--INSERT INTO NOTAS VALUES (17,'Exposiciones','COM01','47660746','1')
--INSERT INTO NOTAS VALUES (5,'Pr�cticas','COM01','47660746','1')
--INSERT INTO NOTAS VALUES (20,'Examen Final','COM01','47660746','1')

--INSERT INTO NOTAS VALUES (12,'Trabajos','COM01','47660746','2')
--INSERT INTO NOTAS VALUES (20,'Exposiciones','COM01','47660746','2')
--INSERT INTO NOTAS VALUES (15,'Pr�cticas','COM01','47660746','2')
--INSERT INTO NOTAS VALUES (20,'Examen Final','COM01','47660746','2')

--INSERT INTO NOTAS VALUES (18,'Trabajos','COM01','47660746','3')
--INSERT INTO NOTAS VALUES (17,'Exposiciones','COM01','47660746','3')
--INSERT INTO NOTAS VALUES (13,'Pr�cticas','COM01','47660746','3')
--INSERT INTO NOTAS VALUES (11,'Examen Final','COM01','47660746','3')

--Select * from ALUMNO 

-- --Notas Luis
-- INSERT INTO NOTAS VALUES (15,'Trabajos','MAT01','45815240','1')
--INSERT INTO NOTAS VALUES (15,'Exposiciones','MAT01','45815240','1')
--INSERT INTO NOTAS VALUES (15,'Pr�cticas','MAT01','45815240','1')
--INSERT INTO NOTAS VALUES (15,'Examen Final','MAT01','45815240','1')

--INSERT INTO NOTAS VALUES (14,'Trabajos','CTA01','45815240','1')
--INSERT INTO NOTAS VALUES (14,'Exposiciones','CTA01','45815240','1')
--INSERT INTO NOTAS VALUES (14,'Pr�cticas','CTA01','45815240','1')
--INSERT INTO NOTAS VALUES (14,'Examen Final','CTA01','45815240','1')

--INSERT INTO NOTAS VALUES (12,'Trabajos','CS001','45815240','1')
--INSERT INTO NOTAS VALUES (12,'Exposiciones','CS001','45815240','1')
--INSERT INTO NOTAS VALUES (12,'Pr�cticas','CS001','45815240','1')
--INSERT INTO NOTAS VALUES (12,'Examen Final','CS001','45815240','1')

--INSERT INTO NOTAS VALUES (16,'Trabajos','MAT01','45815240','2')
--INSERT INTO NOTAS VALUES (15,'Exposiciones','MAT01','45815240','2')
--INSERT INTO NOTAS VALUES (10,'Pr�cticas','MAT01','45815240','2')
--INSERT INTO NOTAS VALUES (20,'Examen Final','MAT01','45815240','2')

--INSERT INTO NOTAS VALUES (11,'Trabajos','CTA01','45815240','2')
--INSERT INTO NOTAS VALUES (13,'Exposiciones','CTA01','45815240','2')
--INSERT INTO NOTAS VALUES (19,'Pr�cticas','CTA01','45815240','2')
--INSERT INTO NOTAS VALUES (08,'Examen Final','CTA01','45815240','2')

--INSERT INTO NOTAS VALUES (05,'Trabajos','CS001','45815240','2')
--INSERT INTO NOTAS VALUES (12,'Exposiciones','CS001','45815240','2')
--INSERT INTO NOTAS VALUES (17,'Pr�cticas','CS001','45815240','2')
--INSERT INTO NOTAS VALUES (20,'Examen Final','CS001','45815240','2')

--SELECT * FROM NOTAS
--select*from MATRICULA
--GO


INSERT INTO ESPECIALIDAD VALUES ('Matem�tica')
INSERT INTO ESPECIALIDAD VALUES ('Ciencias de la Comunicaci�n')
INSERT INTO ESPECIALIDAD VALUES ('Idiomas')
INSERT INTO ESPECIALIDAD VALUES ('Geografia y Biologia')
INSERT INTO ESPECIALIDAD VALUES ('Educacion Fisica')
INSERT INTO ESPECIALIDAD VALUES ('Fisica y Quimica')
INSERT INTO ESPECIALIDAD VALUES ('Administracion de Empresas')
SELECT * FROM ESPECIALIDAD
GO


INSERT INTO DOCENTE VALUES('45896237','Francico','Perez Perez',32,'M','Urb. Los Arboles','francis@hotmail.com','978475821','15/08/1980',1)
INSERT INTO DOCENTE VALUES('55896238','Maria','ANGELES Perales',24,'F','Av. Los Parques','maria@hotmail.com','988473320','05/04/1988',2)
INSERT INTO DOCENTE VALUES('25896007','Pedro','Ramirez Ramos',27,'M','Av. La Marina','pedro_rr@hotmail.com','948475777','15/08/1985',3)
INSERT INTO DOCENTE VALUES('55897238','Mariela','Lopez Juarez',24,'F','Av. Lambayeque','lopezmariela@hotmail.com','989473300','05/04/1988',7)
INSERT INTO DOCENTE VALUES('43896236','Alex','Gonzales Torres',32,'M','La Victoria N 876','torresalex@hotmail.com','958400821','15/08/1980',6)
INSERT INTO DOCENTE VALUES('39896238','Doris','Castro Olivera',24,'F','Av. Los Laureles','olivera_c@hotmail.com','979470327','05/04/1988',4)
INSERT INTO DOCENTE VALUES('41893237','Walter','Monja Suarez',32,'M','Av. Chiclayo','walter_monja@hotmail.com','978055881','15/08/1980',5)
SELECT * FROM DOCENTE
GO

--INSERT INTO HORARIO VALUES('Lunes','8:00 AM','8:45 AM','A','1','45896237','MAT01')
--INSERT INTO HORARIO VALUES('Lunes','8:45 AM','9:30 AM','A','3','45896237','MAT01')
--SELECT * FROM HORARIO
--GO

--insert into DOCUMENTACION values('N','N','47660746')
--insert into DOCUMENTACION values('N','N','45815240')
--go


---=========================================PROCEDIMIENTOS ALMACENADOS==============================================
---=========================================PROCEDIMIENTOS ALMACENADOS==============================================


CREATE PROC REGISTRAR_APODERADO
(@DNI CHAR(8),
@NOMBRES VARCHAR(30),
@APELLIDOS VARCHAR(30),
@EDAD INT,
@SEXO CHAR(1),
@OCUPACION VARCHAR(50),
@ESTADO_CIVIL CHAR(1),
@GRADO_INSTRUCCION VARCHAR(20),
@TELEFONO VARCHAR(12),
@DIRECCION VARCHAR(50),
@FECHA_NACIMIENTO DATE,
@MENSAJE VARCHAR(100) OUTPUT)
AS 
BEGIN
IF(EXISTS(SELECT*FROM APODERADO WHERE Dni=@DNI))
SET @MENSAJE='N�mero de Dni: '+ @DNI +' Ya Se Encuentra Registrado'
ELSE
BEGIN
INSERT INTO APODERADO VALUES(@DNI,@NOMBRES,@APELLIDOS,@EDAD,@SEXO,@OCUPACION,@ESTADO_CIVIL,@GRADO_INSTRUCCION,
							@TELEFONO,@DIRECCION,@FECHA_NACIMIENTO)
SET @MENSAJE='Registrado Ok'
END
END
GO

--declare @MENSAJE VARCHAR(100)
--exec REGISTRAR_APODERADO '25369851','Salomon','Garcia Marquez',25,'M','Abogado','S','Superior Universitario','124563','Miraflores','13/05/1988',@MENSAJE OUTPUT
--SELECT @MENSAJE
--GO

CREATE PROC BUSCAR_NOMBRECOMPLETO_APODERADO
(@NOMBRES VARCHAR(30))
AS BEGIN
SELECT * FROM APODERADO WHERE NOMBRES LIKE @NOMBRES+'%'
END
GO

CREATE PROC BUSCAR_DNI_APODERADO
(@DNI VARCHAR(8))
AS BEGIN
SELECT * FROM APODERADO WHERE Dni LIKE @DNI+'%'
END
GO

CREATE PROC ACTUALIZAR_APODERADO
(@DNI CHAR(8),
@NOMBRES VARCHAR(30),
@APELLIDOS VARCHAR(30),
@EDAD INT,
@SEXO CHAR(1),
@OCUPACION VARCHAR(50),
@ESTADO_CIVIL CHAR(1),
@GRADO_INSTRUCCION VARCHAR(20),
@TELEFONO VARCHAR(12),
@DIRECCION VARCHAR(50),
@FECHA_NACIMIENTO DATE,
@MENSAJE VARCHAR(100) OUTPUT)
AS 
BEGIN
UPDATE APODERADO SET NOMBRES=@NOMBRES,Apellidos=@APELLIDOS,EDAD=@EDAD,SEXO=@SEXO,Ocupaci�n=@OCUPACION,
					ESTADO_CIVIL=@ESTADO_CIVIL,Grado_Instrucci�n=@GRADO_INSTRUCCION,Tel�fono=@TELEFONO,
					Direcci�n=@DIRECCION,FECHA_NACIMIENTO=@FECHA_NACIMIENTO WHERE DNI=@DNI
SET @MENSAJE='Datos Actualizados'
END
GO

CREATE PROC REGISTRAR_ALUMNO
@DNI CHAR(8),
@NOMBRES VARCHAR(30),
@APE_PATERNO VARCHAR(12),
@APE_MATERNO VARCHAR(12),
@EDAD TINYINT,
@SEXO CHAR(1),
@DIRECCION VARCHAR(50),
@FECHA_NACIMIENTO DATE,
@MENSAJE VARCHAR(100) OUTPUT
AS 
BEGIN
IF(EXISTS(SELECT*FROM ALUMNO WHERE Dni=@DNI))
SET @MENSAJE='N�mero de Dni: '+ @DNI +' Ya Se Encuentra Registrado'
ELSE
BEGIN
INSERT INTO ALUMNO VALUES(@DNI,@NOMBRES,@APE_PATERNO,@APE_MATERNO,@EDAD,@SEXO,@DIRECCION,@FECHA_NACIMIENTO)
SET @MENSAJE='Registrado Ok'
END
END
GO

--declare @MENSAJE VARCHAR(100)
--exec REGISTRAR_ALUMNO '25369852','Wilder','Garcia','Perez',12,'M','Miraflores','14/05/2000',@MENSAJE OUTPUT
--SELECT @MENSAJE
--GO

CREATE PROC BUSCAR_DN_ALUMNO
@DNI VARCHAR(8)
AS BEGIN
SELECT * FROM ALUMNO WHERE Dni LIKE @DNI+'%'
END
GO

CREATE PROC BUSCAR_NOMBRES_ALUMNO
@NOMBRES VARCHAR(60)
AS BEGIN 
SELECT * FROM ALUMNO WHERE Nombres+' '+Ap_Paterno+' '+Ap_Materno+'  ' LIKE @NOMBRES+'%'
end
GO


CREATE PROC ACTUALIZAR_ALUMNO
@DNI CHAR(8),
@NOMBRES VARCHAR(30),
@APE_PATERNO VARCHAR(12),
@APE_MATERNO VARCHAR(12),
@EDAD TINYINT,
@SEXO CHAR(1),
@DIRECCION VARCHAR(50),
@FECHA_NACIMIENTO DATE,
@MENSAJE VARCHAR(100) OUTPUT
AS 
BEGIN
UPDATE ALUMNO SET Nombres=@NOMBRES,Ap_Paterno=@APE_PATERNO,Ap_Materno=@APE_MATERNO,Edad=@EDAD,
				Sexo=@SEXO,Direcci�n=@DIRECCION,Fecha_Nacimiento=@FECHA_NACIMIENTO WHERE Dni=@DNI
SET @MENSAJE='Datos Actualizados'
END
GO

Create PROC REGISTRAR_PARENTESCO
@PARENTESCO VARCHAR(30),
@DNI_ALUMNO CHAR(8),
@DNI_APODERADO CHAR(8),
@MENSAJE VARCHAR (100) OUTPUT
AS BEGIN
IF(EXISTS(SELECT*FROM PARENTESCO WHERE Dni_Alumno=@DNI_ALUMNO AND Dni_Apoderado=@DNI_APODERADO))
SET @MENSAJE='Ya Se Encuentran Registrados'
ELSE
BEGIN
if(Not exists(Select * from ALUMNO where Dni=@DNI_ALUMNO))
set @MENSAJE='El Alumno no Est� Registrado'
ELSE
BEGIN
if(Not exists(Select * from APODERADO where Dni=@DNI_APODERADO))
set @MENSAJE='El Apoderado no Est� Registrado'
ELSE
BEGIN
INSERT INTO PARENTESCO VALUES(@PARENTESCO,@DNI_ALUMNO,@DNI_APODERADO)
SET @MENSAJE='Registrado Ok'
END
END
END
END
GO
--declare @MENSAJE VARCHAR(100)
--exec REGISTRAR_PARENTESCO 'Hno','25369852','25369851',@MENSAJE OUTPUT
--SELECT @MENSAJE
--GO


CREATE PROC REGISTRAR_NOTAS
@NOTA DECIMAL,
@DESCRIPCION VARCHAR(30),
@ID_CURSO CHAR(5),
@DNI_ALUMNO CHAR(8),
@ID_TRIMESTRE INT,
@MENSAJE VARCHAR(100) OUTPUT
AS 
DECLARE @CANT_NOTAS INT
BEGIN
SET @CANT_NOTAS=(SELECT COUNT(*) FROM NOTAS WHERE Id_Curso=@ID_CURSO AND Dni_Alumno=@DNI_ALUMNO AND Id_Trimestre=@ID_TRIMESTRE)
IF(@CANT_NOTAS>=4)
SET @MENSAJE='S�lo Puede Registrar 4 Notas Por Curso'
ELSE
BEGIN
INSERT INTO NOTAS VALUES(@NOTA,@DESCRIPCION,@ID_CURSO,@DNI_ALUMNO,@ID_TRIMESTRE)
SET @MENSAJE='Registrado Ok'
END
END
GO
 
CREATE PROC ACTUALIZAR_NOTAS
@COD_NOTAS INT,
@NOTA DECIMAL,
@DESCRIPCION VARCHAR(30),
@ID_CURSO CHAR(5),
@DNI_ALUMNO CHAR(8),
@ID_TRIMESTRE INT,
@MENSAJE VARCHAR(100) OUTPUT
AS BEGIN
UPDATE NOTAS SET Nota=@NOTA,Descripci�n=@DESCRIPCION WHERE Dni_Alumno=@DNI_ALUMNO AND Id_Curso=@ID_CURSO AND Id_Trimestre=@ID_TRIMESTRE and Cod_Notas=@COD_NOTAS
SET @MENSAJE='Notas Actualizadas'
END
GO


CREATE PROC BUSCAR_NOTAS
@DNI_ALUMNO CHAR(8),
@ID_CURSO CHAR(5),
@ID_TRIMESTRE INT
AS BEGIN
SELECT *FROM NOTAS WHERE Dni_Alumno=@DNI_ALUMNO AND Id_Curso=@ID_CURSO AND Id_Trimestre=@ID_TRIMESTRE
END
GO

CREATE PROC GENERAR_CODIGO_NOTAS
@ID_NTA INT OUTPUT
AS BEGIN
SET @ID_NTA=(SELECT COUNT(Cod_Notas)+1 FROM NOTAS)
END
GO


CREATE PROC REGISTRAR_HORARIO
@DIA VARCHAR(12),
@HORA_INICIO TIME ,
@HORA_FIN TIME ,
@SECCION CHAR(1),
@ID_AULA Int,
@DNI_DOCENTE CHAR(8),
@ID_CURSO CHAR(5),
@MENSAJE VARCHAR(100) OUTPUT
AS BEGIN
INSERT INTO HORARIO VALUES(@DIA,@HORA_INICIO,@HORA_FIN,@SECCION,@ID_AULA,@DNI_DOCENTE,@ID_CURSO)
SET @MENSAJE='Horario Registrado'
END
GO

select * from Horario

GO
Create PROC REGISTRO_DOCENTE
@DNI CHAR(8),
@NOMBRES VARCHAR(30),
@APELLIDOS VARCHAR (30),
@EDAD TINYINT,
@SEXO CHAR(1),
@DIRECCION VARCHAR(50),
@EMAIL VARCHAR (30),
@TELEFONO VARCHAR(12),
@FECHA_NACIMIENTO DATE,
@ID_ESPECIALIDAD INT,
@MENSAJE VARCHAR(100) OUTPUT
AS BEGIN
IF(EXISTS(SELECT * FROM DOCENTE WHERE Dni=@DNI))
SET @MENSAJE='N�mero de Dni: '+ @DNI +' Ya Se Encuentra Registrado'
ELSE
BEGIN
INSERT INTO DOCENTE VALUES (@DNI,@NOMBRES,@APELLIDOS,@EDAD,@SEXO,@DIRECCION,@EMAIL ,@TELEFONO,@FECHA_NACIMIENTO,@ID_ESPECIALIDAD)
SET @MENSAJE='Docente Registrado'
END
END
GO

CREATE PROC ACTUALIZAR_DOCENTE
@DNI CHAR(8),
@NOMBRES VARCHAR(30),
@APELLIDOS VARCHAR (30),
@EDAD TINYINT,
@SEXO CHAR(1),
@DIRECCION VARCHAR(50),
@EMAIL VARCHAR (30),
@TELEFONO VARCHAR(12),
@FECHA_NACIMIENTO DATE,
@ID_ESPECIALIDAD INT,
@MENSAJE VARCHAR(100) OUTPUT
AS BEGIN
UPDATE DOCENTE SET  DNI=@DNI,Nombres=@NOMBRES,Apellidos=@APELLIDOS ,Edad=@EDAD ,Sexo=@SEXO ,Direcci�n=@DIRECCION,Email=@EMAIL ,Tel�fono=@TELEFONO,Fecha_Nacimiento=@FECHA_NACIMIENTO ,Id_Especialidad=@ID_ESPECIALIDAD
WHERE Dni=@DNI
SET @MENSAJE='Datos Actualizados'
END
GO

CREATE PROC BUSCAR_DNI_DOCENTE
@DNI VARCHAR(8)
AS BEGIN
SELECT * FROM DOCENTE WHERE Dni LIKE @DNI+'%'
END
GO

CREATE PROC REGISTRAR_ESPECIALIDAD
@ESPECIALIDAD VARCHAR (30),
@MENSAJE VARCHAR(100) OUTPUT
AS BEGIN
INSERT INTO ESPECIALIDAD VALUES(@ESPECIALIDAD)
SET @MENSAJE='Registrado Ok'
END
GO

CREATE PROC REGISTRAR_MATRICULA
@FECHA DATE,
@MONTO SMALLMONEY,
@GRADO TINYINT,
@SECCION CHAR(1),
@COD_AULA Int,
@DNI_ALUMNO CHAR(8),
@NUM_A�O CHAR(4),
@MENSAJE VARCHAR(100) OUTPUT
AS 
declare @VacLib INT 
BEGIN
IF (EXISTS(SELECT*FROM MATRICULA WHERE Dni_Alumno=@DNI_ALUMNO AND Num_A�o=@NUM_A�O))
SET @MENSAJE='Alumno Ya Est� Matriculado'
ELSE BEGIN
IF( NOT EXISTS(Select * from ALUMNO where Dni=@DNI_ALUMNO))
set @MENSAJE='El Alumno no Est� Registrado'
else begin
INSERT INTO MATRICULA VALUES(@FECHA,@MONTO,@GRADO,@SECCION ,@COD_AULA ,@DNI_ALUMNO,@NUM_A�O)
SET @MENSAJE='Matr�cula Registrada'
Update AULAS set VacantesLib=VacantesLib-1 where Cod_Aula=@COD_AULA
END
END
END
GO

--declare @MENSAJE VARCHAR(100)
--exec REGISTRAR_MATRICULA '20/03/2012',25,1,'A','1','45815240','2012',@MENSAJE OUTPUT
--SELECT @MENSAJE
--GO
--select * from MATRICULA
--GO

Create PROC ACTUALIZAR_MATRICULA
@FECHA DATE,
@MONTO SMALLMONEY,
@GRADO TINYINT ,
@SECCION CHAR(1),
@COD_AULA Int,
@DNI_ALUMNO CHAR(8),
@NUM_A�O CHAR(4),
@MENSAJE VARCHAR(100) OUTPUT
AS BEGIN
If(Not exists(Select * from ALUMNO where Dni=@DNI_ALUMNO))
set @MENSAJE='El Alumno No est� Registrado'
else begin
UPDATE MATRICULA SET Fecha=@FECHA,Monto=@MONTO,Grado=@GRADO,Secci�n=@SECCION,Id_Aula=@COD_AULA,Num_A�o=@NUM_A�O
WHERE Dni_Alumno=@DNI_ALUMNO
SET @MENSAJE='Datos Actualizados'
END
End
GO


CREATE PROC REGISTRAR_A�OESCOLAR
@NUM_A�O CHAR(4),
@FECHA_INICIO DATE ,
@FECHA_TERMINO DATE,
@MENSAJE VARCHAR(100) OUTPUT
AS BEGIN
IF(EXISTS(SELECT*FROM A�O_ESCOLAR WHERE Num_A�o=@NUM_A�O))
SET @MENSAJE='El A�o Escolar S�lo se Registra una Vez'
ELSE 
BEGIN
INSERT INTO A�O_ESCOLAR VALUES(@NUM_A�O,@FECHA_INICIO,@FECHA_TERMINO)
SET @MENSAJE='Registrado Ok'
END
END
GO

--declare @MENSAJE varchar(100)
--exec REGISTRAR_A�OESCOLAR '2012','01/02/2012','21/12/2012',@MENSAJE output
--select @MENSAJE
--go 
--select*from A�O_ESCOLAR
--go
Create Function DBO.DevolverCapacidad(@Cod_Aula Int) returns TINYINT
as 
begin
declare @Cap TINYINT
set @Cap=(select Capacidad  from AULAS where Cod_Aula=@Cod_Aula)
return (@Cap)
end
go


CREATE PROC BUSCAR_MATRICULA
@DNI_ALUMNO CHAR(8),
@MENSAJE VARCHAR(100) OUTPUT
AS BEGIN
SELECT * FROM MATRICULA WHERE Dni_Alumno=@DNI_ALUMNO
SET @MENSAJE='Datos Encontrados'
END
GO

CREATE PROC BUSCAR_NOMBRES_DOCENTE
@NOMBRES VARCHAR(30)
AS BEGIN
SELECT * FROM DOCENTE WHERE Nombres LIKE @NOMBRES+'%'
END
GO



--Nuevo Procedimiento para Inicio de Sesi�n
Create Proc InicioSesion(
@Usu varchar(20),
@Contra varchar(20),
@msj varchar(60)output)
as
begin
if(not exists(select * from Usuario where Nombre=@Usu and Contrase�a=@Contra))
set @msj='Datos Incorrectos'
else
begin
set @msj='Bienvenido Sr(a): ' +@Usu
end
end
go


CREATE Proc BuscVacLi(
@codaula int,
@vaclib int output
)
as
begin
Select Capacidad from Aulas where Cod_Aula=@codaula
set @vaclib=(select VacantesLib
from  AULAS where Cod_Aula=@codaula)
end
go

CREATE Proc BuscaVacLi(
@codaula int,
@vaclib int output
)
as
begin
set @vaclib=(select VacantesLib
from  AULAS where Cod_Aula=@codaula)
end
go

--*******Procedimiento para Listar Alumnos de un grado y seccion especifico*****
CREATE Proc BuscAl 
@grado int
as
begin
Select A.Nombres,A.Ap_Materno + ' '+ A.Ap_Materno as 'Apellidos'  ,M.GRADO as 'Grado' ,M.Secci�n as 'Secci�n'
from ALUMNO A inner join MATRICULA M on A.DNI=M.DNI_ALUMNO 
Where M.GRADO=@grado
end
go
--exec BuscAl '1'

CREATE Proc BuscarEspec
@letra varchar(30)
as
begin
Select * from ESPECIALIDAD where Especialidad like @letra + '%' 
end 
go


--SELECT*FROM DOCUMENTACION
--go

Create PROC BUSCAR_DOCUMENTO
as
begin
SELECT alu.Dni,alu.Nombres,alu.Ap_Paterno+' '+alu.Ap_Materno as 'Apellidos',doc.Partida,doc.Certificado FROM DOCUMENTACION doc inner join ALUMNO alu on doc.Dni_Alumno=alu.Dni 
WHERE doc.Partida='N' or doc.Certificado='N'
END
GO

CREATE PROC ACTUALIZAR_DOCUMENTOS
(@Partida CHAR(1),
@Certificado CHAR(1),
@Dni_Alumno char(8),
@MENSAJE VARCHAR(100)OUTPUT)
AS
BEGIN
update DOCUMENTACION SET Partida=@Partida,Certificado=@Certificado WHERE Dni_Alumno=@Dni_Alumno
SET @MENSAJE='Datos Actualidos'
END
GO

Create Proc RegistrarDoc
@Partida CHAR(1),
@Certificado CHAR(1),
@Dni_Alumno char(8)
as
begin
Insert into DOCUMENTACION values (@Partida,@Certificado,@Dni_Alumno)
end
go


---===========================================CONSULTAS==================================================
---===========================================CONSULTAS==================================================


-----Mostrar un listado de apoderados y alumnos su cargo
CREATE PROC CONSULTA_PARENTESCO_ALUMNO
--(@DNI CHAR(8))
AS
BEGIN
SELECT AP.Dni as 'Dni Apoderado',AP.Nombres +'  '+ AP.Apellidos AS 'Nombre del Apoderado', P.Parentesco AS 'Parentesco',A.Dni as 'Dni Alumno',A.Nombres+'  '+A.Ap_Materno+'  '+A.Ap_Paterno AS 'Nombre del Alumno' FROM PARENTESCO P INNER JOIN ALUMNO A ON P.Dni_Alumno=A.Dni INNER JOIN APODERADO AP ON P.Dni_Apoderado=AP.Dni
--WHERE A.Dni=@DNI
GROUP BY AP.Dni,AP.Nombres +'  '+ AP.Apellidos, P.Parentesco,A.Dni,A.Nombres+'  '+A.Ap_Materno+'  '+A.Ap_Paterno
END
GO
 
--EXEC  CONSULTA_PARENTESCO_ALUMNO --'45815240'
--GO
 
 -----Mostrar el parentesco del apoderado que tenga con el alumno segun su DNI ingresados
CREATE PROC CONSULTA_PARENTESCO_ALUMNO2
(@DNI CHAR(8))
AS
BEGIN
SELECT AP.Dni as 'Dni Apoderado',AP.Nombres +'  '+ AP.Apellidos AS 'Nombre del Apoderado', P.Parentesco AS 'Parentesco',A.Dni as 'Dni Alumno',A.Nombres+'  '+A.Ap_Materno+'  '+A.Ap_Paterno AS 'Nombre del Alumno' FROM PARENTESCO P INNER JOIN ALUMNO A ON P.Dni_Alumno=A.Dni INNER JOIN APODERADO AP ON P.Dni_Apoderado=AP.Dni
WHERE AP.Dni=@DNI
GROUP BY AP.Dni,AP.Nombres +'  '+ AP.Apellidos, P.Parentesco,A.Dni,A.Nombres+'  '+A.Ap_Materno+'  '+A.Ap_Paterno
END
GO
 
--EXEC  CONSULTA_PARENTESCO_ALUMNO2 '12345679'
--GO


 -----Mostrar las notas de un alumno de un curso y trimestre especifico
 CREATE PROC CONSULTA_NOTAS_CURSO_TRIMESTRE
 (@DNI CHAR(8),
 @COD_CURSO CHAR(5),
 @COD_TRI INT)
 AS 
 BEGIN
 SELECT Descripci�n,Nota
 FROM  NOTAS
 WHERE Dni_Alumno=@DNI AND Id_Curso=@COD_CURSO AND Id_Trimestre=@COD_TRI
 END
 GO
 
 --EXEC CONSULTA_NOTAS_CURSO_TRIMESTRE '47660746','CS001', 1
 --GO
 
 ----CONSULTA PARA MOSTRAR EL PROMEDIO DE TODOS LOS CURSOS DE UN ALUMNO
 CREATE PROC CONSULTA_DETALLE_TRIMESTRE
 (@DNI_ALU CHAR(8),
  @TRIME INT)--,
 --@A�O CHAR (4))
 AS 
 BEGIN
SELECT C.Nombres AS 'Curso',
 (select AVG(N1.Nota) from NOTAS as n1 where n1.Dni_Alumno=AL.Dni and n1.Id_Curso=C.Cod_Curso and n1.Id_Trimestre=n.Id_Trimestre)  AS 'Promedio',T.Descripci�n
 FROM MATRICULA M inner join ALUMNO AL ON M.Dni_Alumno=AL.Dni INNER JOIN NOTAS N ON N.Dni_Alumno=AL.Dni 
 INNER JOIN CURSO C ON N.Id_Curso=C.Cod_Curso 
 INNER JOIN TRIMESTRES T ON N.Id_Trimestre=T.Cod_Trimestre 
 WHERE N.Dni_Alumno=@DNI_ALU AND N.Id_Trimestre=@TRIME -- AND  M.Num_A�o=@A�O
 GROUP BY C.Nombres,AL.Dni,C.Cod_Curso,N.Id_Trimestre,T.Descripci�n
 end
 GO
--EXEC CONSULTA_DETALLE_TRIMESTRE '47660746',3
-- GO

 
-----Mostrar el detalle de notas del curso del alumno segun su DNI y Codigo de Curso
 CREATE PROC CONSULTA_DELTALLE_CURSOS_NOTAS_ALUMNO
 (@DNI CHAR(8),
 @CURSO CHAR(5),
 @Trimestre int)
 AS 
 BEGIN
 SELECT N.Descripci�n,N.Nota FROM NOTAS N INNER JOIN ALUMNO A ON N.Dni_Alumno=A.Dni
 INNER JOIN CURSO C ON N.Id_Curso=C.Cod_Curso INNER JOIN TRIMESTRES T ON N.Id_Trimestre=T.Cod_Trimestre
 WHERE A.Dni=@DNI AND C.Cod_Curso=@CURSO AND T.Cod_Trimestre=@Trimestre
 GROUP BY N.Descripci�n,N.Nota
 END
 GO
 --EXEC CONSULTA_DELTALLE_CURSOS_NOTAS_ALUMNO'47660746','MAT01',1
 --GO


----Mostrar todo lo  recaudado de las matriculas del a�o actual
 CREATE PROC CONSULTA_RECAUDADO_MATRICULAS_A�O
 (@FECH CHAR(4))
 AS
 BEGIN
 SELECT COUNT(*) AS 'Cantidad De Matriculas',SUM(Monto) AS 'Total Recaudado' FROM MATRICULA
 WHERE YEAR(Fecha)=@FECH
 GROUP BY Monto
 END
 GO
 
 
 --EXEC CONSULTA_RECAUDADO_MATRICULAS_A�O'2012'
 --GO
 
 ----Mostrar todo lo  recaudado de las matriculas de un detrminado dia
CREATE PROC CONSULTA_RECAUDADO_MATRICULAS_DIA
 (@DIA DATE)
 AS
 BEGIN
 SELECT COUNT(*) AS 'Cantidad De Matriculas',SUM(Monto) AS 'Total Recaudado' FROM MATRICULA
 WHERE Fecha=@DIA
 END
 GO
 
 --EXEC CONSULTA_RECAUDADO_MATRICULAS_DIA '20/05/2012'
 --GO
 
 Create PROC CONSULTA_PROM_FINAL
 @GRADO INT,
 @COD_TRIMESTRE INT
 AS BEGIN
 SELECT   AL.Nombres,AL.Ap_Paterno+' '+AL.Ap_Materno AS 'Apellidos',N.Nota,C.Nombres,T.Descripci�n,
 ( Select avg(Nota) from NOTAS n inner join TRIMESTRES t on n.Id_Trimestre=n.Id_Trimestre where t.Cod_Trimestre='1' AND Id_Trimestre='1') as 'Promedio'
  FROM MATRICULA MA INNER JOIN ALUMNO AL ON MA.Dni_Alumno=AL.Dni
 inner join NOTAS N ON N.Dni_Alumno=AL.Dni INNER JOIN TRIMESTRES T ON T.Cod_Trimestre=N.Id_Trimestre
  INNER JOIN CURSO C ON N.Id_Curso=C.Cod_Curso
  WHERE MA.Grado=@GRADO AND T.Cod_Trimestre=@COD_TRIMESTRE
 GROUP BY AL.Nombres,AL.Ap_Paterno+' '+AL.Ap_Materno,N.Nota,C.Nombres,T.Descripci�n
 END 
 GO
 
--consulta prof
Create PROC CONSULTA_PROMEDIO_CURSO_TODOSLOSTRIMESTRES
 (@DNI_ALU CHAR(8),
 @msj varchar(100) output
 )
 AS 
 BEGIN
 if(not exists(Select * from ALUMNO WHERE Dni=@DNI_ALU))
 SET @msj='El Dni del Alumno no Existe'
 else
 begin
 if(exists(Select * from ALUMNO WHERE Dni=@DNI_ALU))
  set @msj='Datos Encontrados'
SELECT distinct(C.Nombres) AS 'Curso',
 (select AVG(N1.Nota) from NOTAS as n1 where n1.Dni_Alumno=AL.Dni and n1.Id_Curso=C.Cod_Curso and n1.Id_Trimestre=1)  AS 'Trimestre I',
 (select AVG(N1.Nota) from NOTAS as n1 where n1.Dni_Alumno=AL.Dni and n1.Id_Curso=C.Cod_Curso and n1.Id_Trimestre=2) AS 'Trimestre II',
 (select AVG(N1.Nota) from NOTAS as n1 where n1.Dni_Alumno=AL.Dni and n1.Id_Curso=C.Cod_Curso and n1.Id_Trimestre=3)as 'Trimestre III',
 ((select AVG(N1.Nota) from NOTAS as n1 where n1.Dni_Alumno=AL.Dni and n1.Id_Curso=C.Cod_Curso and n1.Id_Trimestre=1) +
 (select AVG(N1.Nota) from NOTAS as n1 where n1.Dni_Alumno=AL.Dni and n1.Id_Curso=C.Cod_Curso and n1.Id_Trimestre=2) +
 (select AVG(N1.Nota) from NOTAS as n1 where n1.Dni_Alumno=AL.Dni and n1.Id_Curso=C.Cod_Curso and n1.Id_Trimestre=3))/3 as 'Promedio Final'
  FROM MATRICULA M inner join ALUMNO AL ON M.Dni_Alumno=AL.Dni INNER JOIN NOTAS N ON N.Dni_Alumno=AL.Dni 
 INNER JOIN CURSO C ON N.Id_Curso=C.Cod_Curso INNER JOIN TRIMESTRES T ON N.Id_Trimestre=T.Cod_Trimestre 
 WHERE N.Dni_Alumno=@DNI_ALU --AND N.Id_Trimestre=@TRIME -- AND  M.Num_A�o=@A�O
 GROUP BY C.Nombres,AL.Dni,C.Cod_Curso,N.Id_Trimestre
 end
 end
  GO
 

-- Select * from ALUMNO  
-- declare @msj varchar(100)
--EXEC CONSULTA_PROMEDIO_CURSO_TODOSLOSTRIMESTRES '45815240',@msj output
--Select @msj
--go

