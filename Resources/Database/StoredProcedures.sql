-- NOTE: RUN ALL PROCEDURES SEPARATELY!




-- Admin CRUD Operations

CREATE PROCEDURE [dbo].[spCheckAdminExists] 
	-- Add the parameters for the stored procedure here
	@adminId INT, 
	@adminPassword VARCHAR(MAX)
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @AdminName VARCHAR(50);
	DECLARE @AdminStoreId INT;

	-- Check if admin exists in the table of admin
	IF EXISTS (SELECT 1 FROM [Inventory_Management_System].[dbo].[admin] WHERE id = @adminId AND password = @adminPassword)
	BEGIN
		-- Save name and store's id of admin
		SELECT @AdminName = name, @AdminStoreId = store_id FROM [Inventory_Management_System].[dbo].[admin] WHERE id = @adminId;
		SELECT @AdminName AS AdminName, @AdminStoreId AS StoreID;
	END
	-- If admin does not exists, return null
	ELSE
		SELECT NULL AS AdminName, NULL AS StoreID;
END
GO

CREATE PROCEDURE [dbo].[spUpdateAdminPassword] 
	@adminId INT,
	@oldPassword VARCHAR(MAX),
	@newPassword VARCHAR(MAX)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE admin SET password = @newPassword WHERE id = @adminId AND password = @oldPassword;
END
GO





-- Employee CRUD Operations

CREATE PROCEDURE [dbo].[spViewAllEmployees] 
	@store_id INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT id AS ID, name AS Name, contact AS Contact, position AS Position, salary AS Salary FROM employee WHERE store_id = @store_id;
END
GO

CREATE PROCEDURE [dbo].[spViewEmployeesById] 
	@id INT,
	@store_id INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT id AS ID, name AS Name, contact AS Contact, position AS Position, salary AS Salary FROM employee WHERE id = @id AND store_id = @store_id;
END
GO

CREATE PROCEDURE [dbo].[spViewEmployeesByName] 
	@name VARCHAR(50),
	@store_id INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT id AS ID, name AS Name, contact AS Contact, position AS Position, salary AS Salary FROM employee WHERE store_id = @store_id AND name LIKE '%' +@name+ '%'
END
GO

CREATE PROCEDURE [dbo].[spViewEmployeesAsc] 
	@name VARCHAR(50),
	@store_id INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT id AS ID, name AS Name, contact AS Contact, position AS Position, salary AS Salary FROM employee WHERE store_id = @store_id ORDER BY name ASC
END
GO

CREATE PROCEDURE [dbo].[spViewEmployeesDesc] 
	@name VARCHAR(50),
	@store_id INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT id AS ID, name AS Name, contact AS Contact, position AS Position, salary AS Salary FROM employee WHERE store_id = @store_id ORDER BY name DESC
END
GO

CREATE PROCEDURE [dbo].[spViewEmployeesByPosition] 
	@position VARCHAR(50),
	@store_id INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT id AS ID, name AS Name, contact AS Contact, position AS Position, salary AS Salary FROM employee WHERE position = @position AND store_id = @store_id
END
GO

CREATE PROCEDURE [dbo].[spInsertEmployee] 
	@name VARCHAR(50),
	@contact VARCHAR(50),
	@position VARCHAR(50),
	@salary FLOAT,
	@store_id INT
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO employee VALUES(@name, @contact, @position, @salary, @store_id);
END
GO

CREATE PROCEDURE [dbo].[spUpdateEmployee] 
    @id INT,
    @name VARCHAR(50),
	@contact VARCHAR(50),
	@position VARCHAR(50),
	@salary FLOAT,
	@store_id INT
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE employee SET name = @name, contact = @contact, position = @position, salary = @salary WHERE id = @id AND store_id = @store_id;
END
GO

CREATE PROCEDURE [dbo].[spDeleteEmployee] 	
	@id INT,
	@store_id INT
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM employee WHERE id = @id AND store_id = @store_id;
END
GO





-- Customer CRUD Operations

CREATE PROCEDURE [dbo].[spViewAllCustomers] 
	@store_id INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT id AS ID, name AS Name, contact AS Contact FROM customer WHERE store_id = @store_id;
END
GO

CREATE PROCEDURE [dbo].[spViewCustomersById] 
	@id INT,
	@store_id INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT id AS ID, name AS Name, contact AS Contact FROM customer WHERE id = @id AND store_id = @store_id;
END
GO

CREATE PROCEDURE [dbo].[spViewCustomersByName] 
	@name VARCHAR(50),
	@store_id INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT id AS ID, name AS Name, contact AS Contact FROM customer WHERE store_id = @store_id AND name LIKE '%' +@name+ '%'
