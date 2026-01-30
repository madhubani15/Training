USE LPU_Db

select * from StudentInfo
Alter Table StudentInfo Add PhoneNo Varchar(10)
Alter Table StudentInfo Add SchoolName Varchar(10) default 'RKVM'
-- RKVM is the default value of SchoolName ( default constraint )

Insert into StudentInfo(RollNo, Name, Age, LocalAddr, PerAddress, PhoneNo)
					values(102,'Riya', 22, 'Delhi', 'Lucknow', '9823622041')


SP_HELP StudentInfo

Create Table StudentMarks(srNo int identity(1000,1), 
							RollNo int References dbo.StudentInfo(RollNo),
							Phy int Not Null,
							Chem int Not Null,
							Maths int Not Null,
							TotMarks as(Phy+Chem+Maths),
							Perc as (Phy+Chem+Maths)/3)

-- Primary Key has to be fed manually so we use Identity column instead
-- (1000,1) => starts from 1000 and increments by 1
-- Even false transactions are managed
-- failed transactions are also counted


Insert into StudentMarks(RollNo, Phy, Chem, Maths) values(101, 85,65,75)
Insert into StudentMarks(RollNo, Phy, Chem, Maths) values(102, 65,65,95)
select * from StudentMarks

