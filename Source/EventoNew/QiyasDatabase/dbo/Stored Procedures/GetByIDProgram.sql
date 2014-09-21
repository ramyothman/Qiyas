CREATE PROCEDURE [dbo].[GetByIDProgram]
    @ProgramId int

AS
BEGIN
Select ProgramId, ProgramTypeId, DepartmentId, ProgramName, ProgramDescription
From [PGME].[Program]

WHERE [ProgramId] = @ProgramId
END
