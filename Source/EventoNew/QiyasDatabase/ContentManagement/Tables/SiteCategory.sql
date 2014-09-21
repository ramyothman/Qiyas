CREATE TABLE [ContentManagement].[SiteCategory] (
    [SiteCategoryId] INT              IDENTITY (1, 1) NOT NULL,
    [Name]           NVARCHAR (50)    NULL,
    [RowGuid]        UNIQUEIDENTIFIER CONSTRAINT [DF_SiteCategory_RowGuid] DEFAULT (newid()) NULL,
    [ModifiedDate]   DATETIME         CONSTRAINT [DF_SiteCategory_ModifiedDate] DEFAULT (getdate()) NULL,
    CONSTRAINT [PK_SiteCategory] PRIMARY KEY CLUSTERED ([SiteCategoryId] ASC)
);

