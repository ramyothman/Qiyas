CREATE PROCEDURE [dbo].[GetByIDStateProvince]
    @StateProvinceId int

AS
BEGIN
Select StateProvinceId, StateProvinceCode, CountryRegionCode, IsOnlyStateProvince, Name, RowGuid, ModifiedDate
From [Person].[StateProvince]

WHERE [StateProvinceId] = @StateProvinceId
END
