


Store procedures que se estaran utilizando:

-- Listar todos los empleados
CREATE OR ALTER PROCEDURE sp_ListarEmpleados
AS
BEGIN
    SELECT * FROM Empleado
END

-- Buscar un empleado por id
CREATE OR ALTER PROCEDURE sp_BuscarClientePorId
    @Id_cliente INT
AS
BEGIN
    SELECT * FROM Cliente WHERE Id_cliente = @Id_cliente
END



-- Listar todos los clientes
CREATE OR ALTER PROCEDURE sp_ListarClientes
AS
BEGIN
    SELECT * FROM Cliente
END

