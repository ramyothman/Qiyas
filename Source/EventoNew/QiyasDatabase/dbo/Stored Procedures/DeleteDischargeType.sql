CREATE PROCEDURE [dbo].[DeleteDischargeType]
    @DischargeTypeId int

AS
Begin
 Delete [BedManagement].[DischargeType] where     [DischargeTypeId] = @DischargeTypeId
End
