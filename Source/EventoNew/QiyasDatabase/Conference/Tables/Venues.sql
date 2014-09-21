CREATE TABLE [Conference].[Venues] (
    [ID]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (50)  NULL,
    [Description] NVARCHAR (200) NULL,
    [Location]    NVARCHAR (50)  NULL,
    [Star]        INT            NULL,
    [URL]         NVARCHAR (100) NULL,
    [Phone]       NVARCHAR (50)  NULL,
    [Fax]         NVARCHAR (50)  NULL,
    [Email]       NVARCHAR (50)  NULL,
    CONSTRAINT [PK_Venues] PRIMARY KEY CLUSTERED ([ID] ASC)
);

