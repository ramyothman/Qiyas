CREATE PROCEDURE [dbo].[DeleteArticleStatus]
    @ArticleStatusId int

AS
Begin
 Delete [ContentManagement].[ArticleStatus] where     [ArticleStatusId] = @ArticleStatusId
End
