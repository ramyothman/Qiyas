CREATE PROCEDURE [dbo].[GetByIDArticleLanguage]
    @ArticleLanguageId int

AS
BEGIN
Select ArticleLanguageId, ArticleId, LanguageId, ArticleName, ArticleContent, ArticleAttachment, AuthorAlias, ArticleAlias, PostDate, PublishStartDate, PublishEndDate, RevisionDate, ModifiedDate,ArticleSummary
From [ContentManagement].[ArticleLanguage]

WHERE [ArticleLanguageId] = @ArticleLanguageId
END
