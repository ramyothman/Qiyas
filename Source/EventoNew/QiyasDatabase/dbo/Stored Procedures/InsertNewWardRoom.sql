CREATE PROCEDURE [dbo].[InsertNewWardRoom]
    @WardRoomId int output ,
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
INSERT INTO [BedManagement].[WardRoom] (
    [WardId],
    [RoomColor],
    [RoomNumber],
    [BedsNumber],
    [Capacity],
    [IsPrivate],
    [RoomPhone],
    [WardRoomTypeId],
    [IsClosed])
Values (
    @WardId,
    @RoomColor,
    @RoomNumber,
    @BedsNumber,
    @Capacity,
    @IsPrivate,
    @RoomPhone,
    @WardRoomTypeId,
    @IsClosed)
Set @WardRoomId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from BedManagement.WardRoom
Where [WardRoomId] = @@identity
