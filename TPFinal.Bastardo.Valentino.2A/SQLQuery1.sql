CREATE DATABASE Productos_TP4;
GO
USE Productos_TP4;
GO
CREATE TABLE Productos
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	clase INT NOT NULL,
	nombre VARCHAR(50) NOT NULL,
	precio FLOAT NOT NULL,
	vendidas FLOAT NOT NULL,
	consola INT NOT NULL,
	color INT,
	genero INT,
);
GO
INSERT INTO Productos (clase, nombre, precio, vendidas, consola, color, genero) VALUES
(0, 'Silent Hill 2', 60, 100, 0, null,4),
(0, 'Resident Evil 4', 40, 10, 1, null,0),
(0, 'GTA San Andreas', 100, 15, 0, null,6),
(0, 'Okami', 50, 2, 0, null,1),
(0, 'Luigi Telo', 12, 100, 1, null,5),
(0, 'Neiner 9', 25, 25, 0, null,0),
(0, 'PES 2011 Liga Chaco', 60, 1000, 0, null,2),
(0, 'Resident Evil 4', 35, 120, 0, null,0),
(1, 'PlayStation 2 Rosa', 600, 4, 0, 5,null),
(1, 'PlayStation 2 Negra', 500, 27, 0, 1,null),
(1, 'PlayStation 2 Blanca', 500, 4, 0, 0,null),
(2, 'GameCube Blanca', 700, 1, 1, 0,null),
(2, 'GameCube Bostera', 350, 15, 1, 6,null),
(2, 'GameCube Rosa', 670, 25, 1, 5,null);
