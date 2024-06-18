-- Crear la base de datos si no existe
CREATE DATABASE IF NOT EXISTS estudianet_db;


USE estudianet_db;

-- Crear la tabla de estudiante
CREATE TABLE IF NOT EXISTS estudiante (
    id INT AUTO_INCREMENT PRIMARY KEY,
    cedula_identidad VARCHAR(20) NOT NULL UNIQUE,
    nombre VARCHAR(50) NOT NULL,
    apellido_paterno VARCHAR(50) NOT NULL,
    apellido_materno VARCHAR(50) NOT NULL,
    fecha_nacimiento DATE NOT NULL,
    correo_electronico VARCHAR(100) NOT NULL
);

-- Insertar datos de ejemplo en la tabla estudiante
INSERT INTO estudiante (cedula_identidad, nombre, apellido_paterno, apellido_materno, fecha_nacimiento, correo_electronico) VALUES
('12345678', 'Juan', 'Pérez', 'González', '2004-06-15', 'juan.perez@example.com'),
('87654321', 'María', 'Gómez', 'Ramírez', '2002-03-22', 'maria.gomez@example.com'),
('11223344', 'Luis', 'Rodríguez', 'Fernández', '2005-12-10', 'luis.rodriguez@example.com');
