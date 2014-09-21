CREATE PROCEDURE [dbo].[DeleteContentEntity]
    @ContentEntityId int

AS
Begin
 Delete [ContentManagement].[ContentEntity] where     [ContentEntityId] = @ContentEntityId
End
