CREATE TABLE [Organization].[Speciality] (
    [SpecialityId]   INT            IDENTITY (1, 1) NOT NULL,
    [SpecialityCode] NVARCHAR (8)   NULL,
    [SpecialityName] NVARCHAR (150) NULL,
    [BedDisplayCode] NVARCHAR (50)  NULL,
    CONSTRAINT [PK_Speciality] PRIMARY KEY CLUSTERED ([SpecialityId] ASC)
);

