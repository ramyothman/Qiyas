CREATE TABLE [ContentManagement].[LookupLanguages] (
    [LookupLanguageId]       INT           IDENTITY (1, 1) NOT NULL,
    [LookupId]               INT           NULL,
    [LanguageId]             INT           NULL,
    [RefId]                  INT           NULL,
    [LookupValue]            NVARCHAR (50) NULL,
    [LookupValueDescription] NVARCHAR (50) NULL,
    CONSTRAINT [PK_LookupLanguages] PRIMARY KEY CLUSTERED ([LookupLanguageId] ASC),
    CONSTRAINT [FK_LookupLanguages_Lookups] FOREIGN KEY ([LookupId]) REFERENCES [ContentManagement].[Lookups] ([LookupId]) ON DELETE CASCADE ON UPDATE CASCADE
);

