CREATE PROCEDURE [dbo].[InsertNewCountryRegion]
    @CountryRegionCode char(3),
    @Name nvarchar(50),
    @ModifiedDate datetime
AS
INSERT INTO [Person].[CountryRegion] (
    [CountryRegionCode],
    [Name],
    [ModifiedDate])
Values (
    @CountryRegionCode,
    @Name,
    @ModifiedDate)

IF @@ROWCOUNT > 0
Select * from Person.CountryRegion
Where [CountryRegionCode] = @CountryRegionCode
