CREATE PROCEDURE [dbo].[GetByIDEmailAddressType]
    @EmailAddressTypeId int

AS
BEGIN
Select EmailAddressTypeId, Name, ModifiedDate
From [Person].[EmailAddressType]

WHERE [EmailAddressTypeId] = @EmailAddressTypeId
END
