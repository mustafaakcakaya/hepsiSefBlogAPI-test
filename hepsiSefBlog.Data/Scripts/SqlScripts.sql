Create Database hepsiSefBlogDb
GO

use hepsiSefBlogDb
GO

CREATE TABLE Recipe(
Id int primary key identity,
HowTo nvarchar(1500) not null, 
Ingredients nvarchar(500) not null,
Title nvarchar(100) not null,
ImageUrlList nvarchar(500) not null,
Tags nvarchar(500) not null
)

Insert Into Recipe
values 
('yapılma şekli - adım adım','un, yumurta, şeker','Balkan Keki','img1.jpg, image5.jpg','kekler, tatlılar'),
('böyle böyle yapılır','un, yumurta, şeker','Doğu Keki','img1.jpg, image5.jpg','kekler, tatlılar'),
('yapılma şekli - adım adım','un, yumurta, şeker','Kuzey Keki','img1.jpg, image5.jpg','kekler, tatlılar'),
('yapılma şekli - adım adım','un, yumurta, şeker','Güney Keki','img1.jpg, image5.jpg','kekler, tatlılar')
