CREATE VIEW [ContentManagement].[ViewContentEntitySite]
AS
SELECT     ContentManagement.ContentEntity.ContentEntityId, ContentManagement.ContentEntity.ContentEntityType, ContentManagement.ContentEntity.RowGuid, 
                      ContentManagement.ContentEntity.ModifiedDate, ContentManagement.Site.Name, ContentManagement.Site.Name AS FullName, 
                      'ContentType=' + ContentManagement.ContentEntity.ContentEntityType + '&ContentCode=' + CAST(ContentManagement.Site.SiteId AS nvarchar(50)) AS Path
FROM         ContentManagement.ContentEntity INNER JOIN
                      ContentManagement.Site ON ContentManagement.ContentEntity.ContentEntityId = ContentManagement.Site.SiteId
