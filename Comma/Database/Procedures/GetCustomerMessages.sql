CREATE PROCEDURE getCustomerMessages @customerID INT
AS
SELECT m.messageID, u.userName, m.messageContent 
FROM Users2 u, AdminCustomerMessages m
WHERE m.fromAdmin = 1 AND m.seen = 0 AND m.customerID = 9 AND u.userID = m.adminID
ORDER BY m.messageID DESC;