CREATE TABLE [ContentManagement].[PageStatus] (
    [PageStatusId] INT              IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (50)    NULL,
    [RowGuid]      UNIQUEIDENTIFIER CONSTRAINT [DF_PageStatus_RowGuid] DEFAULT (newid()) ROWGUIDCOL NULL,
    [ModifiedDate] DATETIME         CONSTRAINT [DF_PageStatus_ModifiedDate] DEFAULT (getdate()) NULL,
    CONSTRAINT [PK_PageStatus] PRIMARY KEY CLUSTERED ([PageStatusId] ASC)
);

