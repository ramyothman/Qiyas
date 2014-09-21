CREATE TABLE [Conference].[AbstractStatus] (
    [AbstractStatusId] INT           NOT NULL,
    [Name]             NVARCHAR (50) NULL,
    [NameAr]           NVARCHAR (50) NULL,
    CONSTRAINT [PK_AbstractStatus] PRIMARY KEY CLUSTERED ([AbstractStatusId] ASC)
);

