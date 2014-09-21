CREATE PROCEDURE [dbo].[DeleteArticleTag]
    @ArticleTagId int

AS
Begin
 Delete [ContentManagement].[ArticleTag] where     [ArticleTagId] = @ArticleTagId
End
