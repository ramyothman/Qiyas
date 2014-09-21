CREATE TABLE [BedManagement].[WardSpeciality] (
    [WardSpecialityId] INT IDENTITY (1, 1) NOT NULL,
    [WardId]           INT NULL,
    [SpecialityId]     INT NULL,
    [IsMain]           BIT NULL,
    CONSTRAINT [PK_WardSpeciality] PRIMARY KEY CLUSTERED ([WardSpecialityId] ASC)
);

