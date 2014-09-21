CREATE PROCEDURE [dbo].[InsertNewBusinessEntityAddress]
    @BusinessEntityAddressId int output ,
    @BusinessEntityId int,
    @AddressId int,
    @AddressTypeId int,
    @RowGuid uniqueidentifier,
    @ModifiedDate datetime
AS
INSERT INTO [Person].[BusinessEntityAddress] (
    [BusinessEntityId],
    [AddressId],
    [AddressTypeId],
    [RowGuid],
    [ModifiedDate])
Values (
    @BusinessEntityId,
    @AddressId,
    @AddressTypeId,
    @RowGuid,
    @ModifiedDate)
Set @BusinessEntityAddressId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Person.BusinessEntityAddress
Where [BusinessEntityAddressId] = @@identity
