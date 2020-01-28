-- Shift focus to build-in database
use master 
go -- confirms and executes immediately

drop database if exists RabbitDatabase
go

create database RabbitDatabase
go

use RabbitDatabase
go

drop table if exists RabbitTable
go

create table RabbitTable(
	RabbitID INT NOT NULL IDENTITY PRIMARY KEY,
	RabbitName VARCHAR(50) NULL,
	RabbitAge INT NULL
)

insert into RabbitTable(
	RabbitName,
	RabbitAge
)
values
	(
		'Buggs', 12
	),
	(
		'Roger', 5
	),
	(
		'Easter', 1000
	),
	(
		'Schtee', 25
	);

select * from RabbitTable