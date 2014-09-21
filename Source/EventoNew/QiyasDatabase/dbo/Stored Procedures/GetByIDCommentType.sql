CREATE PROCEDURE [dbo].[GetByIDCommentType]
    @CommentTypeId int

AS
BEGIN
Select CommentTypeId, CommentTypeName
From [ContentManagement].[CommentType]

WHERE [CommentTypeId] = @CommentTypeId
END
