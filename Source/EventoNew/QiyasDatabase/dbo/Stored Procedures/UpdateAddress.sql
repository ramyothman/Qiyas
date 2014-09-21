CREATE PROCEDURE [dbo].[UpdateAddress]
    @OldAddressId int,
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
UPDATE [Person].[Address]
SET
    AddressLine1 = @AddressLine1,
    AddressLine2 = @AddressLine2,
    AddressLine3 = @AddressLine3,
    CountryRegionCode = @CountryRegionCode,
    City = @City,
    StateProvinceId = @StateProvinceId,
    PostalCode = @PostalCode,
    ZipCode = @ZipCode,
    SpatialLocation = @SpatialLocation,
    RowGuid = @RowGuid,
    ModifiedDate = @ModifiedDate
WHERE [AddressId] = @OLDAddressId
IF @@ROWCOUNT > 0
Select * From Person.Address 
Where [AddressId] = @OLDAddressId
