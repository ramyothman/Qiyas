CREATE TABLE [BedManagement].[WardRoom] (
    [WardRoomId]     INT           IDENTITY (1, 1) NOT NULL,
    [WardId]         INT           NULL,
    [RoomColor]      NVARCHAR (10) NULL,
    [RoomNumber]     INT           NULL,
    [BedsNumber]     INT           NULL,
    [Capacity]       INT           NULL,
    [IsPrivate]      BIT           NULL,
    [RoomPhone]      NVARCHAR (14) NULL,
    [WardRoomTypeId] INT           NULL,
    [IsClosed]       BIT           NULL,
    CONSTRAINT [PK_WardRoom] PRIMARY KEY CLUSTERED ([WardRoomId] ASC)
);

