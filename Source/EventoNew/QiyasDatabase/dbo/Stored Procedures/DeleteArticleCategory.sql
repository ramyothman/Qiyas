CREATE PROCEDURE [dbo].[DeleteArticleCategory]
    @ArticleCategoryId int

AS
Begin
 Delete [ContentManagement].[ArticleCategory] where     [ArticleCategoryId] = @ArticleCategoryId
End
