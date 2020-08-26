﻿Create Database CastGroup
use CastGroup
Create Table Category(
    Id int IDENTITY(1,1) PRIMARY KEY,
    Description varchar(255) NOT NULL,   
    
)
Create Table Course(
    Id int IDENTITY(1,1) PRIMARY KEY,
    SubjectDescription varchar(255) NOT NULL,   
    StartDate datetime NOT NULL,   
	EndDate datetime NOT NULL,   
	NumberStudents int,   
	CategoryId int
)