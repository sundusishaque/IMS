-- runs only once to populate the entire 'inventory' database
-- includes DML(insertion)

-- populating the database
INSERT INTO Inventory_Management_System.dbo.store 
	VALUES('General Store','Gulshan','02121212121'),('General Store','Nazimabad','031313131');

INSERT INTO Inventory_Management_System.dbo.admin VALUES(65215,'Sundus Ishaque','12345',1),(65098,'Areeba Ahmed','asd123',1);

INSERT INTO Inventory_Management_System.dbo.employee VALUES('Shakeel','021212121','Clerk', 12500, 1),
	('Anas','07878787','Manager', 78000, 1),('Fazal','187518752','Clerk', 56050, 1),
	('Jawaad','Clerk','Manager', 91020, 1),('Asad','108712018','Clerk', 15000, 1),
	('Yousra','021212121','Clerk', 12500, 1),('Zareen','07878787','Manager', 78000, 1),
	('Haroon','187518752','Clerk', 56050, 1),('Owais','Clerk','Manager', 91020, 1),('Shasita','108712018','Clerk', 15000, 1),
	
	('Shakeel','021212121','Clerk', 12500, 2),('Anas','07878787','Manager', 78000, 2),
	('Fazal','187518752','Clerk', 56050, 2),('Jawaad','Clerk','Manager', 91020, 2),('Asad','108712018','Clerk', 15000, 2),
	('Yousra','021212121','Clerk', 12500, 2),('Zareen','07878787','Manager', 78000, 2),
	('Haroon','187518752','Clerk', 56050, 2),('Owais','Clerk','Manager', 91020, 2),('Shasita','108712018','Clerk', 15000, 2);

INSERT INTO Inventory_Management_System.dbo.customer VALUES('Abdur Rahim','021021021','12345',1),('Hamza','189520015','123',1),
	('Imran','78451248687','abc',1),('Abdullah','01381920','sd',1),('Anusha','78787878','212',1),('Zayan','021021021','12345',1),
	('Saad','189520015','123',1),('Areej','78451248687','abc',1),('Sara','01381920','sd',1),('Osama','78787878','212',1),

	('Abdur Rahim','021021021','12345',2),('Hamza','189520015','123',2),
	('Imran','78451248687','abc',2),('Abdullah','01381920','sd',2),('Anusha','78787878','212',2),
	('Zayan','021021021','12345',2),('Saad','189520015','123',2),
	('Areej','78451248687','abc',2),('Sara','01381920','sd',2),('Osama','78787878','212',2);

