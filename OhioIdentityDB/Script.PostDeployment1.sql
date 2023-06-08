if NOT EXISTS (SELECT 1 FROM dbo.AppUser)
BEGIN
    INSERT INTO dbo.AppUser (EmailAddress, FirstName, LastName, MiddleName)
    VALUES
        ('latvianvillagecloudware@gmail.com', 'Mike', 'Costarella', ''),
        ('MiguelCosti101@gmail.com', 'Miguel', 'Costi', '');
END
