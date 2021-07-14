-- CREATING DATABASE CommaCoWorkingSpaceManagementSystem;

USE CommaSpace;

DROP TABLE IF EXISTS Reservations;
DROP TABLE IF EXISTS Feedbacks;
DROP TABLE IF EXISTS Users2;
DROP TABLE IF EXISTS Rooms;

CREATE TABLE Users2 (
userID INT primary key,
userName NVARCHAR not null,
userMail NVARCHAR not null,
userPhone NVARCHAR not null,
userPassword NVARCHAR not null,
userType NVARCHAR not null
);

CREATE TABLE Rooms (
roomID INT primary key,
roomName NVARCHAR unique not null,
roomImage VARBINARY  not null,
rentType NVARCHAR not null,
rentPrice FLOAT not null
);

CREATE TABLE Reservations (
reservationID INT primary key,
rentStartDate DATETIME unique not null,
rentEndDate DATETIME  not null,
customerID INT not null FOREIGN KEY REFERENCES Users2(userID),
roomID INT not null FOREIGN KEY REFERENCES Rooms(roomID),
reservationPrice FLOAT not null
);

CREATE TABLE Feedbacks (
feedbackID INT primary key,
customerIsSatisfied NVARCHAR not null,
customerHadGoodService NVARCHAR not null, 
customerHadProblems NVARCHAR not null,
feedbackType NVARCHAR not null,
feedbackContent NVARCHAR not null,
customerID INT not null FOREIGN KEY REFERENCES Users2(userID),
);