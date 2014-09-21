CREATE PROCEDURE [dbo].[GetByIDArticleCategory]
    @ArticleCategoryId int

AS
BEGIN
Select ArticleCategoryId, SiteCategoryId, ArticleId, PostDate
From [ContentManagement].[ArticleCategory]

WHERE [ArticleCategoryId] = @ArticleCategoryId
END
