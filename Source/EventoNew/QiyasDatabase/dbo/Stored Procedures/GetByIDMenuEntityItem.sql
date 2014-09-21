CREATE PROCEDURE [dbo].[GetByIDMenuEntityItem]
    @MenuEntityItemId int

AS
BEGIN
Select MenuEntityItemId, MenuEntityParentId, Name, PagePath, ContentEntityId, DisplayAlways, IsActive, IconPath, DisplayOrder, ModifiedDate, MenuEntityTypeId, MenuEntityId,LanguageID,MenuEntityPositionID
From [ContentManagement].[MenuEntityItem]

WHERE [MenuEntityItemId] = @MenuEntityItemId
END
