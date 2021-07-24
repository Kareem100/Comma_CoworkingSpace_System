CREATE PROCEDURE addMessage @adminID INT, @customerID INT, @messageContent NVARCHAR(200), @fromAdmin BIT
AS
INSERT INTO AdminCustomerMessages VALUES (@adminID, @customerID, @messageContent, @fromAdmin, 0);