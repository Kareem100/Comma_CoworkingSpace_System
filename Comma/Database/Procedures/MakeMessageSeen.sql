CREATE PROCEDURE makeMessageSeen @messageID INT
AS
UPDATE AdminCustomerMessages 
SET seen = 1 
WHERE messageID = @messageID