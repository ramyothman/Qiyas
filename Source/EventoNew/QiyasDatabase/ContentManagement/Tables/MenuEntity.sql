CREATE TABLE [ContentManagement].[MenuEntity] (
    [MenuEntityId]    INT           IDENTITY (1, 1) NOT NULL,
    [MenuName]        NVARCHAR (50) NULL,
    [ContentEntityId] INT           NULL,
    [DisplayType]     CHAR (1)      NULL,
    [LevelDisplay]    INT           NULL,
    CONSTRAINT [PK_MenuEntity] PRIMARY KEY CLUSTERED ([MenuEntityId] ASC),
    CONSTRAINT [FK_MenuEntity_ContentEntity] FOREIGN KEY ([ContentEntityId]) REFERENCES [ContentManagement].[ContentEntity] ([ContentEntityId])
);

