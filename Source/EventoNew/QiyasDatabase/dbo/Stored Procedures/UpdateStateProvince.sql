CREATE PROCEDURE [dbo].[UpdateStateProvince]
    @OldStateProvinceId int,
    @StateProvinceCode nchar(3),
    @CountryRegionCode char(3),
    @IsOnlyStateProvince bit,
    @Name nvarchar(50),
    @RowGuid uniqueidentifier,
    @ModifiedDate datetime
AS
UPDATE [Person].[StateProvince]
SET
    StateProvinceCode = @StateProvinceCode,
    CountryRegionCode = @CountryRegionCode,
    IsOnlyStateProvince = @IsOnlyStateProvince,
    Name = @Name,
    RowGuid = @RowGuid,
    ModifiedDate = @ModifiedDate
WHERE [StateProvinceId] = @OLDStateProvinceId
IF @@ROWCOUNT > 0
Select * From Person.StateProvince 
Where [StateProvinceId] = @OLDStateProvinceId