END
GO

CREATE PROCEDURE [dbo].[spViewCustomersAsc] 
	@name VARCHAR(50),
	@store_id INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT id AS ID, name AS Name, contact AS Contact FROM customer WHERE store_id = @store_id ORDER BY name ASC
END
GO

CREATE PROCEDURE [dbo].[spViewCustomersDesc] 
	@name VARCHAR(50),
	@store_id INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT id AS ID, name AS Name, contact AS Contact FROM customer WHERE store_id = @store_id ORDER BY name DESC
END












--procedures for product class

CREATE PROCEDURE [dbo].[spViewProducts] 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT * FROM inventory;
END

CREATE PROCEDURE [dbo].[spSearchProductByName] 
	-- Add the parameters for the stored procedure here
	@name VARCHAR(50),
	@store_id INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM inventory WHERE store_id = @store_id AND name LIKE '%' +@name+ '%'
END
GO













-- Inventory CRUD Operations

CREATE PROCEDURE [dbo].[spViewAllInventory] 
	@store_id INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT id AS ID, name AS Name, quantity AS Quantity, price AS Price, category AS Category FROM inventory WHERE store_id = @store_id;
END
GO

CREATE PROCEDURE [dbo].[spViewInventoryById] 
	@id INT,
	@store_id INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT id AS ID, name AS Name, quantity AS Quantity, price AS Price, category AS Category FROM inventory WHERE id = @id AND store_id = @store_id;
END
GO

CREATE PROCEDURE [dbo].[spViewInventoryByName] 
	@name VARCHAR(50),
	@store_id INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT id AS ID, name AS Name, quantity AS Quantity, price AS Price, category AS Category FROM customer WHERE store_id = @store_id AND name LIKE '%' +@name+ '%';
END
GO

CREATE PROCEDURE [dbo].[spViewInventoryByCategory] 
	@category VARCHAR(50),
	@store_id INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT id AS ID, name AS Name, quantity AS Quantity, price AS Price, category AS Category FROM customer WHERE store_id = @store_id AND category = @category;
END
GO

CREATE PROCEDURE [dbo].[spViewInventoryByPriceAsc] 
	@store_id INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT id AS ID, name AS Name, quantity AS Quantity, price AS Price, category AS Category FROM inventory WHERE store_id = @store_id ORDER BY price ASC;
END
GO

CREATE PROCEDURE [dbo].[spViewInventoryByPriceDesc] 
	@store_id INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT id AS ID, name AS Name, quantity AS Quantity, price AS Price, category AS Category FROM inventory WHERE store_id = @store_id ORDER BY price DESC;
END
GO

CREATE PROCEDURE [dbo].[spViewInventoryAsc] 
	@store_id INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT id AS ID, name AS Name, quantity AS Quantity, price AS Price, category AS Category FROM inventory WHERE store_id = @store_id ORDER BY name ASC;
END
GO

CREATE PROCEDURE [dbo].[spViewInventoryDesc] 
	@store_id INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT id AS ID, name AS Name, quantity AS Quantity, price AS Price, category AS Category FROM inventory WHERE store_id = @store_id ORDER BY name DESC;
END
GO

CREATE PROCEDURE [dbo].[spInsertInventory] 
	@name VARCHAR(50),
	@quantity INT,
	@price FLOAT,
	@category VARCHAR(50),
	@store_id INT
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO inventory VALUES(@name, @quantity, @price, @category, @store_id);
END
GO

CREATE PROCEDURE [dbo].[spUpdateInventory] 
	@id INT,
	@name VARCHAR(50),
	@quantity INT,
	@price FLOAT,
	@category VARCHAR(50),
	@store_id INT
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE inventory SET name = @name, quantity = @quantity, price = @price, category = @category WHERE id = @id AND store_id = @store_id;
END
GO

CREATE PROCEDURE [dbo].[spDeleteInventory] 	
	@id INT,
	@store_id INT
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM inventory WHERE id = @id AND store_id = @store_id;
END
GO











-- Order History

CREATE PROCEDURE [dbo].[spViewOrderHistory] 
	@store_id INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT order_id AS [Order ID #], total_products AS [Total Products], amount AS [Total Amount], date AS Dated, customer_id AS [Customer's ID] FROM orders WHERE store_id = @store_id
END
GO

CREATE PROCEDURE [dbo].[spViewOrderHistoryById] 
	@id INT,
	@store_id INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT order_id AS [Order ID #], total_products AS [Total Products], amount AS [Total Amount], date AS Dated, customer_id AS [Customer's ID] FROM orders WHERE id = @id AND store_id = @store_id
END
GO












