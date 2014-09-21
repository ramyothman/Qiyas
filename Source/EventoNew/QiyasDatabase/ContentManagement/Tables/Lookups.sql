CREATE TABLE [ContentManagement].[Lookups] (
    [LookupId]           INT           IDENTITY (1, 1) NOT NULL,
    [LookupName]         NVARCHAR (50) NULL,
    [LookupFriendlyName] NVARCHAR (50) NULL,
    CONSTRAINT [PK_Lookups] PRIMARY KEY CLUSTERED ([LookupId] ASC)
);

