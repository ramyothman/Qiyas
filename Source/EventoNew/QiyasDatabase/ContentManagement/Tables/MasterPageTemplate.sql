CREATE TABLE [ContentManagement].[MasterPageTemplate] (
    [MasterPageTemplateId] INT            IDENTITY (1, 1) NOT NULL,
    [Name]                 NVARCHAR (50)  NULL,
    [Path]                 NVARCHAR (255) NULL,
    [ClassName]            NVARCHAR (50)  NULL,
    [MasterPageContent]    NVARCHAR (50)  NULL,
    CONSTRAINT [PK_MasterPageTemplate] PRIMARY KEY CLUSTERED ([MasterPageTemplateId] ASC)
);

