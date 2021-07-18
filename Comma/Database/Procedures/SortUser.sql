CREATE PROCEDURE sortuser
AS
select * from Users2
order by userNumberOfRents desc;