CREATE PROCEDURE [dbo].[DeleteAddressType]
    @AddressTypeId int

AS
Begin
 Delete [Person].[AddressType] where     [AddressTypeId] = @AddressTypeId
End
