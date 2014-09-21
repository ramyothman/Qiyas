CREATE TABLE [ContentManagement].[ContentEntityModuleType] (
    [ContentEntityModuleTypeId] INT           IDENTITY (1, 1) NOT NULL,
    [Name]                      NVARCHAR (50) NULL,
    CONSTRAINT [PK_ContentEntityModuleType] PRIMARY KEY CLUSTERED ([ContentEntityModuleTypeId] ASC)
);

