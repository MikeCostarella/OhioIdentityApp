CREATE PROCEDURE [dbo].[spAppUser_GetAll]
AS
BEGIN
	SELECT Id, EmailAddress, FirstName, LastName
	FROM dbo.AppUser;
END