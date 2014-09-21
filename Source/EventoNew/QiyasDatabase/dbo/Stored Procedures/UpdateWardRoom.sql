CREATE PROCEDURE [dbo].[UpdateWardRoom]
    @OldWardRoomId int,
    @WardId int,
    @RoomColor nvarchar(10),
    @RoomNumber int,
    @BedsNumber int,
    @Capacity int,
    @IsPrivate bit,
    @RoomPhone nvarchar(14),
    @WardRoomTypeId int,
    @IsClosed bit
AS
UPDATE [BedManagement].[WardRoom]
SET
    WardId = @WardId,
    RoomColor = @RoomColor,
    RoomNumber = @RoomNumber,
    BedsNumber = @BedsNumber,
    Capacity = @Capacity,
    IsPrivate = @IsPrivate,
    RoomPhone = @RoomPhone,
    WardRoomTypeId = @WardRoomTypeId,
    IsClosed = @IsClosed
WHERE [WardRoomId] = @OLDWardRoomId
IF @@ROWCOUNT > 0
Select * From BedManagement.WardRoom 
Where [WardRoomId] = @OLDWardRoomId
