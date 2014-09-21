CREATE PROCEDURE [dbo].[UpdateDischargeType]
    @OldDischargeTypeId int,
    @Name nvarchar(250),
    @DischargeCode nvarchar(5),
    @DischargeOrder int
AS
UPDATE [BedManagement].[DischargeType]
SET
    Name = @Name,
    DischargeCode = @DischargeCode,
    DischargeOrder = @DischargeOrder
WHERE [DischargeTypeId] = @OLDDischargeTypeId
IF @@ROWCOUNT > 0
Select * From BedManagement.DischargeType 
Where [DischargeTypeId] = @OLDDischargeTypeId
