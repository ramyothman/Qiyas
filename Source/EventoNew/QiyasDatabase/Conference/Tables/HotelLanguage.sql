CREATE TABLE [Conference].[HotelLanguage] (
    [ID]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (50)  NULL,
    [Description] NVARCHAR (200) NULL,
    [Location]    NVARCHAR (50)  NULL,
    [Star]        INT            NULL,
    [URL]         NVARCHAR (100) NULL,
    [Phone]       NVARCHAR (50)  NULL,
    [Fax]         NVARCHAR (50)  NULL,
    [Email]       NVARCHAR (50)  NULL,
    [LanguageID]  INT            NOT NULL,
    [ParentID]    INT            NOT NULL,
    CONSTRAINT [PK_HotelLanguage] PRIMARY KEY CLUSTERED ([ID] ASC)
);

