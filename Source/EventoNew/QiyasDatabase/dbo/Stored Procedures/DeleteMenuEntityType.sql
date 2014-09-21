CREATE PROCEDURE [dbo].[DeleteMenuEntityType]
    @MenuEntityTypeId int

AS
Begin
 Delete [ContentManagement].[MenuEntityType] where     [MenuEntityTypeId] = @MenuEntityTypeId
End
