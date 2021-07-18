CREATE proc insertReservation
@RentStartDate datetime,
@RentEndDate datetime,
@CustomerID int,
@RoomID int,
@RentStartHour int,
@RentEndHour int,
@cap int,
@ReservationPrice float,
@ReservationState nvarchar(50),
@AddRequests nvarchar(300)
As
insert into Reservations (rentStartDate,rentEndDate,customerID,roomID,rentStartHour,rentEndHour,capacity,reservationPrice,reservationState,addRequests)
Values(@RentStartDate,@RentEndDate,@CustomerID,@RoomID,@RentStartHour,@RentEndHour,@cap,@ReservationPrice,@reservationState,@AddRequests);
