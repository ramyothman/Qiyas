CREATE PROCEDURE [dbo].[UpdateArticleComment]
    @OldArticleCommentId int,
    @ArticleId int,
    @ArticleComment ntext,
    @ModifiedDate datetime,
    @PersonId int,
    @CommentStatusId int
AS
UPDATE [ContentManagement].[ArticleComment]
SET
    ArticleId = @ArticleId,
    ArticleComment = @ArticleComment,
    ModifiedDate = @ModifiedDate,
    PersonId = @PersonId,
    CommentStatusId = @CommentStatusId
WHERE [ArticleCommentId] = @OLDArticleCommentId
IF @@ROWCOUNT > 0
Select * From ContentManagement.ArticleComment 
Where [ArticleCommentId] = @OLDArticleCommentId
