
Select * from StudentInfo
Insert into StudentInfo(RollNo,Name,Age, LocalAddr, PerAddress) 
				values(104,'Naman', 20, 'Chennai','Coimbatore')

Update StudentInfo set Age=24 where RollNo=103

-- Check constraint
Alter Table StudentInfo
Add constraint Chk_Age
Check(Age>=18 AND Age<=60)

-- Constraint created
Create Default DF_HomeTown
As 'Pune'
Go 

-- Constraint bounded with Table.ColumnName
Exec sp_bindefault DF_HomeTown,
'StudentInfo.LocalAddr'

--  One default can be bound to multiple tables
Select * from Person
Exec sp_bindefault DF_HomeTown,
'Person.Address'

Insert into Person(Id, Name, Age, PhoneNo) values(1,'Nishant', 22,'3123354567')

Alter Table Person 
Add SocialStatus varchar(10) 

Create Rule rl_SocialStatus
As @SocialStatus IN ('Married','Unmarried','Widow','Divorcee')
Go


Exec sp_bindefault rl_SocialStatus,
'Person.SocialStatus'

declare @num1 as int
set @num1 = 100;
declare @num2 as int
set @num2 = 200;
declare @numResult as int
set @numResult = @num1+@num2;
print 'The sum of ' +cast(@num1 as varchar)+' and '+cast(@num2 as varchar)+' is '+cast(@numResult as varchar);


-- 