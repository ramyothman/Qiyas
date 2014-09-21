CREATE PROCEDURE [dbo].[InsertNewDischargeType]
    @DischargeTypeId int output ,
    @Name nvarchar(250),
    @DischargeCode nvarchar(5),
    @DischargeOrder int
AS
INSERT INTO [BedManagement].[DischargeType] (
    [Name],
    [DischargeCode],
    [DischargeOrder])
Values (
    @Name,
    @DischargeCode,
    @DischargeOrder)
Set @DischargeTypeId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from BedManagement.DischargeType
Where [DischargeTypeId] = @@identity
