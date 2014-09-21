CREATE PROCEDURE [dbo].[GetByIDDischargeType]
    @DischargeTypeId int

AS
BEGIN
Select DischargeTypeId, Name, DischargeCode, DischargeOrder
From [BedManagement].[DischargeType]

WHERE [DischargeTypeId] = @DischargeTypeId
END
