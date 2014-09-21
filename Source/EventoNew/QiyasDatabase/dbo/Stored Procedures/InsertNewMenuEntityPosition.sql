
CREATE PROCEDURE [dbo].[InsertNewMenuEntityPosition]
    @MenuEntityPositionID int,
    @Name nvarchar(50)
AS
INSERT INTO [ContentManagement].[MenuEntityPosition] (
    [MenuEntityPositionID],
    [Name])
Values (
    @MenuEntityPositionID,
    @Name)

IF @@ROWCOUNT > 0
Select * from ContentManagement.MenuEntityPosition
Where [MenuEntityPositionID] = @MenuEntityPositionID
