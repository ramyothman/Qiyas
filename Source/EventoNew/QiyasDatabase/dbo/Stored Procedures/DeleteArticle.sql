CREATE PROCEDURE [dbo].[DeleteArticle]
    @ArticleId int

AS
Begin
 Delete [ContentManagement].[Article] where     [ArticleId] = @ArticleId
End
