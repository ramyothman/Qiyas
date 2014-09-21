CREATE PROCEDURE [dbo].[GetByIDCommentStatus]
    @CommentStatusId int

AS
BEGIN
Select CommentStatusId, CommentStatusName
From [ContentManagement].[CommentStatus]

WHERE [CommentStatusId] = @CommentStatusId
END
