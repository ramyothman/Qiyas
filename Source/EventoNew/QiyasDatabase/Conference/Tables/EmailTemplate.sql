CREATE TABLE [Conference].[EmailTemplate] (
    [EmailTemplateID]   INT           IDENTITY (1, 1) NOT NULL,
    [SystemEmailTypeID] INT           NULL,
    [ConferenceID]      INT           NULL,
    [LanguageID]        INT           NULL,
    [Name]              NVARCHAR (50) NULL,
    [Description]       NCHAR (10)    NULL,
    [EmailContent]      NTEXT         NULL,
    CONSTRAINT [PK_EmailTemplate] PRIMARY KEY CLUSTERED ([EmailTemplateID] ASC)
);

