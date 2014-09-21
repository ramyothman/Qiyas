CREATE PROCEDURE [dbo].[UpdateAbstracts]
    @OldAbstractId int,
    @PersonId int,
    @ConferenceId int,
    @ConferenceCategoryId int,
    @AbstractTitle nvarchar(500),
    @AbstractIntro ntext,
    @AbstractAuthors nvarchar(4000),
    @CoverLetter ntext,
    @IsAccepted bit,
    @AcceptanceType nvarchar(50),
    @PresentationPath nvarchar(500),
    @PosterPath nvarchar(500),
    @Topic nvarchar(250),
    @Background ntext,
    @Methods ntext,
    @Results ntext,
    @Conclusions ntext,
    @AbstractTerms ntext,
    @AbstractKeywords nvarchar(500),
    @DocumentPath1 nvarchar(250),
    @DocumentPath2 nvarchar(250),
    @DocumentPath3 nvarchar(250),
    @RevisionNumber int,
    @ParentID int,
    @AbstractStatusId int
AS
UPDATE [Conference].[Abstracts]
SET
    PersonId = @PersonId,
    ConferenceId = @ConferenceId,
    ConferenceCategoryId = @ConferenceCategoryId,
    AbstractTitle = @AbstractTitle,
    AbstractIntro = @AbstractIntro,
    AbstractAuthors = @AbstractAuthors,
    CoverLetter = @CoverLetter,
    IsAccepted = @IsAccepted,
    AcceptanceType = @AcceptanceType,
    PresentationPath = @PresentationPath,
    PosterPath = @PosterPath,
    Topic = @Topic,
    Background = @Background,
    Methods = @Methods,
    Results = @Results,
    Conclusions = @Conclusions,
    AbstractTerms = @AbstractTerms,
    AbstractKeywords = @AbstractKeywords,
    DocumentPath1 = @DocumentPath1,
    DocumentPath2 = @DocumentPath2,
    DocumentPath3 = @DocumentPath3,
    RevisionNumber = @RevisionNumber,
    ParentID = @ParentID,
    AbstractStatusId = @AbstractStatusId
WHERE [AbstractId] = @OLDAbstractId
IF @@ROWCOUNT > 0
Select * From Conference.Abstracts 
Where [AbstractId] = @OLDAbstractId

