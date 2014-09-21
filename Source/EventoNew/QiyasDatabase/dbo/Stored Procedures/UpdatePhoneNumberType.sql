CREATE PROCEDURE [dbo].[UpdatePhoneNumberType]
    @OldPhoneNumberTypeId int,
    @Name nvarchar(50),
    @ModifiedDate datetime
AS
UPDATE [Person].[PhoneNumberType]
SET
    Name = @Name,
    ModifiedDate = @ModifiedDate
WHERE [PhoneNumberTypeId] = @OLDPhoneNumberTypeId
IF @@ROWCOUNT > 0
Select * From Person.PhoneNumberType 
Where [PhoneNumberTypeId] = @OLDPhoneNumberTypeId
