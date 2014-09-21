CREATE PROCEDURE [dbo].[GetByIDWardRoom]
    @WardRoomId int

AS
BEGIN
Select WardRoomId, WardId, RoomColor, RoomNumber, BedsNumber, Capacity, IsPrivate, RoomPhone, WardRoomTypeId, IsClosed
From [BedManagement].[WardRoom]

WHERE [WardRoomId] = @WardRoomId
END
