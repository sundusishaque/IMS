--NOTE: RUN ALL PROCEDURES SEPARATELY!

--procedures for product class (are available in db)

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
	@name AS varchar(50),
	@store_id AS int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM inventory WHERE store_id = @store_id AND name LIKE '%' +@name+ '%'
END
GO

CREATE PROCEDURE [dbo].[spSearchProductById] 
	@id AS int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM inventory WHERE id = @id;
END
GO

CREATE PROCEDURE [dbo].[spInsertProduct] 
	@name AS varchar(50),
	@quantity AS int,
	@price AS float,
	@category AS varchar(50),
	@store_id AS int
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO inventory VALUES(@name, @quantity, @price, @category, @store_id);
END
GO

CREATE PROCEDURE [dbo].[spUpdateProduct] 
    @id AS int,
    @name AS varchar(50),
	@quantity AS int,
	@price AS float,
	@category AS varchar(50),
	@store_id AS int
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE inventory SET name = @name, quantity = @quantity, price = @price, category = @category, 
	store_id = @store_id where id = @id;
END
GO

CREATE PROCEDURE [dbo].[spDeleteProduct] 	
	@id AS int
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM inventory WHERE id = @id;
END
GO

--procedures for employee class (have not been run)

CREATE PROCEDURE [dbo].[spViewEmployee] 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT * FROM employee;
END

CREATE PROCEDURE [dbo].[spSearchEmployeeByName] 
	-- Add the parameters for the stored procedure here
	@name AS varchar(50),
	@store_id AS int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM employee WHERE store_id = @store_id AND name LIKE '%' +@name+ '%'
END
GO

CREATE PROCEDURE [dbo].[spSearchProductById] --??? tha dbms mein???
	@id AS int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM inventory WHERE id = @id;
END
GO

CREATE PROCEDURE [dbo].[spInsertEmployee] 
	@name AS varchar(50),
	@contact AS varchar(50),
	@position AS varchar(50),
	@salary AS float,
	@store_id AS int
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO employee VALUES(@name, @contact, @position, @salary, @store_id);
END
GO

CREATE PROCEDURE [dbo].[spUpdateEmployee] 
    @id AS int,
    @name AS varchar(50),
	@contact AS varchar(50),
	@position AS varchar(50),
	@salary AS float,
	@store_id AS int
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE employee SET name = @name, contact = @contact, position = @position, salary = @salary, 
	store_id = @store_id where id = @id;
END
GO

CREATE PROCEDURE [dbo].[spDeleteEmployee] 	
	@id AS int
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM employee WHERE id = @id;
END
GO
