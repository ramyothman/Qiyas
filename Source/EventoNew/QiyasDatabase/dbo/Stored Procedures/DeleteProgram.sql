CREATE PROCEDURE [dbo].[DeleteProgram]
    @ProgramId int

AS
Begin
 Delete [PGME].[Program] where     [ProgramId] = @ProgramId
End
