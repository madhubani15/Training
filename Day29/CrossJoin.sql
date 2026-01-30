Use Northwind
GO
Select * from Dept
Select * from Emp
GO
Select Dept.*,Emp.* From Dept,Emp
Select Dept.*,Emp.* From Dept Cross Join Emp
-- A CROSS JOIN combines each row of one table with every row of another table. It makes all possible row pairs between the two tables.
