CREATE PROCEDURE [dbo].[GetByUserNamePerson]
    @UserName nvarchar(50)
AS
BEGIN
Declare @PersonId int

Select @PersonId = Person.Credential.BusinessEntityId From Person.Credential where Person.Credential.Username = @UserName
Select *
From [Person].[Person] Where BusinessEntityId = @PersonId
END
