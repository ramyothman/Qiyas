CREATE TABLE [Conference].[AbstractReview] (
    [AbstractReviewId]             INT      NOT NULL,
    [AbstractReviewerAssignmentId] INT      NULL,
    [AbstractStatusId]             INT      NULL,
    [ReviewerFeedback]             NTEXT    NULL,
    [DateSubmitted]                DATETIME NULL,
    CONSTRAINT [PK_AbstractReview] PRIMARY KEY CLUSTERED ([AbstractReviewId] ASC),
    CONSTRAINT [FK_AbstractReview_AbstractReviewerAssignment] FOREIGN KEY ([AbstractReviewerAssignmentId]) REFERENCES [Conference].[AbstractReviewerAssignment] ([AbstractReviewerAssignmentId]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_AbstractReview_AbstractStatus] FOREIGN KEY ([AbstractStatusId]) REFERENCES [Conference].[AbstractStatus] ([AbstractStatusId])
);

