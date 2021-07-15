-- Switching to CommaSpace SCHEMA
USE CommaSpace;

-- DROPING ALL EXISTING TABLES
DROP TABLE IF EXISTS Reservations;
DROP TABLE IF EXISTS Feedbacks;
DROP TABLE IF EXISTS Users2;
DROP TABLE IF EXISTS Rooms;

-- ...TABLES CREATION...
CREATE TABLE Users2 (
userID INT IDENTITY primary key,
userName NVARCHAR(20) not null,
userMail NVARCHAR(30) not null,
userPhone NVARCHAR(20) not null,
userPassword NVARCHAR(30) not null,
userType NVARCHAR(10) not null,
userNumberOfRents INT
);

CREATE TABLE Rooms (
roomID INT IDENTITY primary key,
roomName NVARCHAR(20) unique not null,
roomImage Image,
rentType NVARCHAR(10) not null,
rentPrice FLOAT not null
);

CREATE TABLE Reservations (
reservationID INT IDENTITY primary key,
rentStartDate DATETIME unique not null,
rentEndDate DATETIME  not null,
customerID INT not null FOREIGN KEY REFERENCES Users2(userID),
roomID INT not null FOREIGN KEY REFERENCES Rooms(roomID),
reservationPrice FLOAT not null
);

CREATE TABLE Feedbacks (
feedbackID INT IDENTITY primary key,
customerIsSatisfied NVARCHAR(10) not null,
customerHadGoodService NVARCHAR(10) not null, 
customerHadProblems NVARCHAR(10) not null,
feedbackType NVARCHAR(10) not null,
feedbackContent NVARCHAR(100) not null,
customerID INT not null FOREIGN KEY REFERENCES Users2(userID),
);

-- Insertion of some Existing Users
INSERT INTO Users2 VALUES ('Ahmed Aly', 'ahmed@gmail.com', '01135628901', '123', 'Admin', null);
INSERT INTO Users2 VALUES ('Amr Gamal', 'amr20@gmail.com', '01011012314', '1234', 'Customer', 0);
INSERT INTO Users2 VALUES ('Mona Ramzy', 'mona@gmail.com', '01501579136', '1234', 'Customer', 0);

-- Insertion of some Existing static Rooms
INSERT INTO Rooms VALUES ('Jokky', NULL, 'Hourly', 180);
INSERT INTO Rooms VALUES ('Reddy', NULL, 'Hourly', 250);
INSERT INTO Rooms VALUES ('Gatsby', NULL, 'Daily', 850);
INSERT INTO Rooms VALUES ('Greeny', NULL, 'Hourly', 150);
INSERT INTO Rooms VALUES ('Groupy', NULL, 'Hourly', 140);
INSERT INTO Rooms VALUES ('Hommy', NULL, 'Daily', 800);
INSERT INTO Rooms VALUES ('Dreamy', NULL, 'Daily', 600);
