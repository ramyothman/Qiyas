CREATE PROCEDURE [dbo].[DeleteConferenceProgramsLanguage]
    @ConferenceProgramId int

AS
Begin
 Delete [Conference].[ConferenceProgramsLanguage] where     [ConferenceProgramId] = @ConferenceProgramId
End
