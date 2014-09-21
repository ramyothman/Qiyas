CREATE PROCEDURE [dbo].[UpdateDivisions]
    @OldDivisionId int,
    @DepartmentId int,
    @DivisionName nvarchar(50),
    @DivisionDescription nvarchar(50),
    @Phone1 nvarchar(20),
    @Phone2 nvarchar(20),
    @Fax1 nvarchar(20),
    @Fax2 nvarchar(20)
AS
UPDATE [HumanResources].[Divisions]
SET
    DepartmentId = @DepartmentId,
    DivisionName = @DivisionName,
    DivisionDescription = @DivisionDescription,
    Phone1 = @Phone1,
    Phone2 = @Phone2,
    Fax1 = @Fax1,
    Fax2 = @Fax2
WHERE [DivisionId] = @OLDDivisionId
IF @@ROWCOUNT > 0
Select * From HumanResources.Divisions 
Where [DivisionId] = @OLDDivisionId
