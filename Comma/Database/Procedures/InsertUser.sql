CREATE proc insertUser
@UserName nvarchar(20),
@userMail nvarchar(30),
@userPhone nvarchar(20),
@userPassword nvarchar(30),
@userType nvarchar(10),
@userNumberOfRentals int
As
insert into Users2 (userName,userMail,userPhone,userPassword,userType,userNumberOfRents)
Values(@UserName,@userMail,@userPhone,@userPassword,@userType,@userNumberOfRentals);
