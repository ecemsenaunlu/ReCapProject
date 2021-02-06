Create table Cars(
CarID int primary key identity(1,1),
BrandID int,
ColorID int,
ModelYear int,
DailyPrice decimal,
Descriptions nvarchar(50),
FOREIGN KEY (BrandID) references Brands(BrandID),
FOREIGN KEY (ColorID) references Colors(ColorID),
)
Create Table Colors(
ColorID int PRIMARY KEY IDENTITY (1,1),
ColorName nvarchar(50),
)
Create Table Brands(
BrandID int PRIMARY KEY IDENTITY (1,1),
BrandName nvarchar(50),
)
INSERT INTO Cars (BrandID,ColorID,ModelYear,DailyPrice,Descriptions)
VALUES 
	('1','2','2012','150','Manuel Benzin'),
	('1','3','2015','170','Otomatik Dizel'),
	('2','1','2017','200','Otomatik Hybrid'),
	('3','3','2014','125','Manuel Dizel');
INSERT INTO Colors (ColorName)
VALUES 
	('Beyaz'),
	('Siyah'),
	('Mavi');
INSERT INTO Brands(BrandName)
VALUES 
	('Mercedes'),
	('BMW'),
	('FİAT');	
SELECT * FROM Cars
SELECT * FROM Colors
SELECT * FROM Brands

