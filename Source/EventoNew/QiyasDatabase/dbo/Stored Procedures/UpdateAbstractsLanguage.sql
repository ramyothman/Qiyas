CREATE PROCEDURE [dbo].[UpdateAbstractsLanguage]
    @OldAbstractLanguageId int,
    @AbstractId int,
    @AbstractTitle nvarchar(500),
    @AbstractIntro ntext,
    @CoverLetter ntext,
    @Topic nvarchar(250),
    @Background ntext,
    @Methods ntext,
    @Results ntext,
    @Conclusions ntext,
    @AbstractTerms ntext,
    @AbstractKeywords nvarchar(500),
    @LanguageID int
AS
UPDATE [Conference].[AbstractsLanguage]
SET
    AbstractId = @AbstractId,
    AbstractTitle = @AbstractTitle,
    AbstractIntro = @AbstractIntro,
    CoverLetter = @CoverLetter,
    Topic = @Topic,
    Background = @Background,
    Methods = @Methods,
    Results = @Results,
    Conclusions = @Conclusions,
    AbstractTerms = @AbstractTerms,
    AbstractKeywords = @AbstractKeywords,
    LanguageID = @LanguageID
WHERE [AbstractLanguageId] = @OLDAbstractLanguageId
IF @@ROWCOUNT > 0
Select * From Conference.AbstractsLanguage 
Where [AbstractLanguageId] = @OLDAbstractLanguageId

