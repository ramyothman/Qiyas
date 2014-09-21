CREATE PROCEDURE [dbo].[DeleteSystemFolder]
    @SystemFolderId int

AS
Begin
 Delete [ContentManagement].[SystemFolder] where     [SystemFolderId] = @SystemFolderId
End
