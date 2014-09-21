CREATE PROCEDURE [dbo].[InsertNewAddressType]
    @AddressTypeId int output ,
    @Name nvarchar(50),
    @RowGuid uniqueidentifier,
    @ModifiedDate datetime
AS
INSERT INTO [Person].[AddressType] (
    [Name],
    [RowGuid],
    [ModifiedDate])
Values (
    @Name,
    @RowGuid,
    @ModifiedDate)
Set @AddressTypeId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Person.AddressType
Where [AddressTypeId] = @@identity
