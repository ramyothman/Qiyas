CREATE PROCEDURE [dbo].[GetByIDAbstractsLanguage]
    @AbstractLanguageId int

AS
BEGIN
Select AbstractLanguageId, AbstractId, AbstractTitle, AbstractIntro, CoverLetter, Topic, Background, Methods, Results, Conclusions, AbstractTerms, AbstractKeywords, LanguageID
From [Conference].[AbstractsLanguage]

WHERE [AbstractLanguageId] = @AbstractLanguageId
END

