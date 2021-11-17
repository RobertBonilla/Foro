
CREATE DATABASE Foro
GO
USE Foro
go

CREATE TABLE Usuario(
idUsuario int identity(1,1) primary key not null,
username varchar(25) unique not null,
nombre varchar(50) not null,
correo varchar(50) null,
contra varchar(25) not null,
activo bit default 1 not null)
GO

CREATE TABLE Pregunta(
idPregunta int identity(1,1) primary key not null,
idUsuario int not null,
titulo varchar(100) not null,
descripcion text not null,
fecha datetime DEFAULT GETDATE() not null,
activo BIT DEFAULT 1 not null,
FOREIGN KEY (idUsuario) REFERENCES Usuario (idUsuario))
GO

CREATE TABLE Respuesta(
idRespuesta int identity(1,1) primary key not null,
idPregunta int not null,
idUsuario int not null,
descripcion text not null,
fecha datetime default GETDATE() not null,
FOREIGN KEY (idPregunta) REFERENCES Pregunta (idPregunta),
FOREIGN KEY (idUsuario) REFERENCES Usuario (idUsuario))
GO