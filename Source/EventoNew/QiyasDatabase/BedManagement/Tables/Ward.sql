CREATE TABLE [BedManagement].[Ward] (
    [WardId]          INT           IDENTITY (1, 1) NOT NULL,
    [WardCode]        NVARCHAR (8)  NULL,
    [WardDescription] NVARCHAR (50) NULL,
    [BedsNumber]      INT           NULL,
    [WardCapacity]    INT           NULL,
    [RoomsNumber]     INT           NULL,
    [WardType]        NVARCHAR (1)  NULL,
    [WardPhone]       NVARCHAR (14) NULL,
    [WardColor]       NVARCHAR (10) NULL,
    [WardOrder]       INT           NULL,
    CONSTRAINT [PK_Ward] PRIMARY KEY CLUSTERED ([WardId] ASC)
);

