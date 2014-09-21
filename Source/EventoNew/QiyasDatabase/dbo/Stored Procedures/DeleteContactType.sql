CREATE PROCEDURE [dbo].[DeleteContactType]
    @ContactTypeId int

AS
Begin
 Delete [Person].[ContactType] where     [ContactTypeId] = @ContactTypeId
End
