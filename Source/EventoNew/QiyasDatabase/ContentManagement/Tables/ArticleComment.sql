CREATE TABLE [ContentManagement].[ArticleComment] (
    [ArticleCommentId] INT      IDENTITY (1, 1) NOT NULL,
    [ArticleId]        INT      NULL,
    [ArticleComment]   NTEXT    NULL,
    [ModifiedDate]     DATETIME NULL,
    [PersonId]         INT      NULL,
    [CommentStatusId]  INT      NULL,
    CONSTRAINT [PK_ArticleComment] PRIMARY KEY CLUSTERED ([ArticleCommentId] ASC),
    CONSTRAINT [FK_ArticleComment_Article] FOREIGN KEY ([ArticleId]) REFERENCES [ContentManagement].[Article] ([ArticleId]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_ArticleComment_CommentStatus] FOREIGN KEY ([CommentStatusId]) REFERENCES [ContentManagement].[CommentStatus] ([CommentStatusId])
);

