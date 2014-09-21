CREATE PROCEDURE [dbo].[GetByIDProgramType]
    @ProgramTypeId int

AS
BEGIN
Select ProgramTypeId, ProgramTypeName
From [PGME].[ProgramType]

WHERE [ProgramTypeId] = @ProgramTypeId
END
