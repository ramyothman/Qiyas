CREATE PROCEDURE [dbo].[DeleteProgramType]
    @ProgramTypeId int

AS
Begin
 Delete [PGME].[ProgramType] where     [ProgramTypeId] = @ProgramTypeId
End
