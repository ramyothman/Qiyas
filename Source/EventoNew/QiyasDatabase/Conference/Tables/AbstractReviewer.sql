CREATE TABLE [Conference].[AbstractReviewer] (
    [AbstractReviewerId] INT      IDENTITY (1, 1) NOT NULL,
    [PersonId]           INT      NULL,
    [IsInternal]         BIT      NULL,
    [DateCreated]        DATETIME NULL,
    [IsActive]           BIT      NULL,
    CONSTRAINT [PK_AbstractReviewer] PRIMARY KEY CLUSTERED ([AbstractReviewerId] ASC),
    CONSTRAINT [FK_AbstractReviewer_Person] FOREIGN KEY ([PersonId]) REFERENCES [Person].[Person] ([BusinessEntityId]) ON DELETE CASCADE ON UPDATE CASCADE
);

