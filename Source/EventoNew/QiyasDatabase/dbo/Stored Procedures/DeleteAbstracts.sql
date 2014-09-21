CREATE PROCEDURE [dbo].[DeleteAbstracts]
    @AbstractId int

AS
Begin
 Delete [Conference].[Abstracts] where     [AbstractId] = @AbstractId
End

