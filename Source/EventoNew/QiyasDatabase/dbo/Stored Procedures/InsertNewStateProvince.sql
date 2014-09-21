CREATE PROCEDURE [dbo].[InsertNewStateProvince]
    @StateProvinceId int output ,
    @StateProvinceCode nchar(3),
    @CountryRegionCode char(3),
    @IsOnlyStateProvince bit,
    @Name nvarchar(50),
    @RowGuid uniqueidentifier,
    @ModifiedDate datetime
AS
INSERT INTO [Person].[StateProvince] (
    [StateProvinceCode],
    [CountryRegionCode],
    [IsOnlyStateProvince],
    [Name],
    [RowGuid],
    [ModifiedDate])
Values (
    @StateProvinceCode,
    @CountryRegionCode,
    @IsOnlyStateProvince,
    @Name,
    @RowGuid,
    @ModifiedDate)
Set @StateProvinceId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Person.StateProvince
Where [StateProvinceId] = @@identity
