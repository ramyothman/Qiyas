CREATE PROCEDURE [dbo].[DeleteStateProvince]
    @StateProvinceId int

AS
Begin
 Delete [Person].[StateProvince] where     [StateProvinceId] = @StateProvinceId
End
