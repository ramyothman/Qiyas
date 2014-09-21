CREATE PROCEDURE [dbo].[DeleteCountryRegion]
    @CountryRegionCode char(3)

AS
Begin
 Delete [Person].[CountryRegion] where     [CountryRegionCode] = @CountryRegionCode
End
