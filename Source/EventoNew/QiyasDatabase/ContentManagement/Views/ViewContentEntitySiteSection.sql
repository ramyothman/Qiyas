CREATE VIEW [ContentManagement].[ViewContentEntitySiteSection]
AS
SELECT     ContentManagement.ContentEntity.ContentEntityId, ContentManagement.ContentEntity.ContentEntityType, ContentManagement.ContentEntity.RowGuid, 
                      ContentManagement.ContentEntity.ModifiedDate, ContentManagement.SiteSection.Name, 
                      ContentManagement.Site.Name + '/' + ContentManagement.SiteSection.Name AS FullName, 
                      'ContentType=' + ContentManagement.ContentEntity.ContentEntityType + '&ContentCode=' + CAST(ContentManagement.SiteSection.SiteSectionId AS nvarchar(50)) 
                      AS Path
FROM         ContentManagement.ContentEntity INNER JOIN
                      ContentManagement.SiteSection ON ContentManagement.ContentEntity.ContentEntityId = ContentManagement.SiteSection.SiteSectionId INNER JOIN
                      ContentManagement.Site ON ContentManagement.SiteSection.SiteId = ContentManagement.Site.SiteId
