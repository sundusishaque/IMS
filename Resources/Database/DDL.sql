-- runs only once to create the entire 'inventory' database
-- includes DDL
-- Foreign Keys' relation are shown as FK_FKtable_Pktable

-- creating the databse
CREATE DATABASE IMS;

CREATE TABLE [IMS].[dbo].[store] (id int IDENTITY(1,1), name varchar(50), 
	location varchar(50), contact varchar(50) NOT NULL,  
	CONSTRAINT PK_store PRIMARY KEY(id));

CREATE TABLE [IMS].[dbo].[admin] (id int, name varchar(50), password varchar(50) NOT NULL, store_id int NOT NULL, 
	CONSTRAINT PK_admin PRIMARY KEY(id), 
	CONSTRAINT FK_admin_store FOREIGN KEY(store_id) REFERENCES store(id)); 

CREATE TABLE [IMS].[dbo].[employee] (id int IDENTITY(1,1), name varchar(50), contact varchar(50) NOT NULL, 
	position varchar(50), salary float, store_id int NOT NULL, 
	CONSTRAINT PK_employee PRIMARY KEY(id), 
	CONSTRAINT FK_employee_store FOREIGN KEY(store_id) REFERENCES store(id)); 

CREATE TABLE [IMS].[dbo].[customer] (id int IDENTITY(1,1), name varchar(50), contact varchar(50) NOT NULL, 
	password varchar(50) NOT NULL, store_id int NOT NULL, 
	CONSTRAINT PK_customer PRIMARY KEY(id), 
	CONSTRAINT FK_customer_store FOREIGN KEY(store_id) REFERENCES store(id));  

CREATE TABLE [IMS].[dbo].[inventory] (id int IDENTITY(1,1), name varchar(50), quantity int NOT NULL, 
	price float NOT NULL, category varchar(50) NOT NULL, store_id int NOT NULL, 
	CONSTRAINT PK_product PRIMARY KEY(id), 
	CONSTRAINT FK_product_store FOREIGN KEY(store_id) REFERENCES store(id));

CREATE TABLE [IMS].[dbo].[order_details] (id int IDENTITY(1,1), product_id int NOT NULL, name VARCHAR(50), 
	quantity int NOT NULL, price float NOT NULL, order_id int NOT NULL,
	customer_id int NOT NULL, store_id int NOT NULL,
	CONSTRAINT PK_orderDetails PRIMARY KEY(id),
	CONSTRAINT FK_orderDetails_inventory FOREIGN KEY(product_id) REFERENCES inventory(id) ON DELETE CASCADE,
	CONSTRAINT FK_orderDetails_customer FOREIGN KEY(customer_id) REFERENCES customer(id) ON DELETE CASCADE,
	CONSTRAINT FK_orderDetails_store FOREIGN KEY (store_id) REFERENCES store(id));

CREATE TABLE [IMS].[dbo].[orders] (id int IDENTITY(1,1), order_id int NOT NULL,
	total_products int NOT NULL, amount float NOT NULL, date datetime DEFAULT(getdate()),
	customer_id int NOT NULL, store_id int NOT NULL, 
	CONSTRAINT PK_orders PRIMARY KEY(id),
	CONSTRAINT FK_orders_customer FOREIGN KEY(customer_id) REFERENCES customer(id) ON DELETE CASCADE,
	CONSTRAINT FK_orders_store FOREIGN KEY (store_id) REFERENCES store(id));
