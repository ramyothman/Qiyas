CREATE PROCEDURE [dbo].[GetByIDWardRoomType]
    @WardRoomTypeId int

AS
BEGIN
Select WardRoomTypeId, WardRoomTypeName
From [BedManagement].[WardRoomType]

WHERE [WardRoomTypeId] = @WardRoomTypeId
END
