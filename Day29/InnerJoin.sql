
Select Dept.*,Emp.* From Dept,Emp Where Dept.DeptNo=Emp.DeptNo

Select Dept.*,Emp.* From Dept Inner Join Emp On Dept.DeptNo=Emp.DeptNo Where 
Emp.DeptNo=10



SELECT ProductID, ProductName, CategoryName
FROM Products, Categories
WHERE Products.CategoryID=Categories.CategoryID
GO

-- An INNER JOIN shows only the rows that match in both tables based on a common column. Rows without a match are not included.
