create PROCEDURE [dbo].GetByIDArticleIdLanguageIdArticlelanguage
    @ArticleId int,
    @LanguageId int

AS
BEGIN
Select *
From [ContentManagement].ArticleLanguage

WHERE ArticleId = @ArticleId and LanguageId = @LanguageId
END
