CREATE PROCEDURE [dbo].[UpdateCountryRegion]
    @CountryRegionCode char(3),
    @OldCountryRegionCode char(3),
    @Name nvarchar(50),
    @ModifiedDate datetime
AS
UPDATE [Person].[CountryRegion]
SET
    CountryRegionCode = @CountryRegionCode,
    Name = @Name,
    ModifiedDate = @ModifiedDate
WHERE [CountryRegionCode] = @OLDCountryRegionCode
IF @@ROWCOUNT > 0
Select * From Person.CountryRegion 
Where [CountryRegionCode] = @CountryRegionCode
