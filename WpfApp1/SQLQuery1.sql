CREATE PROC UserAdd
@Username varchar(15),
@FirstName varchar(50),
@LastName varchar(50),
@Email varchar(50),
@Password varchar(50),
AS
	INSERT INTO tblUser(Username,FirstName,LastName,Email,Password)
	VALUES (@Username,@FirstName,@LastName,@Email,@Password)