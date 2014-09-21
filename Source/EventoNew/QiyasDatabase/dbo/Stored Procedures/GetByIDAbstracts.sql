CREATE PROCEDURE [dbo].[GetByIDAbstracts]
    @AbstractId int

AS
BEGIN
Select AbstractId, PersonId, ConferenceId, ConferenceCategoryId, AbstractTitle, AbstractIntro, AbstractAuthors, CoverLetter, IsAccepted, AcceptanceType, PresentationPath, PosterPath, Topic, Background, Methods, Results, Conclusions, AbstractTerms, AbstractKeywords, DocumentPath1, DocumentPath2, DocumentPath3, RevisionNumber, ParentID, AbstractStatusId
From [Conference].[Abstracts]

WHERE [AbstractId] = @AbstractId
END

