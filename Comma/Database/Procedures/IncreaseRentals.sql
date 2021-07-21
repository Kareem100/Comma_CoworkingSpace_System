CREATE PROCEDURE increaseRentals @reservationID INT
AS
UPDATE Users2
SET userNumberOfRents = userNumberOfRents + 1
WHERE userID = (SELECT customerID FROM Reservations WHERE reservationID = @reservationID); 