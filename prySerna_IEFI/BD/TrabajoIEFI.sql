CREATE DATABASE TrabajoIEFI;
USE TrabajoIEFI;

CREATE TABLE Usuarios (
    IdUsuario INT IDENTITY(1,1) PRIMARY KEY,
    Usuario VARCHAR(100),
    Contraseña VARCHAR(100),
    Rol  VARCHAR(100),
    FechaCreacion DATETIME DEFAULT GETDATE(),
    UltimaConexion DATETIME,
    TiempoUltimaConexion TIME,
    TiempoTotal TIME,
    Estado VARCHAR(20) DEFAULT 'Activo'
);




INSERT INTO Usuarios (Usuario, Contraseña, Rol, FechaCreacion, UltimaConexion, TiempoUltimaConexion, TiempoTotal, Estado)
VALUES
-- Usuario conectado hoy, a la hora actual (simulada con GETDATE())
('usuario1', '111', 'Administrador', GETDATE(), GETDATE(), CAST('00:45:00' AS TIME), CAST('05:30:00' AS TIME), 'Activo'),

-- Usuario conectado ayer a las 20:00
('usuario2', '222', 'Usuario', DATEADD(day, -5, GETDATE()), '2025-05-22 20:00:00', CAST('01:15:00' AS TIME), CAST('10:00:00' AS TIME), 'Activo'),

-- Usuario conectado hace 2 días a las 08:30 am
('usuario3', '333', 'Usuario', DATEADD(day, -10, GETDATE()), '2025-05-21 08:30:00', CAST('00:30:00' AS TIME), CAST('02:45:00' AS TIME), 'Inactivo');

