create PROCEDURE [dbo].[GetByPersonIDEmailAddress]
    @BusinessEntityId int

AS
BEGIN
Select EmailAddressId, BusinessEntityId, EmailAddressTypeId, Email, EmailVerified, EmailVerificationHash, RowGuid, ModifiedDate
From [Person].[EmailAddress]

WHERE BusinessEntityId = @BusinessEntityId
END
