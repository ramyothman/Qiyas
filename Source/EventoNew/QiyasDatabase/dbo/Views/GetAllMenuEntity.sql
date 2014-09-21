CREATE VIEW [dbo].[GetAllMenuEntity]
AS
SELECT     ContentManagement.MenuEntity.MenuEntityId, ContentManagement.MenuEntity.MenuName, ContentManagement.MenuEntity.ContentEntityId, 
                      ContentManagement.ContentEntity.ContentEntityType
FROM         ContentManagement.MenuEntity INNER JOIN
                      ContentManagement.ContentEntity ON ContentManagement.MenuEntity.ContentEntityId = ContentManagement.ContentEntity.ContentEntityId
