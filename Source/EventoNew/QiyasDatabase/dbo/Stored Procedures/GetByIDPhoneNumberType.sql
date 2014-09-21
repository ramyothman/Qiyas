CREATE PROCEDURE [dbo].[GetByIDPhoneNumberType]
    @PhoneNumberTypeId int

AS
BEGIN
Select PhoneNumberTypeId, Name, ModifiedDate
From [Person].[PhoneNumberType]

WHERE [PhoneNumberTypeId] = @PhoneNumberTypeId
END
