CREATE TABLE [Conference].[Sponsors] (
    [SponsorId]    INT            IDENTITY (1, 1) NOT NULL,
    [SponsorName]  NVARCHAR (50)  NULL,
    [ConferenceId] INT            NULL,
    [SponsorType]  NVARCHAR (50)  NULL,
    [SponsorImage] NVARCHAR (250) NULL,
    CONSTRAINT [PK_Sponsors] PRIMARY KEY CLUSTERED ([SponsorId] ASC)
);

