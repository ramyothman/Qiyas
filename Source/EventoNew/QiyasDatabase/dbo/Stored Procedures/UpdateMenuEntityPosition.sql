
CREATE PROCEDURE [dbo].[UpdateMenuEntityPosition]
    @MenuEntityPositionID int,
    @OldMenuEntityPositionID int,
    @Name nvarchar(50)
AS
UPDATE [ContentManagement].[MenuEntityPosition]
SET
    MenuEntityPositionID = @MenuEntityPositionID,
    Name = @Name
WHERE [MenuEntityPositionID] = @OLDMenuEntityPositionID
IF @@ROWCOUNT > 0
Select * From ContentManagement.MenuEntityPosition 
Where [MenuEntityPositionID] = @MenuEntityPositionID
