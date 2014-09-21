CREATE PROCEDURE [dbo].[UpdateMenuEntityType]
    @OldMenuEntityTypeId int,
    @Name nvarchar(50)
AS
UPDATE [ContentManagement].[MenuEntityType]
SET
    Name = @Name
WHERE [MenuEntityTypeId] = @OLDMenuEntityTypeId
IF @@ROWCOUNT > 0
Select * From ContentManagement.MenuEntityType 
Where [MenuEntityTypeId] = @OLDMenuEntityTypeId
