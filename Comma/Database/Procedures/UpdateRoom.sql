CREATE PROCEDURE updateRoom @roomID INT, @roomName NVARCHAR(20), @roomImage IMAGE, @roomDescription NVARCHAR(500), @rentType NVARCHAR(10), @rentPrice INT
AS
UPDATE Rooms 
SET roomName = @roomName, roomImage = @roomImage, 
roomDescription = @roomDescription, rentType = @rentType, rentPrice = @rentPrice
WHERE roomID = @roomID;