CREATE VIEW dbo.GetAllArticle
AS
SELECT        ContentManagement.Article.ArticleId, ContentManagement.Article.SiteSectionId, ContentManagement.Article.CreatorId, ContentManagement.Article.ArticleStatusId, 
                         ContentManagement.Article.AuthorId, ContentManagement.Article.PostDate, ContentManagement.Article.AllowLanguageSpecificTags, 
                         ContentManagement.Article.RowGuid, ContentManagement.Article.ModifiedDate, ContentManagement.Article.CommentsTypeId, 
                         ContentManagement.Article.EnableModeteration, ContentManagement.SiteSection.SiteId
FROM            ContentManagement.Article INNER JOIN
                         ContentManagement.SiteSection ON ContentManagement.Article.SiteSectionId = ContentManagement.SiteSection.SiteSectionId
