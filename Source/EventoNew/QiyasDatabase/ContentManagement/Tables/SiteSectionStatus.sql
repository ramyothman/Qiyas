CREATE TABLE [ContentManagement].[SiteSectionStatus] (
    [SiteSectionStatusId] INT              IDENTITY (1, 1) NOT NULL,
    [Name]                NVARCHAR (50)    NULL,
    [RowGuid]             UNIQUEIDENTIFIER CONSTRAINT [DF_SiteSectionStatus_RowGuid] DEFAULT (newid()) NULL,
    [ModifiedDate]        DATETIME         CONSTRAINT [DF_SiteSectionStatus_ModifiedDate] DEFAULT (getdate()) NULL,
    CONSTRAINT [PK_SiteSectionStatus] PRIMARY KEY CLUSTERED ([SiteSectionStatusId] ASC)
);

