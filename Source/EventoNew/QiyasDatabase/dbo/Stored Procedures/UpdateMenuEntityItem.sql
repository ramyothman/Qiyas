CREATE PROCEDURE [dbo].[UpdateMenuEntityItem]
    @OldMenuEntityItemId int,
    @MenuEntityParentId int,
    @Name nvarchar(50),
    @PagePath nvarchar(255),
    @ContentEntityId int,
    @DisplayAlways bit,
    @IsActive bit,
    @IconPath nvarchar(255),
    @DisplayOrder int,
    @ModifiedDate datetime,
    @MenuEntityTypeId int,
    @MenuEntityId int,
    @LanguageID int = null,
    @MenuEntityPositionID int = null
AS
UPDATE [ContentManagement].[MenuEntityItem]
SET
    MenuEntityParentId = @MenuEntityParentId,
    Name = @Name,
    PagePath = @PagePath,
    ContentEntityId = @ContentEntityId,
    DisplayAlways = @DisplayAlways,
    IsActive = @IsActive,
    IconPath = @IconPath,
    DisplayOrder = @DisplayOrder,
    ModifiedDate = @ModifiedDate,
    MenuEntityTypeId = @MenuEntityTypeId,
    MenuEntityId = @MenuEntityId,
    LanguageID = @LanguageID,
    MenuEntityPositionID = @MenuEntityPositionID
WHERE [MenuEntityItemId] = @OLDMenuEntityItemId
IF @@ROWCOUNT > 0
Select * From ContentManagement.MenuEntityItem 
Where [MenuEntityItemId] = @OLDMenuEntityItemId
