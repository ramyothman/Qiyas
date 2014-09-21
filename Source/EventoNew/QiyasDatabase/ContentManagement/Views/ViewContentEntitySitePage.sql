CREATE VIEW [ContentManagement].[ViewContentEntitySitePage]
AS
SELECT     ContentManagement.ContentEntity.ContentEntityId, ContentManagement.ContentEntity.RowGuid, ContentManagement.ContentEntity.ContentEntityType, 
                      ContentManagement.ContentEntity.ModifiedDate, ContentManagement.SitePageLanguage.PageName AS Name, 
                      'ContentType=' + ContentManagement.ContentEntity.ContentEntityType + '&ContentCode=' + CAST(ContentManagement.SitePage.SitePageId AS nvarchar(50)) AS Path, 
                      ContentManagement.Site.Name + '/' + ContentManagement.SiteSection.Name + '/' + ContentManagement.SitePageLanguage.PageName AS FullName
FROM         ContentManagement.ContentEntity INNER JOIN
                      ContentManagement.SitePage ON ContentManagement.ContentEntity.ContentEntityId = ContentManagement.SitePage.SitePageId INNER JOIN
                      ContentManagement.SitePageLanguage ON ContentManagement.SitePage.SitePageId = ContentManagement.SitePageLanguage.SitePageId INNER JOIN
                      ContentManagement.SiteSection ON ContentManagement.SitePage.SectionId = ContentManagement.SiteSection.SiteSectionId INNER JOIN
                      ContentManagement.Site ON ContentManagement.SiteSection.SiteId = ContentManagement.Site.SiteId
WHERE     (ContentManagement.SitePageLanguage.LanguageId = 1)
