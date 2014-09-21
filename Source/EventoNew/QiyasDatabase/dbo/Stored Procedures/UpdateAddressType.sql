CREATE PROCEDURE [dbo].[UpdateAddressType]
    @OldAddressTypeId int,
    @Name nvarchar(50),
    @RowGuid uniqueidentifier,
    @ModifiedDate datetime
AS
UPDATE [Person].[AddressType]
SET
    Name = @Name,
    RowGuid = @RowGuid,
    ModifiedDate = @ModifiedDate
WHERE [AddressTypeId] = @OLDAddressTypeId
IF @@ROWCOUNT > 0
Select * From Person.AddressType 
Where [AddressTypeId] = @OLDAddressTypeId
