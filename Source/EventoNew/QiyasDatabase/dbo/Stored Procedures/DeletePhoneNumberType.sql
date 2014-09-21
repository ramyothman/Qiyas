CREATE PROCEDURE [dbo].[DeletePhoneNumberType]
    @PhoneNumberTypeId int

AS
Begin
 Delete [Person].[PhoneNumberType] where     [PhoneNumberTypeId] = @PhoneNumberTypeId
End
