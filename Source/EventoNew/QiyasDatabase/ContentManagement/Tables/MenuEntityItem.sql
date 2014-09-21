CREATE TABLE [ContentManagement].[MenuEntityItem] (
    [MenuEntityItemId]     INT            IDENTITY (1, 1) NOT NULL,
    [MenuEntityParentId]   INT            NULL,
    [Name]                 NVARCHAR (50)  NULL,
    [PagePath]             NVARCHAR (255) NULL,
    [ContentEntityId]      INT            NULL,
    [DisplayAlways]        BIT            NULL,
    [IsActive]             BIT            NULL,
    [IconPath]             NVARCHAR (255) NULL,
    [DisplayOrder]         INT            NULL,
    [ModifiedDate]         DATETIME       CONSTRAINT [DF_SiteMenu_ModifiedDate] DEFAULT (getdate()) NULL,
    [MenuEntityTypeId]     INT            NULL,
    [MenuEntityId]         INT            NULL,
    [LanguageID]           INT            NULL,
    [MenuEntityPositionID] INT            NULL,
    CONSTRAINT [PK_SiteMenu] PRIMARY KEY CLUSTERED ([MenuEntityItemId] ASC),
    CONSTRAINT [FK_MenuEntityItem_ContentEntity] FOREIGN KEY ([ContentEntityId]) REFERENCES [ContentManagement].[ContentEntity] ([ContentEntityId]),
    CONSTRAINT [FK_MenuEntityItem_MenuEntityType] FOREIGN KEY ([MenuEntityTypeId]) REFERENCES [ContentManagement].[MenuEntityType] ([MenuEntityTypeId]),
    CONSTRAINT [FK_SiteMenu_SiteMenu] FOREIGN KEY ([MenuEntityParentId]) REFERENCES [ContentManagement].[MenuEntityItem] ([MenuEntityItemId])
);

