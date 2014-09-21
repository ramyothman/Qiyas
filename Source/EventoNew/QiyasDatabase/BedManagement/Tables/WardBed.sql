CREATE TABLE [BedManagement].[WardBed] (
    [WardBedId]           INT           IDENTITY (1, 1) NOT NULL,
    [WardRoomId]          INT           NULL,
    [BedNumber]           INT           NULL,
    [BedCode]             NVARCHAR (50) NULL,
    [BedStatus]           NVARCHAR (1)  NULL,
    [BedType]             NVARCHAR (50) NULL,
    [BedStatusPercentage] INT           NULL,
    [CurrentPatientCode]  NVARCHAR (8)  NULL,
    [SpecialityId]        INT           NULL,
    CONSTRAINT [PK_WardBed] PRIMARY KEY CLUSTERED ([WardBedId] ASC)
);

