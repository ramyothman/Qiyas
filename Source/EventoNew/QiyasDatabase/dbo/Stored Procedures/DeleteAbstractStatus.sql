CREATE PROCEDURE [dbo].[DeleteAbstractStatus]
    @AbstractStatusId int

AS
Begin
 Delete [Conference].[AbstractStatus] where     [AbstractStatusId] = @AbstractStatusId
End

