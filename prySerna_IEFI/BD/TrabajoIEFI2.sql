CREATE DATABASE TrabajoIEFI
USE TrabajoIEFI;
CREATE TABLE Usuarios (
    IdUsuario INT IDENTITY(1,1) PRIMARY KEY,
    Usuario VARCHAR(100),
    Contraseña VARCHAR(100),
    Rol  VARCHAR(100),
     Direccion VARCHAR(100),
    Dni BIGINT,
    Telefono BIGINT,
    Gmail VARCHAR(100) UNIQUE,
    FechaCreacion DATETIME DEFAULT GETDATE(),
    UltimaConexion DATETIME,
    TiempoUltimaConexion TIME,
    TiempoTotal TIME,
    Estado VARCHAR(20) DEFAULT 'Activo'
);
INSERT INTO Usuarios (Usuario, Contraseña, Rol, Direccion, Dni, Telefono, Gmail, FechaCreacion, UltimaConexion, TiempoUltimaConexion, TiempoTotal, Estado)
VALUES
-- Usuario conectado hoy, a la hora actual (simulada con GETDATE())
('usuario1', '111', 'Administrador', 'Martin Fiero', '45833489', '3517496767', 'usuario1@gmail.com', GETDATE(), GETDATE(), CAST('00:45:00' AS TIME), CAST('05:30:00' AS TIME), 'Activo'),

-- Usuario conectado ayer a las 20:00
('usuario2', '222', 'Usuario', 'Martin Fiero', '45833487', '3517496769', 'usuario2@gmail.com',DATEADD(day, -5, GETDATE()), '2025-05-22 20:00:00', CAST('01:15:00' AS TIME), CAST('10:00:00' AS TIME), 'Activo'),

-- Usuario conectado hace 2 días a las 08:30 am
('usuario3', '333', 'Usuario','Martin Fiero', '45833485', '3517496768', 'usuario3@gmail.com', DATEADD(day, -10, GETDATE()), '2025-05-21 08:30:00', CAST('00:30:00' AS TIME), CAST('02:45:00' AS TIME), 'Inactivo');


Create table Tareas(
 IdTarea INT IDENTITY(1,1) PRIMARY KEY,
 IdUsuario INT,
 Usuario VARCHAR(100),
 Fecha DATETIME,
 TareaId INT,
FOREIGN KEY (TareaId) REFERENCES TareasTipo(Id),
 LugarId INT,
FOREIGN KEY (LugarId) REFERENCES Lugar(Id),
 Insumo BIT,
 Estudio  BIT,
 Vacaciones  BIT,
 Enfermedad  BIT,
 Salario  BIT,
 Recibo  BIT,
 Comentario VARCHAR(100)
 FOREIGN KEY (IdUsuario) REFERENCES Usuarios(IdUsuario)
 );
CREATE TABLE TareasTipo (
Id INT PRIMARY KEY IDENTITY,
Nombre NVARCHAR(50)
);
CREATE TABLE Lugar (
Id INT PRIMARY KEY IDENTITY,
Nombre NVARCHAR(50)
);

INSERT INTO TareasTipo (Nombre) VALUES ('Auditoria'), ('Consultas'), ('Inspección'), ('Reclamos'),('Visita');
INSERT INTO Lugar (Nombre) VALUES ('Empresa'), ('Servicio'), ('Oficina');
