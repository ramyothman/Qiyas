CREATE PROCEDURE [dbo].[UpdateProgram]
    @OldProgramId int,
    @ProgramTypeId int,
    @DepartmentId int,
    @ProgramName nvarchar(150),
    @ProgramDescription ntext
AS
UPDATE [PGME].[Program]
SET
    ProgramTypeId = @ProgramTypeId,
    DepartmentId = @DepartmentId,
    ProgramName = @ProgramName,
    ProgramDescription = @ProgramDescription
WHERE [ProgramId] = @OLDProgramId
IF @@ROWCOUNT > 0
Select * From PGME.Program 
Where [ProgramId] = @OLDProgramId
