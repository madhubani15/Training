-- Create Database LPU_Db
-- use LPU_Db
Create schema Madhu
-- Consider this as namespace
-- Logical grouping of tables

-- DDL
Create Table Madhu.Person(Id int, 
					Name varchar(20) Not Null,
-- Not Null => this thing is not going to accept null value
					Age int,
					Address varchar(50),
					PhoneNo varchar(10)
					)
