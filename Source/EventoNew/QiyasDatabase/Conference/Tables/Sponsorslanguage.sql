CREATE TABLE [Conference].[Sponsorslanguage] (
    [SponsorId]       INT            IDENTITY (1, 1) NOT NULL,
    [SponsorName]     NVARCHAR (50)  NULL,
    [ConferenceId]    INT            NULL,
    [SponsorType]     NVARCHAR (50)  NULL,
    [SponsorImage]    NVARCHAR (250) NULL,
    [LanguageID]      INT            NOT NULL,
    [SponsorParentID] INT            NOT NULL,
    CONSTRAINT [PK_SponsorsLanguage] PRIMARY KEY CLUSTERED ([SponsorId] ASC)
);

