CREATE PROCEDURE [dbo].[GetByIDAddressType]
    @AddressTypeId int

AS
BEGIN
Select AddressTypeId, Name, RowGuid, ModifiedDate
From [Person].[AddressType]

WHERE [AddressTypeId] = @AddressTypeId
END
