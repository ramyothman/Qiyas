CREATE PROCEDURE [dbo].[GetByIDPersonPhone]
    @Id int

AS
BEGIN
Select Id, BusinessEntityId, PhoneNumber, PhoneNumberTypeId, ModifiedDate, PhoneVerified, PhoneVerificationCode
From [Person].[PersonPhone]

WHERE [Id] = @Id
END
