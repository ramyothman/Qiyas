CREATE TABLE [Conference].[ConferenceCategoryLanguage] (
    [ConferenceCategoryId]       INT           IDENTITY (1, 1) NOT NULL,
    [CategoryName]               NVARCHAR (50) NULL,
    [ConferenceId]               INT           NULL,
    [LanguageID]                 INT           NOT NULL,
    [ConferenceCategoryParentID] INT           NOT NULL,
    CONSTRAINT [PK_ConferenceCategoryLAnguage] PRIMARY KEY CLUSTERED ([ConferenceCategoryId] ASC)
);

