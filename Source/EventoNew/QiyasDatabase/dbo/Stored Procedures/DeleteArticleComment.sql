CREATE PROCEDURE [dbo].[DeleteArticleComment]
    @ArticleCommentId int

AS
Begin
 Delete [ContentManagement].[ArticleComment] where     [ArticleCommentId] = @ArticleCommentId
End
