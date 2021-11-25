GO
create PROCEDURE Loginprocedure(
	
@Name as nvarchar(25),
@Password as nvarchar(25))
AS

IF Not Exists (Select 1 From LOGIN Where Name = @Name and Password=@Password)
BEGIN
	select * from LOGIN where Name=@Name and Password=@Password

RETURN 0
END
ELSE
BEGIN
RETURN 1
END