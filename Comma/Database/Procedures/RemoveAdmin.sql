create proc RemoveAdmin (@ID int)
As
Delete Users2
where userID=@ID;