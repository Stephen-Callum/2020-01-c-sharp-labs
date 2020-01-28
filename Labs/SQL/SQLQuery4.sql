-- Shift focus to build-in database
use master 
go -- confirms and executes immediately

drop database if exists testdatabase
go

create database testdatabase
go

use testdatabase
go

drop table if exists TestTable

-- Null means entry can be empty
-- not null means entry required
-- identity means auto create ID with next available ID automatically
--primary key means unique values required
create table TestTable(
	TestTableID INT NOT NULL IDENTITY PRIMARY KEY,
	TestName VARCHAR(50) NULL,
	TestAge INT NULL
)

insert into TestTable values('name01', 22)
insert into TestTable values('name02', 33)
insert into TestTable values('name03', 44)

select * from TestTable