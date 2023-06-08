CREATE PROCEDURE [dbo].[spAppUser_Get]
	@Id int
AS
BEGIN
	SELECT Id, EmailAddress, FirstName, LastName
	FROM dbo.AppUser
	WHERE Id = @Id;
END