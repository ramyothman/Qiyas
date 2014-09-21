CREATE PROCEDURE [dbo].[DeleteAbstractAuthors]
    @AbstractAuthorId int

AS
Begin
 Delete [Conference].[AbstractAuthors] where     [AbstractAuthorId] = @AbstractAuthorId
End

