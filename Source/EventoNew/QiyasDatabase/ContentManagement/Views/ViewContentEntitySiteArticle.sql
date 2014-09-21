CREATE VIEW [ContentManagement].[ViewContentEntitySiteArticle]
AS
SELECT     ContentManagement.ContentEntity.ContentEntityId, ContentManagement.ContentEntity.RowGuid, ContentManagement.ContentEntity.ModifiedDate, 
                      ContentManagement.ContentEntity.ContentEntityType, ContentManagement.ArticleLanguage.ArticleName AS Name, 
                      ContentManagement.Site.Name + '/' + ContentManagement.SiteSection.Name + '/' + ContentManagement.ArticleLanguage.ArticleName AS FullName, 
                      'ContentType=' + ContentManagement.ContentEntity.ContentEntityType + '&ContentCode=' + CAST(ContentManagement.Article.ArticleId AS nvarchar(50)) AS Path
FROM         ContentManagement.ContentEntity INNER JOIN
                      ContentManagement.Article ON ContentManagement.ContentEntity.ContentEntityId = ContentManagement.Article.ArticleId INNER JOIN
                      ContentManagement.ArticleLanguage ON ContentManagement.Article.ArticleId = ContentManagement.ArticleLanguage.ArticleId INNER JOIN
                      ContentManagement.SiteSection ON ContentManagement.Article.SiteSectionId = ContentManagement.SiteSection.SiteSectionId INNER JOIN
                      ContentManagement.Site ON ContentManagement.SiteSection.SiteId = ContentManagement.Site.SiteId
WHERE     (ContentManagement.ArticleLanguage.LanguageId = 1)
