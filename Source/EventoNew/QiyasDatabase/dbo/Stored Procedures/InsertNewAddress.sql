CREATE PROCEDURE [dbo].[InsertNewAddress]
    @AddressId int output ,
    @AddressLine1 nvarchar(60),
    @AddressLine2 nvarchar(60),
    @AddressLine3 nvarchar(60),
    @CountryRegionCode char(3),
    @City nvarchar(30),
    @StateProvinceId int,
    @PostalCode nvarchar(15),
    @ZipCode nvarchar(15),
    @SpatialLocation nvarchar(60),
    @RowGuid uniqueidentifier,
    @ModifiedDate datetime
AS
INSERT INTO [Person].[Address] (
    [AddressLine1],
    [AddressLine2],
    [AddressLine3],
    [CountryRegionCode],
    [City],
    [StateProvinceId],
    [PostalCode],
    [ZipCode],
    [SpatialLocation],
    [RowGuid],
    [ModifiedDate])
Values (
    @AddressLine1,
    @AddressLine2,
    @AddressLine3,
    @CountryRegionCode,
    @City,
    @StateProvinceId,
    @PostalCode,
    @ZipCode,
    @SpatialLocation,
    @RowGuid,
    @ModifiedDate)
Set @AddressId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Person.Address
Where [AddressId] = @@identity
