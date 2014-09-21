CREATE TABLE [Conference].[Hotel] (
    [ID]           INT            IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (50)  NULL,
    [Description]  NTEXT          NULL,
    [Location]     NVARCHAR (50)  NULL,
    [Star]         INT            NULL,
    [URL]          NVARCHAR (100) NULL,
    [Phone]        NVARCHAR (50)  NULL,
    [Fax]          NVARCHAR (50)  NULL,
    [Email]        NVARCHAR (50)  NULL,
    [ConferenceID] INT            NULL,
    CONSTRAINT [PK_Hotel] PRIMARY KEY CLUSTERED ([ID] ASC)
);

