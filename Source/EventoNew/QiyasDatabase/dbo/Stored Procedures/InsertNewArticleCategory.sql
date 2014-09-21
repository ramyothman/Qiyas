CREATE PROCEDURE [dbo].[InsertNewArticleCategory]
    @ArticleCategoryId int output ,
    @SiteCategoryId int,
    @ArticleId int,
    @PostDate datetime
AS
INSERT INTO [ContentManagement].[ArticleCategory] (
    [SiteCategoryId],
    [ArticleId],
    [PostDate])
Values (
    @SiteCategoryId,
    @ArticleId,
    @PostDate)
Set @ArticleCategoryId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from ContentManagement.ArticleCategory
Where [ArticleCategoryId] = @@identity
