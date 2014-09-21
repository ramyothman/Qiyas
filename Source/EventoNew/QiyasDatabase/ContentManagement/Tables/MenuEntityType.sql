CREATE TABLE [ContentManagement].[MenuEntityType] (
    [MenuEntityTypeId] INT           IDENTITY (1, 1) NOT NULL,
    [Name]             NVARCHAR (50) NULL,
    CONSTRAINT [PK_MenuEntityType] PRIMARY KEY CLUSTERED ([MenuEntityTypeId] ASC)
);

