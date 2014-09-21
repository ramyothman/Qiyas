CREATE PROCEDURE [dbo].[GetByIDAddress]
    @AddressId int

AS
BEGIN
Select AddressId, AddressLine1, AddressLine2, AddressLine3, CountryRegionCode, City, StateProvinceId, PostalCode, ZipCode, SpatialLocation, RowGuid, ModifiedDate
From [Person].[Address]

WHERE [AddressId] = @AddressId
END
