CREATE TABLE [Conference].[CommitteeAbstract] (
    [CommitteeAbstractId] INT      NOT NULL,
    [CommitteeMeetingId]  INT      NULL,
    [AbstractId]          INT      NULL,
    [AbstractStatusId]    INT      NULL,
    [Feedback]            NTEXT    NULL,
    [DateCreated]         DATETIME NULL,
    CONSTRAINT [PK_CommitteeAbstract] PRIMARY KEY CLUSTERED ([CommitteeAbstractId] ASC)
);

