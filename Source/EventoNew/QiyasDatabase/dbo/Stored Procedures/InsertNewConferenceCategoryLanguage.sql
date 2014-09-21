CREATE PROCEDURE [dbo].[InsertNewConferenceCategoryLanguage]
    @ConferenceCategoryId int output ,
    @CategoryName nvarchar(50),
    @ConferenceId int,
    @LanguageID int,
    @ConferenceCategoryParentID int
AS
INSERT INTO [Conference].[ConferenceCategoryLanguage] (
    [CategoryName],
    [ConferenceId],
    [LanguageID],
    [ConferenceCategoryParentID])
Values (
    @CategoryName,
    @ConferenceId,
    @LanguageID,
    @ConferenceCategoryParentID)
Set @ConferenceCategoryId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Conference.ConferenceCategoryLanguage
Where [ConferenceCategoryId] = @@identity
