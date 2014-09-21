CREATE PROCEDURE [dbo].[InsertNewAbstractsLanguage]
    @AbstractLanguageId int output ,
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
INSERT INTO [Conference].[AbstractsLanguage] (
    [AbstractId],
    [AbstractTitle],
    [AbstractIntro],
    [CoverLetter],
    [Topic],
    [Background],
    [Methods],
    [Results],
    [Conclusions],
    [AbstractTerms],
    [AbstractKeywords],
    [LanguageID])
Values (
    @AbstractId,
    @AbstractTitle,
    @AbstractIntro,
    @CoverLetter,
    @Topic,
    @Background,
    @Methods,
    @Results,
    @Conclusions,
    @AbstractTerms,
    @AbstractKeywords,
    @LanguageID)
Set @AbstractLanguageId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Conference.AbstractsLanguage
Where [AbstractLanguageId] = @@identity


