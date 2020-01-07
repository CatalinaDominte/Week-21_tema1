	CREATE DATABASE STORE
	USE [STORE]
	GO

	CREATE TABLE [StoreLocation]
	(
	[StoreId] INT NOT NULL PRIMARY KEY IDENTITY (1,1),
	[StoreName] varchar(50) NOT NULL,
	[StoreAddress] varchar(100) NOT NULL,
	)
	CREATE TABLE [Suppliers]
	(
	[SuppliersId] INT NOT NULL PRIMARY KEY IDENTITY (1,1),
	[SuppliersName] varchar(50) NOT NULL,
	[SuppliersAddress] varchar(100) NULL,
	[SuppliersContactInformations] varchar(100) NOT NULL,
	)
	CREATE TABLE [Category]
	(
	[CategoryId] INT NOT NULL PRIMARY KEY IDENTITY (1,1),
	[CategoryName] varchar(50) NOT NULL,
	[CategoryDescription] varchar(200) NULL,
	)
	CREATE TABLE [Products]
	(
	[ProductsId] INT NOT NULL PRIMARY KEY IDENTITY (1,1),
	[ProductsName] varchar(50) NOT NULL,
	[Suppliers] INT NOT NULL,
	[Category]INT NOT NULL,
	[StoreLocation] INT NOT NULL,
	[ProductsDescription] varchar(50) NULL,
	[UnitsInStock] INT NOT NULL,
	[UnitPrice] smallmoney NOT NULL,
	[Discount] smallmoney NULL,--de modificat in not null
	[FinalPrice] smallmoney NOT NULL,
	[AvaibleSize]varchar(50) NOT NULL,
	[AvaibleColours]varchar(100) NOT NULL,
	[EntryDate] DATE NOT NULL,
	[Picture] IMAGE NULL,
)
CREATE INDEX [ProductsIndex]
	ON [Products]([ProductsId]);

	CREATE TABLE [ArchiveProducts]
	(
	[ProductsId] INT NOT NULL PRIMARY KEY IDENTITY (1,1),
	[ProductsName] varchar(50) NOT NULL,
	[Suppliers] INT NOT NULL,
	[Category]INT NOT NULL,
	[StoreLocation] INT NOT NULL,
	[ProductsDescription] varchar(50) NULL,
	[UnitsInStock] INT NOT NULL,
	[UnitPrice] smallmoney NOT NULL,
	[Discount] smallmoney NULL,
	[FinalPrice] smallmoney NOT NULL,
	[AvaibleSize]varchar(50) NOT NULL,
	[AvaibleColours]varchar(100) NOT NULL,
	[EntryDate] DATE NOT NULL,
	[Picture] IMAGE NULL,
)

	CREATE TABLE [UnitsPerSize]
	(
	[UnitsPerSizeId] INT NOT NULL PRIMARY KEY,
	[ProductsId] INT NOT NULL,
	[UnitsPerSizeInStock] INT NOT NULL,
	[Size] INT NOT NULL,
	[Colour] varchar(50) NOT NULL,
	)
CREATE TABLE [Inventory]
(
	[InventoryId] INT NOT NULL PRIMARY KEY IDENTITY (1,1),
	[ProductsId] INT NOT NULL,
	[UnitsPerSizeId] INT NOT NULL,
	[ProductsName] varchar(50) NOT NULL,
	[Suppliers] INT NOT NULL,
	[Category]INT NOT NULL,
	[StoreLocation] INT NOT NULL,
	[UnitsSold] INT NOT NULL,
	[SoldDate] DATE NOT NULL,
	[UnitPrice] smallmoney NOT NULL,
	[Discount] smallmoney NULL,
	[FinalPrice] smallmoney NOT NULL,
	[Size] INT NOT NULL,
	[Colour] varchar(50) NOT NULL,
	
)
ALTER TABLE [Products]
ADD FOREIGN KEY ([Category]) REFERENCES [Category]([CategoryId]);
ALTER TABLE [Products]
ADD FOREIGN KEY ([Suppliers]) REFERENCES [Suppliers]([SuppliersId]);
ALTER TABLE [Products]
ADD FOREIGN KEY ([StoreLocation]) REFERENCES [StoreLocation]([StoreId]);

ALTER TABLE [ArchiveProducts]
ADD FOREIGN KEY ([Category]) REFERENCES [Category]([CategoryId]);
ALTER TABLE [ArchiveProducts]
ADD FOREIGN KEY ([Suppliers]) REFERENCES [Suppliers]([SuppliersId]);
ALTER TABLE [ArchiveProducts]
ADD FOREIGN KEY ([StoreLocation]) REFERENCES [StoreLocation]([StoreId]);

ALTER TABLE [Inventory]
ADD FOREIGN KEY ([ProductsId]) REFERENCES [Products]([ProductsId]);
ALTER TABLE [Inventory]
ADD FOREIGN KEY ([UnitsPerSizeId]) REFERENCES [UnitsPerSize]([UnitsPerSizeId]);
ALTER TABLE [Inventory]
ADD FOREIGN KEY ([Category]) REFERENCES [Category]([CategoryId]);
ALTER TABLE [Inventory]
ADD FOREIGN KEY ([Suppliers]) REFERENCES [Suppliers]([SuppliersId]);
ALTER TABLE [Inventory]
ADD FOREIGN KEY ([StoreLocation]) REFERENCES [StoreLocation]([StoreId]);

ALTER TABLE [UnitsPerSize]
ADD FOREIGN KEY ([ProductsId]) REFERENCES [Products]([ProductsId]);

INSERT INTO [Category] ([CategoryName],[CategoryDescription])
VALUES
 ('Pantofi','Produs destinat oricarui anotimp'),
 ('Sandale','Produs pentru vara');
 select * from[Category]
	
	
	
	--Ex de decrement
	--UPDATE table 
--SET field = field - 1
--WHERE id = $number
--and field > 0

--# or
--UPDATE  table
--SET     field = IF(field > 0, field - 1, 0)
--WHERE   id = $number





	
