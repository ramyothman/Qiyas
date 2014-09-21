CREATE TABLE [dbo].[QuickContact] (
    [QuickContactId] INT            IDENTITY (1, 1) NOT NULL,
    [Name]           VARCHAR (8000) NOT NULL,
    [Department]     VARCHAR (8000) NOT NULL,
    [Email]          VARCHAR (8000) NOT NULL,
    [OfficePhone]    VARCHAR (8000) NOT NULL,
    [Mobile]         VARCHAR (8000) NOT NULL,
    CONSTRAINT [PK_QuickContact] PRIMARY KEY CLUSTERED ([QuickContactId] ASC)
);

