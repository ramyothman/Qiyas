CREATE TABLE [ContentManagement].[ContentEntityPosition] (
    [ContentEntityPositionId] INT           IDENTITY (1, 1) NOT NULL,
    [Name]                    NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_ContentEntityPosition] PRIMARY KEY CLUSTERED ([ContentEntityPositionId] ASC)
);

