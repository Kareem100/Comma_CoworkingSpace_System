CREATE PROCEDURE getCustomerMessages @customerID INT
AS
SELECT m.messageID, u.userName, m.messageContent 
FROM Users2 u, AdminCustomerMessages m
WHERE m.fromAdmin = 1 AND m.seen = 0 AND m.customerID = @customerID AND u.userID = m.adminID;