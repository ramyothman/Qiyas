CREATE PROCEDURE [dbo].[DeleteAbstractAuthorsLanguage]
    @AbstractAuthorLanguageId int

AS
Begin
 Delete [Conference].[AbstractAuthorsLanguage] where     [AbstractAuthorLanguageId] = @AbstractAuthorLanguageId
End

