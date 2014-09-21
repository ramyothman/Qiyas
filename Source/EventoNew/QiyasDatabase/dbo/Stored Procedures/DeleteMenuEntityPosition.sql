
CREATE PROCEDURE [dbo].[DeleteMenuEntityPosition]
    @MenuEntityPositionID int

AS
Begin
 Delete [ContentManagement].[MenuEntityPosition] where     [MenuEntityPositionID] = @MenuEntityPositionID
End
