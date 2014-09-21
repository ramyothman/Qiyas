CREATE PROCEDURE [dbo].[DeleteMenuEntity]
    @MenuEntityId int

AS
Begin
 Delete [ContentManagement].[MenuEntity] where     [MenuEntityId] = @MenuEntityId
End
