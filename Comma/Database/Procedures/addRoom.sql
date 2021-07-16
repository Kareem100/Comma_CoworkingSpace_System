CREATE PROCEDURE addRoom @roomName NVARCHAR(20), @roomImage IMAGE, @roomDescription NVARCHAR(500), @rentType NVARCHAR(10), @rentPrice INT
AS
INSERT INTO Rooms VALUES (@roomName, @roomImage, @roomDescription, @rentType, @rentPrice);