CREATE PROCEDURE [dbo].[GetByIDArticleTag]
    @ArticleTagId int

AS
BEGIN
Select ArticleTagId, ArticleId, Name, LanguageId, PostDate
From [ContentManagement].[ArticleTag]

WHERE [ArticleTagId] = @ArticleTagId
END
