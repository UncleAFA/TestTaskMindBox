CREATE TABLE Category(
	Id INT PRIMARY KEY,
	Name nvarchar(256) NOT NULL
);
CREATE TABLE Product(
	Id INT PRIMARY KEY,
	Name nvarchar(128) NOT NULL,
	CategoryId INT FOREIGN KEY REFERENCES Category(Id) 
);

SELECT * 
FROM [TestDB].[dbo].[Product] 
LEFT Join [TestDB].[dbo].[Category] ON [TestDB].[dbo].[Product].[CategoryId] = [TestDB].[dbo].[Category].[Id]
