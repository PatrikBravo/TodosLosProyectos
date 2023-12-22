----------------------------------------------ESTADOS-------------------------------------------------------------
-- Insertar Estados
CREATE or Alter PROCEDURE SP_Agregar_Estado
    @id INT,
    @nombre VARCHAR(100)
AS
BEGIN
   insert into Estados values(@id, @nombre)
END
go

select * from Estados
EXEC SP_Agregar_Estado @id=100 ,@nombre = 'carlos'
go


-- Actualizar Estados
CREATE or Alter PROCEDURE SP_Actualizar_Estado
    @id INT,
    @nombre VARCHAR(100)
AS
BEGIN
   update Estados set nombre = @nombre where id = @id
END
go

select * from Estados
EXEC SP_Actualizar_Estado @id=100 ,@nombre = 'juan'
go

-- Eliminar Estados
CREATE or Alter PROCEDURE SP_Eliminar_Estado
    @id INT
AS
BEGIN
   delete Estados where id = @id
END
go

select * from Estados
EXEC SP_Eliminar_Estado @id=100 
go

-- Consultar TODOS Estados
CREATE or Alter PROCEDURE SP_ConsultarTodo_Estado
AS
BEGIN
   select * from Estados 
END
go

select * from Estados
EXEC SP_ConsultarTodo_Estado
go

-- Consultar UNO Estados
CREATE or Alter PROCEDURE SP_ConsultarUNO_Estado
    @id INT
AS
BEGIN
   select * from Estados where id =@id
END
go

select * from Estados
EXEC SP_ConsultarUNO_Estado @id=100
go 

----------------------------------------------EstatusAlumno-------------------------------------------------------------
-- Insertar EstatusAlumno
CREATE or Alter PROCEDURE SP_Agregar_EstatusAlumno
    @id INT,
	@clave VARCHAR(10),
    @nombre VARCHAR(100)
AS
BEGIN
   insert into EstatusAlumno values(@id, @clave, @nombre)
END
go

select * from EstatusAlumno
EXEC SP_Agregar_EstatusAlumno @id=100, @clave = 'ME', @nombre = 'menso'
go


-- Actualizar EstatusAlumno
CREATE or Alter PROCEDURE SP_Actualizar_EstatusAlumno
    @id INT,
	@clave VARCHAR(10),
    @nombre VARCHAR(100)
AS
BEGIN
   update EstatusAlumno set nombre = @nombre, clave = @clave where id = @id
END
go

select * from EstatusAlumno
EXEC SP_Actualizar_EstatusAlumno @id=100, @clave = 'do', @nombre = 'juan'
go

-- Eliminar EstatusAlumno
CREATE or Alter PROCEDURE SP_Eliminar_EstatusAlumno
    @id INT
AS
BEGIN
   delete EstatusAlumno where id = @id
END
go

select * from EstatusAlumno
EXEC SP_Eliminar_EstatusAlumno @id=100 
go

-- Consultar TODOS EstatusAlumno
CREATE or Alter PROCEDURE SP_ConsultarTodo_EstatusAlumno
AS
BEGIN
   select * from EstatusAlumno 
END
go

select * from EstatusAlumno
EXEC SP_ConsultarTodo_EstatusAlumno
go

-- Consultar UNO EstatusAlumno
CREATE or Alter PROCEDURE SP_ConsultarUNO_EstatusAlumno
    @id INT
AS
BEGIN
   select * from EstatusAlumno where id =@id
END
go

select * from EstatusAlumno
EXEC SP_ConsultarUNO_EstatusAlumno @id=100
go 

-------------------------------------------------Alumnos-------------------------------------------------------------
-- Insertar Alumnos
CREATE or Alter PROCEDURE SP_Agregar_Alumnos
    @nombre varchar(50),
	@primerApellido varchar(50),
	@segundoApellido varchar(50),
	@correo varchar(80),
	@telefono nchar(10),
	@fechaNacimiento date,
	@curp char(18),
	@sueldo decimal(9,2),
	@idEstadoOrigen int,
	@idEstatus smallint
AS
BEGIN
   	insert into Alumnos values(@nombre, @primerApellido, @segundoApellido, @correo, @telefono, @fechaNacimiento, @curp, @sueldo, @idEstadoOrigen, @idEstatus)
END
go

select * from Alumnos
EXEC SP_Agregar_Alumnos @nombre='juan', @primerApellido='alberto',@segundoApellido='segundo',@correo='123456789',@telefono='452123456',@fechaNacimiento='1995-03-30',@curp='asdasdasda',@sueldo=100,@idEstadoOrigen=100,@idEstatus=100
go


-- Actualizar Alumnos
CREATE or Alter PROCEDURE SP_Actualizar_Alumnos
	@id int,
    @nombre varchar(50),
	@primerApellido varchar(50),
	@segundoApellido varchar(50),
	@correo varchar(80),
	@telefono nchar(10),
	@fechaNacimiento date,
	@curp char(18),
	@sueldo decimal(9,2),
	@idEstadoOrigen int,
	@idEstatus smallint
AS
BEGIN
   update Alumnos set nombre=@nombre, primerApellido=@primerApellido, segundoApellido=@segundoApellido, correo=@correo, telefono=@telefono, fechaNacimiento=@fechaNacimiento, 
					   curp=@curp, sueldo=@sueldo, idEstadoOrigen=@idEstadoOrigen, idEstatus=@idEstatus where id = @id
END
go

select * from Alumnos
EXEC SP_Actualizar_Alumnos @id=27, @nombre='juan2', @primerApellido='alberto2',@segundoApellido='segundo2',@correo='123',@telefono='123',
@fechaNacimiento='2000-03-30',@curp='babababa',@sueldo=110,@idEstadoOrigen=100,@idEstatus=100
go

-- Eliminar Alumnos
CREATE or Alter PROCEDURE SP_Eliminar_Alumnos
    @id INT
AS
BEGIN
   if EXISTS ( select id from CursosAlumnos where idAlumno = @id )
		delete CursosAlumnos where idAlumno = @id
	
	delete Alumnos where id = @id
END
go

select * from Alumnos
EXEC SP_Eliminar_Alumnos @id=27 
go

-- Consultar TODOS EstatusAlumno
CREATE or Alter PROCEDURE SP_ConsultarTodo_Alumnos
AS
BEGIN
   select * from Alumnos 
END
go

select * from Alumnos
EXEC SP_ConsultarTodo_Alumnos
go

-- Consultar UNO EstatusAlumno
CREATE or Alter PROCEDURE SP_ConsultarUNO_Alumnos
    @id INT
AS
BEGIN
   select * from Alumnos where id =@id
END
go

select * from Alumnos
EXEC SP_ConsultarUNO_Alumnos @id=20
go 