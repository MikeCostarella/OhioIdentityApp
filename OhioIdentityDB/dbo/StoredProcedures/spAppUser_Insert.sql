CREATE PROCEDURE [dbo].[spAppUser_Insert]
	@EmailAddress nvarchar(100),
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@MiddleName nvarchar(50)
AS
BEGIN
	INSERT INTO dbo.AppUser (EmailAddress, FirstName, LastName, MiddleName)
	VALUES (@EmailAddress, @FirstName, @LastName, @MiddleName);
END