INSERT INTO Inventory_Management_System.dbo.inventory VALUES
	-- FOR STORE 1
	('HAIER 1 Ton Inverter AC',5,90999,'Home Appliances', 1), ('HAIER 1.5 Ton Inverter AC',5,125000,'Home Appliances', 1),
	('FIRMAN Gasoline Generator',8,45000,'Home Appliances', 1), ('KENWOOD eLuxury AC',10,134699,'Home Appliances', 1),
	('HAIER Glass Door Refrigerator',8,66505,'Home Appliances', 1), ('HAIER 2 Ton Inverter AC',10,145000,'Home Appliances', 1),
	('Orient Water Dispenser',3,29999,'Home Appliances', 1), ('HAIER Side by Side Inverter Refrigerator',8,204348,'Home Appliances', 1),
	('Voltronic Power Inverter/UPS',5,37500,'Home Appliances', 1), ('Philip Iron',15,2500,'Home Appliances', 1),
	('Vacuum Cleaner',10,8900,'Home Appliances', 1), ('AC remote',18,1000,'Home Appliances', 1),
	('HAIER Refrigerator',18,70305,'Home Appliances', 1), ('Homage Water Dispenser',10,27000,'Home Appliances', 1),
	('Kenwood Washing Machine',4,58000,'Home Appliances', 1), ('Orient AC',5,89000,'Home Appliances', 1),

	('Philips Air Fryer',10,19000,'Kitchen Appliances', 1), ('Dawlance Rice Cooker',5,25000,'Kitchen Appliances', 1),
	('Westpoint Deluxe Induction Cooker',8,28000,'Kitchen Appliances', 1), ('Food Steamer',10,12600,'Kitchen Appliances', 1),
	('Deluxe Juicer',8,6999,'Kitchen Appliances', 1), ('Nikai Blender',10,8300,'Kitchen Appliances', 1),
	('Sayona Coffee Maker',3,8000,'Kitchen Appliances', 1), ('Stanford Ice Cream Maker',8,17999,'Kitchen Appliances', 1),
	('Sencor Electric Kettle',5,9000,'Kitchen Appliances', 1), ('Dawlance Oven',15,14999,'Kitchen Appliances', 1),
	('Westpoint Food Processor',10,15500,'Kitchen Appliances', 1), ('Sencor Food Chopper',18,10000,'Kitchen Appliances', 1),
	('Stanford Breakfast Maker',18,16900,'Kitchen Appliances', 1), ('Anex Toaster',10,6000,'Kitchen Appliances', 1),
	('Sanford Pizza Maker',4,18500,'Kitchen Appliances', 1),

	('Mobile Phone Charger',5,500,'Mobile Accessories', 1), ('Power Bank',5,7999,'Mobile Accessories', 1),
	('Data Cable',8,700,'Mobile Accessories', 1), ('Dashboard Wireless Charger',10,7000,'Mobile Accessories', 1),
	('Lenovo Ear Buds',8,5000,'Mobile Accessories', 1), ('Joyroom Wireless Budsr',10,4200,'Mobile Accessories', 1),
	('Itel Handsfree',3,3999,'Mobile Accessories', 1), ('Dual Port Wall Charger',8,1000,'Mobile Accessories', 1),
	('Joyroom Handsfree',5,500,'Mobile Accessories', 1), ('Phone Holder',15,2999,'Mobile Accessories', 1),
	('USB Cable',10,2070,'Mobile Accessories', 1), ('Stylus Pen',18,5500,'Mobile Accessories', 1),
	('MI Redmi Cover',18,1150,'Mobile Accessories', 1), ('iPhone 13 Protective Cover',10,1800,'Mobile Accessories', 1),

	-- FOR STORE 2
	('HAIER 1 Ton Inverter AC',5,90999,'Home Appliances', 2), ('HAIER 1.5 Ton Inverter AC',5,125000,'Home Appliances', 2),
	('FIRMAN Gasoline Generator',8,45000,'Home Appliances', 2), ('KENWOOD eLuxury AC',10,134699,'Home Appliances', 2),
	('HAIER Glass Door Refrigerator',8,66505,'Home Appliances', 2), ('HAIER 2 Ton Inverter AC',10,145000,'Home Appliances', 2),
	('Orient Water Dispenser',3,29999,'Home Appliances', 2), ('HAIER Side by Side Inverter Refrigerator',8,204348,'Home Appliances', 2),
	('Voltronic Power Inverter/UPS',5,37500,'Home Appliances', 2), ('Philip Iron',15,2500,'Home Appliances', 2),
	('Vacuum Cleaner',10,8900,'Home Appliances', 2), ('AC remote',18,1000,'Home Appliances', 2),
	('HAIER Refrigerator',18,70305,'Home Appliances', 2), ('Homage Water Dispenser',10,27000,'Home Appliances', 2),
	('Kenwood Washing Machine',4,58000,'Home Appliances', 2), ('Orient AC',5,89000,'Home Appliances', 2),

	('Philips Air Fryer',10,19000,'Kitchen Appliances', 2), ('Dawlance Rice Cooker',5,25000,'Kitchen Appliances', 2),
	('Westpoint Deluxe Induction Cooker',8,28000,'Kitchen Appliances', 2), ('Food Steamer',10,12600,'Kitchen Appliances', 2),
	('Deluxe Juicer',8,6999,'Kitchen Appliances', 2), ('Nikai Blender',10,8300,'Kitchen Appliances', 2),
	('Sayona Coffee Maker',3,8000,'Kitchen Appliances', 2), ('Stanford Ice Cream Maker',8,17999,'Kitchen Appliances',2),
	('Sencor Electric Kettle',5,9000,'Kitchen Appliances', 2), ('Dawlance Oven',15,14999,'Kitchen Appliances', 2),
	('Westpoint Food Processor',10,15500,'Kitchen Appliances', 2), ('Sencor Food Chopper',18,10000,'Kitchen Appliances', 2),
	('Stanford Breakfast Maker',18,16900,'Kitchen Appliances', 2), ('Anex Toaster',10,6000,'Kitchen Appliances', 2),
	('Sanford Pizza Maker',4,18500,'Kitchen Appliances', 2),

	('Mobile Phone Charger',5,500,'Mobile Accessories', 2), ('Power Bank',5,7999,'Mobile Accessories', 2),
	('Data Cable',8,700,'Mobile Accessories', 2), ('Dashboard Wireless Charger',10,7000,'Mobile Accessories', 2),
	('Lenovo Ear Buds',8,5000,'Mobile Accessories', 2), ('Joyroom Wireless Budsr',10,4200,'Mobile Accessories', 2),
	('Itel Handsfree',3,3999,'Mobile Accessories', 2), ('Dual Port Wall Charger',8,1000,'Mobile Accessories', 2),
	('Joyroom Handsfree',5,500,'Mobile Accessories', 2), ('Phone Holder',15,2999,'Mobile Accessories', 2),
	('USB Cable',10,2070,'Mobile Accessories', 2), ('Stylus Pen',18,5500,'Mobile Accessories', 2),
	('MI Redmi Cover',18,1150,'Mobile Accessories', 2), ('iPhone 13 Protective Cover',10,1800,'Mobile Accessories', 2);
