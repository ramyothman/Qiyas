CREATE PROCEDURE [dbo].[GetByIDCountryRegion]
    @CountryRegionCode char(3)

AS
BEGIN
Select CountryRegionCode, Name, ModifiedDate
From [Person].[CountryRegion]

WHERE [CountryRegionCode] = @CountryRegionCode
END
