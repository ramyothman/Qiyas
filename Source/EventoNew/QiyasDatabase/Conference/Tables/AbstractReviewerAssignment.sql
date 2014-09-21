CREATE TABLE [Conference].[AbstractReviewerAssignment] (
    [AbstractReviewerAssignmentId] INT      IDENTITY (1, 1) NOT NULL,
    [AbstractReviewerId]           INT      NULL,
    [AbstractId]                   INT      NULL,
    [HasAcceptedReview]            BIT      NULL,
    [DateAssigned]                 DATETIME NULL,
    [DateAccepted]                 DATETIME NULL,
    CONSTRAINT [PK_AbstractReviewerAssignment] PRIMARY KEY CLUSTERED ([AbstractReviewerAssignmentId] ASC),
    CONSTRAINT [FK_AbstractReviewerAssignment_AbstractReviewer] FOREIGN KEY ([AbstractReviewerId]) REFERENCES [Conference].[AbstractReviewer] ([AbstractReviewerId]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_AbstractReviewerAssignment_Abstracts] FOREIGN KEY ([AbstractId]) REFERENCES [Conference].[Abstracts] ([AbstractId]) ON DELETE CASCADE ON UPDATE CASCADE
);

