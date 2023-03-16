create database mafon;

create table city_
(
	Id_city_ int identity (1,1) primary key,
	city_name varchar(255),
	daily_rate int,
	night_rate int
);

create table calls
(
	Id_calls  int identity (1,1) primary key,

	date int,
	number_of_minutes int,

	city_id int NOT NULL
	foreign key (city_id)
		references city_ (Id_city_),

);

drop table city_, calls
go
