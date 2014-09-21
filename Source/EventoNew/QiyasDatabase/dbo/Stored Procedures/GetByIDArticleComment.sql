CREATE PROCEDURE [dbo].[GetByIDArticleComment]
    @ArticleCommentId int

AS
BEGIN
Select ArticleCommentId, ArticleId, ArticleComment, ModifiedDate, PersonId, CommentStatusId
From [ContentManagement].[ArticleComment]

WHERE [ArticleCommentId] = @ArticleCommentId
END
