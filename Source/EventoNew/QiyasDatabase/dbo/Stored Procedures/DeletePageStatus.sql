CREATE PROCEDURE [dbo].[DeletePageStatus]
    @PageStatusId int

AS
Begin
 Delete [ContentManagement].[PageStatus] where     [PageStatusId] = @PageStatusId
End
