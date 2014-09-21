CREATE PROCEDURE [dbo].[DeleteMenuEntityItem]
    @MenuEntityItemId int

AS
Begin
 Delete [ContentManagement].[MenuEntityItem] where     [MenuEntityItemId] = @MenuEntityItemId
End
