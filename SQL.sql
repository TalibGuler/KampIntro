 --Select
 --ANSII
 Select ContactName Adi ,CompanyName SirketAdi, City Sehir from Customers
 
 Select * from Customers where City='London'
 
 --case insensitive
 Select * from Products where categoryId=1 or categoryId=3 -- where bunları sec tarzında
 Select * from Products where categoryId=1 and UnitPrice>=10
 Select * from Products order by UnitPrice desc -- order by bu şekilde sırala buna göre -asc artan -desc düşer

 Select count(*) Adet from Products -- bütün productsta kac tane data var

 Select CategoryID, count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10

 Select
 Products.ProductID,Products.ProductName,Products.UnitPrice, Categories.CategoryName
 from Products inner join Categories
 on Products.CategoryID = Categories.CategoryID 
 where Products.UnitPrice>10

 -- Tabloda eşleşen varsa getirir yoksa getirmez!!!
 --DTO Data Transformation Object

 Select*from Products p left join [Order Details] od
 on p.ProductID=od.ProductID
 inner join Orders o on o.OrderID = Od.OrderID 

 Select * from Customers c left join Orders o on c.CustomerID=o.CustomerID where o.CustomerID is null --solda olup sagda olmayanları getir.