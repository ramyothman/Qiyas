CREATE TABLE [Organization].[ResearchChairLanguages] (
    [ResearchChairLanguagesId] INT            IDENTITY (1, 1) NOT NULL,
    [ResearchChairId]          INT            NULL,
    [LanguageId]               INT            NULL,
    [Name]                     NVARCHAR (50)  NULL,
    [Description]              NVARCHAR (250) NULL,
    CONSTRAINT [PK_ResearchChairLanguages] PRIMARY KEY CLUSTERED ([ResearchChairLanguagesId] ASC),
    CONSTRAINT [FK_ResearchChairLanguages_Language] FOREIGN KEY ([LanguageId]) REFERENCES [ContentManagement].[Language] ([LanguageId]),
    CONSTRAINT [FK_ResearchChairLanguages_ResearchChairs] FOREIGN KEY ([ResearchChairId]) REFERENCES [Organization].[ResearchChairs] ([ResearchChairId]) ON DELETE CASCADE ON UPDATE CASCADE
);

