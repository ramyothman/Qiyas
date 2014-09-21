CREATE PROCEDURE [dbo].[DeleteWardRoomType]
    @WardRoomTypeId int

AS
Begin
 Delete [BedManagement].[WardRoomType] where     [WardRoomTypeId] = @WardRoomTypeId
End
