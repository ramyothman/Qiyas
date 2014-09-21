create PROCEDURE [dbo].[GetByActivationCodePerson]
    @ActivationCode nvarchar(150)
AS
BEGIN
Declare @PersonId int

Select @PersonId = Person.Credential.BusinessEntityId From Person.Credential where Person.Credential.ActivationCode = @ActivationCode
Select *
From [Person].[Person] Where BusinessEntityId = @PersonId
END
