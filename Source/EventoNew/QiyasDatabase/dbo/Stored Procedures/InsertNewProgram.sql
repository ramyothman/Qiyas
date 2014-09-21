CREATE PROCEDURE [dbo].[InsertNewProgram]
    @ProgramId int output ,
    @ProgramTypeId int,
    @DepartmentId int,
    @ProgramName nvarchar(150),
    @ProgramDescription ntext
AS
INSERT INTO [PGME].[Program] (
    [ProgramTypeId],
    [DepartmentId],
    [ProgramName],
    [ProgramDescription])
Values (
    @ProgramTypeId,
    @DepartmentId,
    @ProgramName,
    @ProgramDescription)
Set @ProgramId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from PGME.Program
Where [ProgramId] = @@identity
