create proc editeRentalState @ID int, @State nvarchar(50)
As
update Reservations
set reservationState=@State
where reservationID=@ID;