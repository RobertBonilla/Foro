USE Foro
GO

--Procedimiento para almacenar usuario
CREATE PROCEDURE dbo.usuario_registrar 
       @username             NVARCHAR(25)  = NULL   , 
       @nombre               NVARCHAR(50)  = NULL   , 
       @correo               NVARCHAR(50)  = NULL   , 
       @contra               NVARCHAR(25)  = NULL   	   
AS 
BEGIN
	Declare @Exist INT = -1;
	SET @Exist = (SELECT count(*) FROM Usuario WHERE username = @username)
	IF(@Exist = 0)
		BEGIN
				 INSERT INTO dbo.Usuario (username,nombre,correo,contra)
				 VALUES (@username,@nombre,@correo,@contra);
		END
	ELSE
		BEGIN
			RAISERROR('El usuario ingresado se encuentra en uso',11,1) WITH NOWAIT
		END
END 

GO

--Prueba de ejecucion
--exec dbo.usuario_registrar
--    @username = 'robert2',
--	@nombre  = 'Roberto',
--	@correo  = 'correo@correo.com',
--	@contra  = '1234'
--GO

--Iniciar Session Usuario

CREATE PROCEDURE dbo.usuario_login
	@username             NVARCHAR(25)  = NULL   , 
    @contra               NVARCHAR(25)  = NULL   
AS 
BEGIN	
	IF EXISTS (SELECT idUsuario FROM Usuario u WHERE u.username = @username AND u.contra = @contra)
		BEGIN
				SELECT u.idUsuario,u.username,u.nombre,u.correo,u.activo
				FROM Usuario u
				WHERE u.username = @username AND u.contra = @contra
		END
	ELSE
		BEGIN
			RAISERROR('Los datos no coinciden',11,1) WITH NOWAIT
		END
END
GO

--exec dbo.usuario_login
--@username = 'robert',
--@contra = '12344'
--GO

--SELECT * FROM Usuario

-----Procedimiento para Almacenar Pregunta
CREATE PROCEDURE dbo.pregunta_registrar 
       @idUsuario            INT  = NULL   , 
       @titulo               NVARCHAR(100)  = NULL   , 
       @descripcion          TEXT  = NULL      
AS 
BEGIN
	INSERT INTO dbo.Pregunta(idUsuario,titulo,descripcion) VALUES (@idUsuario,@titulo,@descripcion);
END
GO

----Prueba de ejecucion
--exec dbo.pregunta_registrar
--    @idUsuario = 1, 
--	@titulo = 'Prueba 3',    
--	@descripcion = 'Prueba 2'
--GO

-----Procedimiento para Almacenar Respuesta, Validar Abierta
CREATE PROCEDURE dbo.respuesta_registrar 
	   @idPregunta			 INT  = NULL   ,
       @idUsuario            INT  = NULL   , 
       @descripcion          TEXT  = NULL      
AS 
BEGIN
Declare @Abierta INT = -1;
	SET @Abierta = (SELECT activo FROM Pregunta WHERE idPregunta = @idPregunta)
	IF(@Abierta = 1)
		BEGIN
				 INSERT INTO dbo.Respuesta (idPregunta,idUsuario,descripcion) VALUES (@idPregunta,@idUsuario,@descripcion);
		END
	ELSE
		BEGIN
			RAISERROR('La Pregunta fue Cerrada, ya no se puede responder ',11,1) WITH NOWAIT
		END
	
END
GO
--Prueba de ejecucion
--exec dbo.respuesta_registrar
--	@idPregunta = 2, 
--    @idUsuario = 1, 
--	@descripcion = 'Prueba 2'
--GO


-----Procedimiento para Cerrar una Pregunta
CREATE PROCEDURE dbo.pregunta_cerrar
	   @idPregunta			 INT  = NULL      
AS 
BEGIN
	UPDATE dbo.Pregunta SET activo = 0 WHERE idPregunta = @idPregunta; 
END
GO

--exec dbo.pregunta_cerrar
--	@idPregunta = 3
--GO

--Consultar Todas las Preguntas Ordenadas por Fecha
CREATE PROCEDURE dbo.pregunta_get_lista     
AS 
BEGIN
	SELECT p.idPregunta,p.idUsuario,p.titulo,p.descripcion,
	p.fecha,p.activo,u.username,u.nombre
	FROM Pregunta p
	INNER JOIN Usuario u on p.idUsuario = u.idUsuario
	ORDER BY p.fecha DESC 
END
GO

--exec dbo.pregunta_get_lista
--GO

--Consultar una Pregunta
CREATE PROCEDURE dbo.pregunta_get 
	@idPregunta	INT  = NULL   
AS 
BEGIN
	SELECT p.idPregunta,p.idUsuario,p.titulo,p.descripcion,
	p.fecha,p.activo,u.username,u.nombre
	FROM Pregunta p
	INNER JOIN Usuario u on p.idUsuario = u.idUsuario
	WHERE p.idPregunta = @idPregunta
END
GO

--exec dbo.pregunta_get
--@idPregunta = 1
--GO
--Consultar Todas las Respuestas de una Pregunta
CREATE PROCEDURE dbo.respuesta_get_lista 
	@idPregunta	INT  = NULL   
AS 
BEGIN
	SELECT r.idRespuesta,r.idPregunta,r.idUsuario,
	r.descripcion,r.fecha,u.username,u.nombre
	FROM Respuesta r
	INNER JOIN Usuario u on r.idUsuario = u.idUsuario
	WHERE r.idPregunta = @idPregunta
	ORDER BY r.fecha DESC
END
GO

--exec dbo.respuesta_get_lista
--@idPregunta = 2
--GO

SELECT * FROM dbo.Pregunta

Update Pregunta set activo = 1

DELETE FROM Respuesta
GO
DELETE FROM Pregunta
GO
DELETE FROM Usuario


