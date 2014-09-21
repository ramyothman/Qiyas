CREATE TABLE [ContentManagement].[CommentStatus] (
    [CommentStatusId]   INT           IDENTITY (1, 1) NOT NULL,
    [CommentStatusName] NVARCHAR (50) NULL,
    CONSTRAINT [PK_CommentStatus] PRIMARY KEY CLUSTERED ([CommentStatusId] ASC)
);

