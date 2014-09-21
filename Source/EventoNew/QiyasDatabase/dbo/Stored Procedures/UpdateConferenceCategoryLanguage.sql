CREATE PROCEDURE [dbo].[UpdateConferenceCategoryLanguage]
    @OldConferenceCategoryId int,
    @CategoryName nvarchar(50),
    @ConferenceId int,
    @LanguageID int,
    @ConferenceCategoryParentID int
AS
UPDATE [Conference].[ConferenceCategoryLanguage]
SET
    CategoryName = @CategoryName,
    ConferenceId = @ConferenceId,
    LanguageID = @LanguageID,
    ConferenceCategoryParentID = @ConferenceCategoryParentID
WHERE [ConferenceCategoryId] = @OLDConferenceCategoryId
IF @@ROWCOUNT > 0
Select * From Conference.ConferenceCategoryLanguage 
Where [ConferenceCategoryId] = @OLDConferenceCategoryId
