CREATE PROCEDURE [dbo].[DeleteSystemPage]
    @SystemPageId int

AS
Begin
 Delete [ContentManagement].[SystemPage] where     [SystemPageId] = @SystemPageId
End
