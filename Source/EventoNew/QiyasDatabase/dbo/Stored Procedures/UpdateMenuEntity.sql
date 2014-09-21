CREATE PROCEDURE [dbo].[UpdateMenuEntity]
    @OldMenuEntityId int,
    @MenuName nvarchar(50),
    @ContentEntityId int
AS
UPDATE [ContentManagement].[MenuEntity]
SET
    MenuName = @MenuName,
    ContentEntityId = @ContentEntityId
WHERE [MenuEntityId] = @OLDMenuEntityId
IF @@ROWCOUNT > 0
Select * From ContentManagement.MenuEntity 
Where [MenuEntityId] = @OLDMenuEntityId
