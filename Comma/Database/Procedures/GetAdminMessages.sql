CREATE PROCEDURE getAdminMessages @adminID INT
AS
SELECT m.messageID, u.userName, m.messageContent 
FROM Users2 u, AdminCustomerMessages m
WHERE m.fromAdmin = 0 AND m.seen = 0 AND m.adminID = @adminID AND u.userID = m.customerID
ORDER BY m.messageID DESC;