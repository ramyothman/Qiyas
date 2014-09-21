CREATE VIEW [ContentManagement].[ViewContentEntitySectionFiles]
AS
SELECT     ContentManagement.ContentEntity.ContentEntityId, ContentManagement.ContentEntity.ContentEntityType, ContentManagement.ContentEntity.RowGuid, 
                      ContentManagement.ContentEntity.ModifiedDate, ContentManagement.SectionFiles.SectionFileName AS Name, 
                      ContentManagement.Site.Name + '/' + ContentManagement.SiteSection.Name + '/' + ContentManagement.SectionFiles.SectionFileName AS FullName, 
                      'ContentType=' + ContentManagement.ContentEntity.ContentEntityType + '&ContentCode=' + CAST(ContentManagement.SectionFiles.SectionFileId AS nvarchar(50)) 
                      AS Path
FROM         ContentManagement.ContentEntity INNER JOIN
                      ContentManagement.SectionFiles ON ContentManagement.ContentEntity.ContentEntityId = ContentManagement.SectionFiles.SectionFileId INNER JOIN
                      ContentManagement.SiteSection ON ContentManagement.SectionFiles.SectionId = ContentManagement.SiteSection.SiteSectionId INNER JOIN
                      ContentManagement.Site ON ContentManagement.SiteSection.SiteId = ContentManagement.Site.SiteId
