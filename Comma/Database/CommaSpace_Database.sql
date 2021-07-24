-- Switching to CommaSpace SCHEMA
USE CommaSpace;

-- DROPING ALL EXISTING TABLES
DROP TABLE IF EXISTS AdminCustomerMessages;
DROP TABLE IF EXISTS Reservations;
DROP TABLE IF EXISTS SocialLinks;
DROP TABLE IF EXISTS Feedbacks;
DROP TABLE IF EXISTS Users2;
DROP TABLE IF EXISTS Rooms;

-- ...TABLES CREATION...
CREATE TABLE Users2 (
userID INT IDENTITY primary key,
userName NVARCHAR(20) not null,
userMail NVARCHAR(30) UNIQUE not null,
userPhone NVARCHAR(20) not null,
userPassword NVARCHAR(30) not null,
userType NVARCHAR(10) not null,
userNumberOfRents INT
);

CREATE TABLE Rooms (
roomID INT IDENTITY primary key,
roomName NVARCHAR(20) unique not null,
roomImage Image,
roomDescription NVARCHAR(500) not null,
rentType NVARCHAR(10) not null,
rentPrice INT not null
);

CREATE TABLE Reservations (
reservationID INT IDENTITY primary key,
rentStartDate DATETIME unique not null,
rentEndDate DATETIME  not null,
customerID INT not null FOREIGN KEY REFERENCES Users2(userID),
roomID INT not null FOREIGN KEY REFERENCES Rooms(roomID),
rentStartHour INT NOT NULL,
rentEndHour INT NOT NULL,
capacity INT NOT NULL,
reservationPrice FLOAT not null,
reservationState NVARCHAR(50) NOT NULL,
addRequests NVARCHAR(300) NULL
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

CREATE TABLE AdminCustomerMessages (
messageID INT IDENTITY primary key,
adminID INT not null FOREIGN KEY REFERENCES Users2(userID), 
customerID INT not null FOREIGN KEY REFERENCES Users2(userID),
messageContent NVARCHAR(200) not null,
fromAdmin BIT not null,
seen BIT not null
);

CREATE TABLE SocialLinks (
facebook VARCHAR(100),
twitter VARCHAR(100),
instagram VARCHAR(100),
askfm VARCHAR(100)
);

-- Insertion of some Existing Users
INSERT INTO Users2 VALUES ('Ahmed Aly', 'ahmed@gmail.com', '01135628901', '123', 'Admin', null);
INSERT INTO Users2 VALUES ('Amr Gamal', 'amr20@gmail.com', '01011012314', '1234', 'Customer', 0);
INSERT INTO Users2 VALUES ('Mona Ramzy', 'mona@gmail.com', '01501579136', '1234', 'Customer', 0);

-- Insertion of some Existing static Rooms
/*
INSERT INTO Rooms VALUES ('Jokky', NULL, 'Lorem ipsum dolor sit amet, adipiscing elit.' + CHAR(13) + 'Praesent in aliquet justo. Donec eget risus,' + CHAR(13) + 'Nam iaculis, nibh quis facilisis tempor,' + CHAR(13) + 'risus ligula malesuada tortor.', 'Hourly', 180);
INSERT INTO Rooms VALUES ('Reddy', NULL, 'Lorem ipsum dolor sit amet, adipiscing elit.' + CHAR(13) + 'Praesent in aliquet justo. Donec eget risus,' + CHAR(13) + 'Nam iaculis, nibh quis facilisis tempor.', 'Hourly', 250);
INSERT INTO Rooms VALUES ('Gatsby', NULL, 'Lorem ipsum dolor sit amet, adipiscing elit.' + CHAR(13) + 'Praesent in aliquet justo. Donec eget risus,' + CHAR(13) + 'risus ligula malesuada tortor.', 'Daily', 850);
INSERT INTO Rooms VALUES ('Greeny', NULL, 'Lorem ipsum dolor sit amet, adipiscing elit.' + CHAR(13) + 'Praesent in aliquet justo. Donec eget risus,' + CHAR(13) + 'Nam iaculis, nibh quis facilisis tempor,' + CHAR(13) + 'risus ligula malesuada tortor.', 'Hourly', 150);
INSERT INTO Rooms VALUES ('Groupy', NULL, 'Lorem ipsum dolor sit amet, adipiscing elit.' + CHAR(13) + 'Praesent in aliquet justo. Donec eget risus,' + CHAR(13) + 'Nam iaculis, nibh quis facilisis tempor.', 'Hourly', 140);
INSERT INTO Rooms VALUES ('Hommy', NULL, 'Lorem ipsum dolor sit amet, adipiscing elit.' + CHAR(13) + 'Praesent in aliquet justo. Donec eget risus,' + CHAR(13) + 'Nam iaculis, nibh quis facilisis tempor,' + CHAR(13) + 'risus ligula malesuada tortor.', 'Daily', 800);
INSERT INTO Rooms VALUES ('Dreamy', NULL, 'Lorem ipsum dolor sit amet, adipiscing elit.' + CHAR(13) + 'Praesent in aliquet justo. Donec eget risus,' + CHAR(13) + 'risus ligula malesuada tortor.', 'Daily', 600);
*/