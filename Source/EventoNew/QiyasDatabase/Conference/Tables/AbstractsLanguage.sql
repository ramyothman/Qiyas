CREATE TABLE [Conference].[AbstractsLanguage] (
    [AbstractLanguageId] INT            IDENTITY (1, 1) NOT NULL,
    [AbstractId]         INT            NULL,
    [AbstractTitle]      NVARCHAR (500) NULL,
    [AbstractIntro]      NTEXT          NULL,
    [CoverLetter]        NTEXT          NULL,
    [Topic]              NVARCHAR (250) NULL,
    [Background]         NTEXT          NULL,
    [Methods]            NTEXT          NULL,
    [Results]            NTEXT          NULL,
    [Conclusions]        NTEXT          NULL,
    [AbstractTerms]      NTEXT          NULL,
    [AbstractKeywords]   NVARCHAR (500) NULL,
    [LanguageID]         INT            NOT NULL,
    CONSTRAINT [PK_AbstractsLanguage] PRIMARY KEY CLUSTERED ([AbstractLanguageId] ASC),
    CONSTRAINT [FK_AbstractsLanguage_Abstracts] FOREIGN KEY ([AbstractId]) REFERENCES [Conference].[Abstracts] ([AbstractId]) ON DELETE CASCADE ON UPDATE CASCADE
);

