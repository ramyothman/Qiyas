CREATE PROCEDURE [dbo].[UpdateArticleCategory]
    @OldArticleCategoryId int,
    @SiteCategoryId int,
    @ArticleId int,
    @PostDate datetime
AS
UPDATE [ContentManagement].[ArticleCategory]
SET
    SiteCategoryId = @SiteCategoryId,
    ArticleId = @ArticleId,
    PostDate = @PostDate
WHERE [ArticleCategoryId] = @OLDArticleCategoryId
IF @@ROWCOUNT > 0
Select * From ContentManagement.ArticleCategory 
Where [ArticleCategoryId] = @OLDArticleCategoryId
