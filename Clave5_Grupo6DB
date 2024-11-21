CREATE DATABASE Clave5_Grupo6;
USE Clave5_Grupo6;
CREATE TABLE Salas (
    SalaID INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(100),
    Capacidad INT,
    Ubicacion VARCHAR(100),
    Equipos VARCHAR(200)
);

CREATE TABLE Reservas (
    ReservaID INT PRIMARY KEY AUTO_INCREMENT,
    SalaID INT,
    Fecha DATE,
    Hora TIME,
    NombrePersona VARCHAR(100),
    FOREIGN KEY (SalaID) REFERENCES Salas(SalaID)
);
CREATE TABLE Usuarios (
    UsuarioID INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(100),
    Correo VARCHAR(100),
    Contraseña VARCHAR(100)
);
USE Clave5_Grupo6
SHOW TABLES;
DESCRIBE Salas;
DESCRIBE Usuarios;
DESCRIBE Reservas;
INSERT INTO Salas (Nombre, Capacidad, Ubicacion, Equipos) VALUES
('Sala A', 10, 'Piso 1', 'Proyector, Oasis, Cafetera'),
('Sala B', 15, 'Piso 2', 'Oasis, Cafetera'),
('Sala C', 25, 'Piso 3', 'Proyector, Oasis'),
('Sala D', 20, 'Piso 1', 'Proyector, Cafetera');
DESCRIBE Salas;
INSERT INTO Usuarios (Nombre, Correo, Contraseña) VALUES
('Juan Pérez', 'juan.perez@example.com', 'password1'),
('Ana López', 'ana.lopez@example.com', 'password2'),
('Carlos Ruiz', 'carlos.ruiz@example.com', 'password3');

INSERT INTO Reservas (SalaID, Fecha, Hora, NombrePersona) VALUES
(1, '2024-11-14', '10:00:00', 'Juan Pérez'),
(2, '2024-11-14', '14:00:00', 'Ana López'),
(3, '2024-11-15', '09:00:00', 'Carlos Ruiz'),
(4, '2024-11-15', '13:00:00', 'Juan Pérez');

SELECT * FROM Salas;
SELECT * FROM Usuarios;
SELECT * FROM Reservas;

SHOW DATABASES

USE Clave5_Grupo6;

INSERT INTO Usuarios (Nombre, Correo, Contraseña) VALUES
('Carlos Pérez', 'carlos.perez@mail.com', '12345'),
('Ana Gómez', 'ana.gomez@mail.com', 'password123'),
('Luis Martínez', 'luis.martinez@mail.com', 'admin123'),
('Marta Ramírez', 'marta.ramirez@mail.com', 'abcde123'),
('Javier López', 'javier.lopez@mail.com', 'qwerty123'),
('Laura Hernández', 'laura.hernandez@mail.com', '123qwe'),
('David Fernández', 'david.fernandez@mail.com', '09876abc'),
('Paula García', 'paula.garcia@mail.com', 'pass12345'),
('Pedro Sánchez', 'pedro.sanchez@mail.com', 'hello123'),
('Clara Díaz', 'clara.diaz@mail.com', 'secret123'),
('José Torres', 'jose.torres@mail.com', 'passw0rd'),
('Elena Vázquez', 'elena.vazquez@mail.com', 'admin2024'),
('Iván Muñoz', 'ivan.munoz@mail.com', 'zxcvbn123'),
('Sofía Jiménez', 'sofia.jimenez@mail.com', '12345abc'),
('Felipe Morales', 'felipe.morales@mail.com', '123456');

INSERT INTO Salas (Nombre, Capacidad, Ubicacion, Equipos) VALUES
('Sala A', 20, 'Piso 1, Ala Norte', 'Proyector, Pantalla, Micrófono'),
('Sala B', 15, 'Piso 1, Ala Sur', 'Pantalla, Micrófono'),
('Sala C', 30, 'Piso 2, Ala Este', 'Proyector, Pantalla, Audio, Micrófono'),
('Sala D', 10, 'Piso 3, Ala Oeste', 'Pantalla, Micrófono'),
('Sala E', 25, 'Piso 2, Ala Norte', 'Proyector, Pantalla'),
('Sala F', 12, 'Piso 3, Ala Sur', 'Proyector'),
('Sala G', 50, 'Piso 1, Ala Oeste', 'Pantalla, Audio, Micrófono, Proyector'),
('Sala H', 8, 'Piso 1, Ala Este', 'Pantalla'),
('Sala I', 18, 'Piso 2, Ala Sur', 'Proyector, Pantalla'),
('Sala J', 22, 'Piso 3, Ala Norte', 'Proyector, Micrófono'),
('Sala K', 35, 'Piso 1, Ala Este', 'Pantalla, Proyector'),
('Sala L', 40, 'Piso 2, Ala Oeste', 'Audio, Micrófono'),
('Sala M', 60, 'Piso 3, Ala Este', 'Proyector, Pantalla, Audio, Micrófono'),
('Sala N', 55, 'Piso 1, Ala Central', 'Proyector, Pantalla'),
('Sala O', 10, 'Piso 1, Ala Norte', 'Micrófono');

INSERT INTO Reservas (SalaID, Fecha, Hora, NombrePersona) VALUES
(1, '2024-11-20', '09:00:00', 'Carlos Pérez'),
(2, '2024-11-21', '10:30:00', 'Ana Gómez'),
(3, '2024-11-22', '14:00:00', 'Luis Martínez'),
(4, '2024-11-23', '08:00:00', 'Pedro Sánchez'),
(5, '2024-11-24', '15:00:00', 'Marta López'),
(6, '2024-11-25', '11:30:00', 'Javier Fernández'),
(7, '2024-11-26', '16:00:00', 'Lucía Rodríguez'),
(8, '2024-11-27', '12:00:00', 'Antonio Gómez'),
(9, '2024-11-28', '09:30:00', 'Patricia Ruiz'),
(10, '2024-11-29', '13:00:00', 'Raúl Pérez'),
(11, '2024-11-30', '10:00:00', 'Isabel Díaz'),
(12, '2024-12-01', '14:30:00', 'David González'),
(13, '2024-12-02', '08:30:00', 'Victoria Jiménez'),
(14, '2024-12-03', '16:30:00', 'José Fernández'),
(15, '2024-12-04', '11:00:00', 'Manuel López');

DESCRIBE Usuarios;
DESCRIBE Salas;
DESCRIBE Reservas;

SELECT * FROM Reservas;

