CREATE VIEW [dbo].[GetAllBusinessEntityAddress]
AS
SELECT     Person.BusinessEntityAddress.BusinessEntityAddressId, Person.BusinessEntityAddress.BusinessEntityId, Person.BusinessEntityAddress.AddressId, 
                      Person.BusinessEntityAddress.AddressTypeId, Person.BusinessEntityAddress.RowGuid, Person.BusinessEntityAddress.ModifiedDate, 
                      Person.Address.AddressLine1, Person.Address.AddressLine2, Person.Address.AddressLine3, Person.Address.CountryRegionCode, Person.Address.City, 
                      Person.Address.StateProvinceId, Person.Address.PostalCode, Person.Address.ZipCode, Person.Address.SpatialLocation, 
                      Person.CountryRegion.Name AS CountryName
FROM         Person.BusinessEntityAddress INNER JOIN
                      Person.Address ON Person.BusinessEntityAddress.AddressId = Person.Address.AddressId INNER JOIN
                      Person.CountryRegion ON Person.Address.CountryRegionCode = Person.CountryRegion.CountryRegionCode
