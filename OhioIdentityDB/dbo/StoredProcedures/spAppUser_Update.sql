CREATE PROCEDURE [dbo].[spAppUser_Update]
	@Id int,
	@EmailAddress nvarchar(100),
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@MiddleName nvarchar(50)
AS
BEGIN
	UPDATE dbo.AppUser
	SET
		EmailAddress = @EmailAddress,
		FirstName = @FirstName,
		LastName = @LastName,
		MiddleName = @MiddleName
	WHERE
		Id = @Id
END
