CREATE DATABASE CRIPTO2 --Este comando cria um banco de dados

GO
USE CRIPTO2

GO
CREATE TABLE Usuarios 
(
 UsuarioId INT PRIMARY KEY IDENTITY,
 Email VARCHAR(100) UNIQUE NOT NULL,
 Senha VARCHAR(50) NOT NULL
)

GO
INSERT INTO Usuarios VALUES ('outroemail@email', 1234)

GO
SELECT * FROM Usuarios

SELECT UsuarioId, Email, HASHBYTES('MD2',Senha) AS 'Senha HASH' FROM Usuarios WHERE UsuarioId = 1
SELECT UsuarioId, Email, HASHBYTES('MD4',Senha) AS 'Senha HASH' FROM Usuarios WHERE UsuarioId = 1
SELECT UsuarioId, Email, HASHBYTES('MD5',Senha) AS 'Senha HASH' FROM Usuarios WHERE UsuarioId = 1
SELECT UsuarioId, Email, HASHBYTES('SHA',Senha) AS 'Senha HASH' FROM Usuarios WHERE UsuarioId = 1
SELECT UsuarioId, Email, HASHBYTES('SHA2_256',Senha) AS 'Senha HASH' FROM Usuarios WHERE UsuarioId = 1
SELECT UsuarioId, Email, HASHBYTES('SHA2_512',Senha) AS 'Senha HASH' FROM Usuarios WHERE UsuarioId = 1
