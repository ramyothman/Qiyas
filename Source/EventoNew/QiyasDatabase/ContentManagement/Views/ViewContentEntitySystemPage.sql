CREATE VIEW [ContentManagement].[ViewContentEntitySystemPage]
AS
SELECT     ContentManagement.ContentEntity.ContentEntityId, ContentManagement.ContentEntity.ContentEntityType, ContentManagement.ContentEntity.ModifiedDate, 
                      ContentManagement.ContentEntity.RowGuid, ContentManagement.SystemFolder.Name + '/' + ContentManagement.SystemPage.Name AS FullName, 
                      CASE WHEN [ContentManagement].[SystemFolder].[Path] IS NULL OR
                      ContentManagement.SystemFolder.Path = '' THEN ContentManagement.SystemPage.Path ELSE ContentManagement.SystemFolder.Path + '/' + ContentManagement.SystemPage.Path
                       END AS Path, ContentManagement.SystemPage.Name
FROM         ContentManagement.ContentEntity INNER JOIN
                      ContentManagement.SystemPage ON ContentManagement.ContentEntity.ContentEntityId = ContentManagement.SystemPage.SystemPageId INNER JOIN
                      ContentManagement.SystemFolder ON ContentManagement.SystemPage.SystemFolderId = ContentManagement.SystemFolder.SystemFolderId
