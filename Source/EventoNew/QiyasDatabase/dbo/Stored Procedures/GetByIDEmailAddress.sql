CREATE PROCEDURE [dbo].[GetByIDEmailAddress]
    @EmailAddressId int

AS
BEGIN
Select EmailAddressId, BusinessEntityId, EmailAddressTypeId, Email, EmailVerified, EmailVerificationHash, RowGuid, ModifiedDate
From [Person].[EmailAddress]

WHERE [EmailAddressId] = @EmailAddressId
END
