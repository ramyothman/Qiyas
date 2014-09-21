CREATE PROCEDURE [dbo].[InsertNewMenuEntityItem]
    @MenuEntityItemId int output ,
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
INSERT INTO [ContentManagement].[MenuEntityItem] (
    [MenuEntityParentId],
    [Name],
    [PagePath],
    [ContentEntityId],
    [DisplayAlways],
    [IsActive],
    [IconPath],
    [DisplayOrder],
    [ModifiedDate],
    [MenuEntityTypeId],
    [MenuEntityId],
    LanguageID,
    MenuEntityPositionID)
Values (
    @MenuEntityParentId,
    @Name,
    @PagePath,
    @ContentEntityId,
    @DisplayAlways,
    @IsActive,
    @IconPath,
    @DisplayOrder,
    @ModifiedDate,
    @MenuEntityTypeId,
    @MenuEntityId,
    @LanguageID,
    @MenuEntityPositionID)
Set @MenuEntityItemId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from ContentManagement.MenuEntityItem
Where [MenuEntityItemId] = @@identity
