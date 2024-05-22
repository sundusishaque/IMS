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
	SELECT id AS ID, name AS Name, quantity AS Quantity, price AS Price, category AS Category FROM inventory WHERE store_id = @store_id AND name LIKE '%' +@name+ '%';
END
GO

CREATE PROCEDURE [dbo].[spViewInventoryByCategory] 
	@category VARCHAR(50),
	@store_id INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT id AS ID, name AS Name, quantity AS Quantity, price AS Price, category AS Category FROM inventory WHERE store_id = @store_id AND category = @category;
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




CREATE PROCEDURE [dbo].[spCheckCustomerExists] 
	-- Add the parameters for the stored procedure here
	@CustomerId INT, 
	@CustomerPassword VARCHAR(MAX)
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @CustomerName VARCHAR(50);
	DECLARE @CustomerStoreId INT;

	-- Check if customer exists in the table of customer
	IF EXISTS (SELECT 1 FROM [Inventory_Management_System].[dbo].[customer] WHERE id = @CustomerId AND password = @CustomerPassword)
	BEGIN
		-- Save name and store's id of admin
		SELECT @CustomerName = name,@CustomerStoreId = store_id FROM [Inventory_Management_System].[dbo].[customer] WHERE id = @CustomerId;
		SELECT @CustomerName AS CustomerName, @CustomerStoreId AS StoreID;
	END
	-- If customer does not exists, return null
	ELSE
		SELECT NULL AS CustomerName, NULL AS StoreID;
END
GO

CREATE PROCEDURE [dbo].[spUpdateCustomerPassword] 
	@CustomerId INT,
	@oldPassword VARCHAR(MAX),
	@newPassword VARCHAR(MAX)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE customer SET password = @newPassword WHERE id =@CustomerId AND password = @oldPassword;
END
GO



CREATE PROCEDURE [dbo].[spViewOrderDetailsById] 
	@id INT,
	@store_id INT,
	@order_id INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT order_id AS [Order ID #], product_id AS [Product's ID], name AS Name, quantity AS Quantity, price AS Price FROM order_details WHERE order_id=@order_id  AND store_id = @store_id AND customer_id =@id;
END
GO


CREATE PROCEDURE [dbo].[spAddCustomer] 
    @Name NVARCHAR(50),
    @Contact NVARCHAR(50),
    @Password NVARCHAR(MAX),
    @StoreId INT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO customer (name, contact, password, store_id)
    VALUES (@Name, @Contact, @Password, @StoreId);
END

CREATE PROCEDURE [dbo].[spGetCustomerIdByNameContactPassword] 
    @Name NVARCHAR(50),
    @Contact NVARCHAR(50),
    @Password NVARCHAR(MAX)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT id
    FROM customer
    WHERE name = @Name AND contact = @Contact AND password = @Password;
END



CREATE PROCEDURE [dbo]. [spDeleteCustomer]
    @CustomerId INT,
    @Password NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Check if the provided password matches the customer's password
    IF EXISTS (SELECT 1 FROM customer WHERE id = @CustomerId AND password = @Password)
    BEGIN
        -- Delete the customer
        DELETE FROM customer WHERE id = @CustomerId;
        SELECT 'Success' AS Status;
    END
    ELSE
    BEGIN
        -- If the password doesn't match, return an error message
        SELECT 'Error: Incorrect password' AS Status;
    END
END











CREATE PROCEDURE [dbo].[spAddToCart] 
    @ProductId INT,
    @ProductName NVARCHAR(100),
    @ProductQty INT,
    @Price DECIMAL(18, 2),
    @OrderId INT,
    @CustomerId INT,
    @StoreId INT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO order_details (product_id, name, quantity, price, order_id, customer_id, store_id)
    VALUES (@ProductId, @ProductName, @ProductQty, @Price, @OrderId, @CustomerId, @StoreId);
END


CREATE PROCEDURE [dbo].[spCheckOrderIdExists]
    @OrderId INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT COUNT(*) AS OrderCount
    FROM order_details
    WHERE order_id = @OrderId;
END

CREATE PROCEDURE [dbo].[spGetProductDetails] 
    @ProductId INT,
    @StoreId INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT name, price
    FROM inventory
    WHERE store_id = @StoreId AND id = @ProductId;
END




CREATE PROCEDURE [dbo]. [spGetTotalQuantity]
    @OrderId INT,
    @CustomerId INT
AS
BEGIN
    SELECT SUM(quantity)
    FROM order_details
    WHERE order_id = @OrderId AND customer_id = @CustomerId;
END
GO

-- Stored procedure to get total price
CREATE PROCEDURE [dbo].[ spGetTotalPrice]
    @OrderId INT,
    @CustomerId INT
AS
BEGIN
    SELECT SUM(price)
    FROM order_details
    WHERE order_id = @OrderId AND customer_id = @CustomerId;
END
GO

-- Stored procedure to insert an order
CREATE PROCEDURE [dbo].[spInsertOrder]
    @OrderId INT,
    @TotalProducts INT,
    @Amount FLOAT,
    @CustomerId INT,
    @StoreId INT
AS
BEGIN
    INSERT INTO orders(order_id, total_products, amount, customer_id, store_id)
    VALUES(@OrderId, @TotalProducts, @Amount, @CustomerId, @StoreId);
END
GO



CREATE PROCEDURE [dbo]. [spViewCart]
    @OrderId INT,
    @StoreId INT,
    @CustomerId INT
AS
BEGIN
    SELECT product_id AS [Product's ID], 
           name AS Name, 
           quantity AS Quantity, 
           price AS Price 
    FROM order_details 
    WHERE order_id = @OrderId 
        AND store_id = @StoreId 
        AND customer_id = @CustomerId;
END
GO







