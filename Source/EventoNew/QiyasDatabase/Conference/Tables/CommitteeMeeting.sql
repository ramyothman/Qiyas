CREATE TABLE [Conference].[CommitteeMeeting] (
    [CommitteeMeetingId] INT           NOT NULL,
    [Title]              NVARCHAR (50) NULL,
    [Location]           NVARCHAR (50) NULL,
    [CommitteeDate]      DATETIME      NULL,
    CONSTRAINT [PK_CommitteeMeeting] PRIMARY KEY CLUSTERED ([CommitteeMeetingId] ASC)
);

