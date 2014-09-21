CREATE VIEW [ContentManagement].[ViewContentEntitySystemFolder]
AS
SELECT     ContentManagement.ContentEntity.ContentEntityId, ContentManagement.ContentEntity.ContentEntityType, ContentManagement.ContentEntity.RowGuid, 
                      ContentManagement.ContentEntity.ModifiedDate, ContentManagement.SystemFolder.Name, ContentManagement.SystemFolder.Name AS FullName, 
                      ContentManagement.SystemFolder.Path
FROM         ContentManagement.ContentEntity INNER JOIN
                      ContentManagement.SystemFolder ON ContentManagement.ContentEntity.ContentEntityId = ContentManagement.SystemFolder.SystemFolderId
