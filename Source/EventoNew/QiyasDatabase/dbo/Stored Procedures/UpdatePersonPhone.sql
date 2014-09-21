CREATE PROCEDURE [dbo].[UpdatePersonPhone]
    @OldId int,
    @BusinessEntityId int,
    @PhoneNumber nvarchar(25),
    @PhoneNumberTypeId int,
    @ModifiedDate datetime,
    @PhoneVerified bit,
    @PhoneVerificationCode nvarchar(50)
AS
UPDATE [Person].[PersonPhone]
SET
    BusinessEntityId = @BusinessEntityId,
    PhoneNumber = @PhoneNumber,
    PhoneNumberTypeId = @PhoneNumberTypeId,
    ModifiedDate = @ModifiedDate,
    PhoneVerified = @PhoneVerified,
    PhoneVerificationCode = @PhoneVerificationCode
WHERE [Id] = @OLDId
IF @@ROWCOUNT > 0
Select * From Person.PersonPhone 
Where [Id] = @OLDId
