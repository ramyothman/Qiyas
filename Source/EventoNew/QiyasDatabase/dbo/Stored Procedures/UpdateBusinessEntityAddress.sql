CREATE PROCEDURE [dbo].[UpdateBusinessEntityAddress]
    @OldBusinessEntityAddressId int,
    @BusinessEntityId int,
    @AddressId int,
    @AddressTypeId int,
    @RowGuid uniqueidentifier,
    @ModifiedDate datetime
AS
UPDATE [Person].[BusinessEntityAddress]
SET
    BusinessEntityId = @BusinessEntityId,
    AddressId = @AddressId,
    AddressTypeId = @AddressTypeId,
    RowGuid = @RowGuid,
    ModifiedDate = @ModifiedDate
WHERE [BusinessEntityAddressId] = @OLDBusinessEntityAddressId
IF @@ROWCOUNT > 0
Select * From Person.BusinessEntityAddress 
Where [BusinessEntityAddressId] = @OLDBusinessEntityAddressId
