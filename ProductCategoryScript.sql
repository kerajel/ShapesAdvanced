CREATE TABLE Product (
	ID INT IDENTITY(1,1) PRIMARY KEY,
	"Name" TEXT
);

INSERT INTO Product
VALUES
	('Steam boiler'),
	('Brass boiler'),
    ('Reinforced pipe'),
	('Brass pipe'),
    ('Tie 057');

CREATE TABLE Category (
	ID INT IDENTITY(1,1) PRIMARY KEY,
	"Name" TEXT
);

INSERT INTO Category
VALUES
	('Category for boilers'),
	('Category for pipes'),
    ('Category for brass items');

CREATE TABLE ProductCategory (
	ProductID INT FOREIGN KEY REFERENCES Product(ID),
	CategoryID INT FOREIGN KEY REFERENCES Category(ID),
	PRIMARY KEY (ProductID, CategoryID)
);

INSERT INTO ProductCategory
VALUES
	(1, 1),
	(2, 1),
	(3, 2),
    (4, 2),
    (2, 3),
    (4, 3);

SELECT p.Name AS 'ProductName', c.Name AS 'CategoryName' 
FROM Product p
LEFT JOIN ProductCategory pc
	ON p.ID = pc.ProductID
LEFT JOIN Category c
	ON pc.CategoryID = c.ID
ORDER BY p.ID;