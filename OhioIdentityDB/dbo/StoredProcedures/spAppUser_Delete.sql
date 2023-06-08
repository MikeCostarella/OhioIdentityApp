CREATE PROCEDURE [dbo].[spAppUser_Delete]
	@Id int
AS
BEGIN
	DELETE
	FROM dbo.AppUser
	WHERE Id = @Id;
END