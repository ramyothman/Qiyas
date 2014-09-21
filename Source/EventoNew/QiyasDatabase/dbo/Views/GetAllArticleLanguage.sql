CREATE VIEW dbo.GetAllArticleLanguage
AS
SELECT        ArticleLanguageId, ArticleId, LanguageId, ArticleName, ArticleContent, ArticleAttachment, AuthorAlias, ArticleAlias, PostDate, PublishStartDate, PublishEndDate, 
                         RevisionDate, ModifiedDate, ArticleSummary
FROM            ContentManagement.ArticleLanguage
