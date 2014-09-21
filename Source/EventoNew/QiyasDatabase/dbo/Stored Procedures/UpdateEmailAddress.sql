CREATE PROCEDURE [dbo].[UpdateEmailAddress]
    @OldEmailAddressId int,
    @BusinessEntityId int,
    @EmailAddressTypeId int,
    @Email nvarchar(60),
    @EmailVerified bit,
    @EmailVerificationHash nvarchar(128),
    @RowGuid uniqueidentifier,
    @ModifiedDate datetime
AS
UPDATE [Person].[EmailAddress]
SET
    BusinessEntityId = @BusinessEntityId,
    EmailAddressTypeId = @EmailAddressTypeId,
    Email = @Email,
    EmailVerified = @EmailVerified,
    EmailVerificationHash = @EmailVerificationHash,
    RowGuid = @RowGuid,
    ModifiedDate = @ModifiedDate
WHERE [EmailAddressId] = @OLDEmailAddressId
IF @@ROWCOUNT > 0
Select * From Person.EmailAddress 
Where [EmailAddressId] = @OLDEmailAddressId
