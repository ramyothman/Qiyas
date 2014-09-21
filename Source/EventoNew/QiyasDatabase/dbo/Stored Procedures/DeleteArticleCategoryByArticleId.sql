Create PROCEDURE [dbo].[DeleteArticleCategoryByArticleId]
    @ArticleId int

AS
Begin
 Delete [ContentManagement].[ArticleCategory] where    [ArticleId] = @ArticleId
End
