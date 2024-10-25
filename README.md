


Store procedures que se estaran utilizando:

-- Listar todos los empleados
CREATE OR ALTER PROCEDURE sp_ListarEmpleados
AS
BEGIN
    SELECT * FROM Empleado
END

-- Buscar un empleado por id
CREATE OR ALTER PROCEDURE sp_BuscarEmpleadoId
    @Id_Empleado INT
AS
BEGIN
    SELECT * FROM Empleado WHERE Id_Empleado = @Id_Empleado
END



-- Listar todos los clientes
CREATE OR ALTER PROCEDURE sp_ListarClientes
AS
BEGIN
    SELECT * FROM Cliente
END



-- buscar un empleado por usuario y contraseña
CREATE OR ALTER PROCEDURE sp_BuscarEmpleadoLogin
    @Usuario VARCHAR(50),
    @Password VARCHAR(50)
AS
BEGIN
    SELECT * FROM Empleado WHERE Usuario = @Usuario AND [Password] = @Password
END;



-- insertar un cliente
CREATE OR ALTER PROCEDURE sp_InsertarCliente
    @DNI VARCHAR(50),
    @Nombre VARCHAR(50),
    @Genero VARCHAR(50),
    @Estado VARCHAR(100),
    @Fecha_nacimiento DATETIME
AS
BEGIN
    INSERT INTO Cliente (DNI, Nombre, Genero, Estado, Fecha_nacimiento)
    VALUES (@DNI, @Nombre, @Genero, @Estado, @Fecha_nacimiento)
END;