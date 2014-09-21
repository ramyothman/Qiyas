CREATE TABLE [Conference].[ConferenceHalls] (
    [ConferenceHallsId] INT            IDENTITY (1, 1) NOT NULL,
    [Name]              NVARCHAR (50)  NULL,
    [ConferenceId]      INT            NULL,
    [MapPath]           NVARCHAR (500) NULL,
    CONSTRAINT [PK_ConferenceHalls] PRIMARY KEY CLUSTERED ([ConferenceHallsId] ASC)
);

