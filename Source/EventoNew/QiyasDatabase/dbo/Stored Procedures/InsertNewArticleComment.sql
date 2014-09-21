CREATE PROCEDURE [dbo].[InsertNewArticleComment]
    @ArticleCommentId int output ,
    @ArticleId int,
    @ArticleComment ntext,
    @ModifiedDate datetime,
    @PersonId int,
    @CommentStatusId int
AS
INSERT INTO [ContentManagement].[ArticleComment] (
    [ArticleId],
    [ArticleComment],
    [ModifiedDate],
    [PersonId],
    [CommentStatusId])
Values (
    @ArticleId,
    @ArticleComment,
    @ModifiedDate,
    @PersonId,
    @CommentStatusId)
Set @ArticleCommentId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from ContentManagement.ArticleComment
Where [ArticleCommentId] = @@identity
