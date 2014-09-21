CREATE TABLE [ContentManagement].[CommentType] (
    [CommentTypeId]   INT           IDENTITY (1, 1) NOT NULL,
    [CommentTypeName] NVARCHAR (50) NULL,
    CONSTRAINT [PK_CommentType] PRIMARY KEY CLUSTERED ([CommentTypeId] ASC)
);

