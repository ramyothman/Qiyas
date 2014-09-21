CREATE TABLE [BedManagement].[WardRoomType] (
    [WardRoomTypeId]   INT            IDENTITY (1, 1) NOT NULL,
    [WardRoomTypeName] NVARCHAR (150) NULL,
    CONSTRAINT [PK_WardRoomType] PRIMARY KEY CLUSTERED ([WardRoomTypeId] ASC)
);

