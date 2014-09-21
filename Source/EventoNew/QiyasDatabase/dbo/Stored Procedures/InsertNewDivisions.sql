CREATE PROCEDURE [dbo].[InsertNewDivisions]
    @DivisionId int output ,
    @DepartmentId int,
    @DivisionName nvarchar(50),
    @DivisionDescription nvarchar(50),
    @Phone1 nvarchar(20),
    @Phone2 nvarchar(20),
    @Fax1 nvarchar(20),
    @Fax2 nvarchar(20)
AS
INSERT INTO [HumanResources].[Divisions] (
    [DepartmentId],
    [DivisionName],
    [DivisionDescription],
    [Phone1],
    [Phone2],
    [Fax1],
    [Fax2])
Values (
    @DepartmentId,
    @DivisionName,
    @DivisionDescription,
    @Phone1,
    @Phone2,
    @Fax1,
    @Fax2)
Set @DivisionId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from HumanResources.Divisions
Where [DivisionId] = @@identity
