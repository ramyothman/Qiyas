CREATE PROCEDURE [dbo].[DeleteCommentType]
    @CommentTypeId int

AS
Begin
 Delete [ContentManagement].[CommentType] where     [CommentTypeId] = @CommentTypeId
End
