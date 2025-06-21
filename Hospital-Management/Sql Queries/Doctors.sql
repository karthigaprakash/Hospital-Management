USE HospitalManagement
GO

CREATE TABLE Doctors (
    id int,
    Name varchar(25) NOT NULL,
    Specialization varchar(25) NOT NULL,
    Phone varchar(15) NOT NULL UNIQUE,
    Email varchar(25) NOT NULL UNIQUE,
    Experience int NOT NULL,
    AvailableDays varchar(10)
);
