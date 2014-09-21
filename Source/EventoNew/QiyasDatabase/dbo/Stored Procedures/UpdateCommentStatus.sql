CREATE PROCEDURE [dbo].[UpdateCommentStatus]
    @OldCommentStatusId int,
    @CommentStatusName nvarchar(50)
AS
UPDATE [ContentManagement].[CommentStatus]
SET
    CommentStatusName = @CommentStatusName
WHERE [CommentStatusId] = @OLDCommentStatusId
IF @@ROWCOUNT > 0
Select * From ContentManagement.CommentStatus 
Where [CommentStatusId] = @OLDCommentStatusId
