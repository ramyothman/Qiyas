create PROCEDURE [dbo].[GetByPersonIdPersonPhones]
    @BusinessEntityId int

AS
BEGIN
Select Id, BusinessEntityId, PhoneNumber, PhoneNumberTypeId, ModifiedDate, PhoneVerified, PhoneVerificationCode
From [Person].[PersonPhone]

WHERE BusinessEntityId = @BusinessEntityId
END
