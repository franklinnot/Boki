


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