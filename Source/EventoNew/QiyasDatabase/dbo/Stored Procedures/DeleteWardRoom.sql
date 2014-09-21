CREATE PROCEDURE [dbo].[DeleteWardRoom]
    @WardRoomId int

AS
Begin
 Delete [BedManagement].[WardRoom] where     [WardRoomId] = @WardRoomId
End
