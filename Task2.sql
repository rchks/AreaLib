CREATE TABLE Product(
	Id smallint NOT NULL PRIMARY KEY,
	Name nvarchar(128) NOT NULL
);

CREATE TABLE Category(
	Id smallint NOT NULL PRIMARY KEY,
	Name nvarchar(256) NULL
);

CREATE TABLE ProductCategory(
	Id bigint NOT NULL PRIMARY KEY,
	ProductId smallint NOT NULL,
	CategoryId smallint NOT NULL
);

SELECT p.Name as ProductName, c.Name as CategoryName 
FROM Product p
LEFT JOIN ProductCategory pc ON pc.ProductId = p.Id
LEFT JOIN Category c ON pc.CategoryId = c.Id
ORDER BY p.Name, c.Name
