CREATE PROCEDURE [dbo].[DeleteArticleLanguage]
    @ArticleLanguageId int

AS
Begin
 Delete [ContentManagement].[ArticleLanguage] where     [ArticleLanguageId] = @ArticleLanguageId
End
