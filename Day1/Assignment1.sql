-- Question 1
Select ProductID, Name, Color, ListPrice from Production.Product

-- Question 2
Select ProductID, Name, Color, ListPrice from Production.Product 
where ListPrice  != 0;

-- Question 3
Select ProductID, Name, Color, ListPrice from Production.Product 
where Color  is NULL;

-- Question 4
Select ProductID, Name, Color, ListPrice from Production.Product 
where Color  is not NULL;

-- Question 5
Select ProductID, Name, Color, ListPrice from Production.Product 
where Color  is not NULL and ListPrice > 0;

-- Question 6
Select  Name + Color as NameplusColor from Production.Product 
where Color  is not NULL;

-- Question 7
Select  top 6 Name, Color from Production.Product 
where Color  is not NULL ;

-- Question 8
Select ProductID, Name from Production.Product 
where ProductID  between 400 and 500;

-- Question 9
Select ProductID, Name, Color from Production.Product 
where Color  in ('Black','Blue');

-- Question 10
Select * from Production.Product 
where Name like 'S%';

-- Question 11
Select Name, ListPrice from Production.Product
order by Name asc;

-- Question 12
Select Name, ListPrice from Production.Product
where Name like 'A%' or Name like 'S%'
order by Name asc;

-- Question 13
Select * from Production.Product
where Name like 'SPO[^k]%'
order by Name asc;

-- Question 14
Select distinct Color from Production.Product
order by Color desc;

-- Question 15
Select distinct ProductSubcategoryID, Color from Production.Product
where ProductSubcategoryID is not NULL and Color is not NULL
order by ProductSubcategoryID, Color;
