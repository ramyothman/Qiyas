CREATE PROCEDURE [dbo].[DeleteWard]
    @WardId int

AS
Begin
 Delete [BedManagement].[Ward] where     [WardId] = @WardId
End
