CREATE PROCEDURE [dbo].[DeleteCommentStatus]
    @CommentStatusId int

AS
Begin
 Delete [ContentManagement].[CommentStatus] where     [CommentStatusId] = @CommentStatusId
End
