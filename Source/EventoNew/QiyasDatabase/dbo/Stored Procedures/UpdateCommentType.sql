CREATE PROCEDURE [dbo].[UpdateCommentType]
    @OldCommentTypeId int,
    @CommentTypeName nvarchar(50)
AS
UPDATE [ContentManagement].[CommentType]
SET
    CommentTypeName = @CommentTypeName
WHERE [CommentTypeId] = @OLDCommentTypeId
IF @@ROWCOUNT > 0
Select * From ContentManagement.CommentType 
Where [CommentTypeId] = @OLDCommentTypeId
