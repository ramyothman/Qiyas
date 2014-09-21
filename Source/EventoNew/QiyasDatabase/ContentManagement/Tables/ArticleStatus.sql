CREATE TABLE [ContentManagement].[ArticleStatus] (
    [ArticleStatusId] INT              IDENTITY (1, 1) NOT NULL,
    [Name]            NVARCHAR (50)    NULL,
    [RowGuid]         UNIQUEIDENTIFIER CONSTRAINT [DF_ArticleStatus_RowGuid] DEFAULT (newid()) ROWGUIDCOL NULL,
    [ModifiedDate]    DATETIME         CONSTRAINT [DF_ArticleStatus_ModifiedDate] DEFAULT (getdate()) NULL,
    CONSTRAINT [PK_ArticleStatus] PRIMARY KEY CLUSTERED ([ArticleStatusId] ASC)
);

