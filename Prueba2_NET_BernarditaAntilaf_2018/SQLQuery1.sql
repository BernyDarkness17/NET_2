CREATE DATABASE automoviles;
GO
USE automoviles;
GO
--drop database automoviles;

CREATE TABLE automovil(
	id INT PRIMARY KEY IDENTITY(1,1),
	patente VARCHAR(10),
	marca VARCHAR(50),
	anio VARCHAR(100),
	detalles VARCHAR(200),
	run VARCHAR(13),
	nombreCompleto VARCHAR(100),
	telefono VARCHAR(50)
);--select * from automovil;

INSERT INTO automovil VALUES('AAAA-11', 'Chevrolet', '2008', 'Perfecto estado', '19922911-7', 'Juan Leo Vergaras Parra', '88788878');
INSERT INTO automovil VALUES('BBBB-22', 'Nissan', '2015', 'Asiento trasero gastado', '12333888-K', 'Maria Salome Iturriaga Valencia', '22992299');
INSERT INTO automovil VALUES('CCCC-33', 'Peugeot', '2016', 'Sin cinturones de seguridad', '14076885-5', 'Alexander Piero Caceres Valencia', '33993388');

SELECT * FROM automovil WHERE patente like '%AA%';
SELECT COUNT(*) FROM automovil;