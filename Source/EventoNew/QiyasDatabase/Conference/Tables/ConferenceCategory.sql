CREATE TABLE [Conference].[ConferenceCategory] (
    [ConferenceCategoryId] INT           IDENTITY (1, 1) NOT NULL,
    [CategoryName]         NVARCHAR (50) NULL,
    [ConferenceId]         INT           NULL,
    CONSTRAINT [PK_ConferenceCategory] PRIMARY KEY CLUSTERED ([ConferenceCategoryId] ASC)
);

