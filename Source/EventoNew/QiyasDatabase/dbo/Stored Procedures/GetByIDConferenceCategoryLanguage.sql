CREATE PROCEDURE [dbo].[GetByIDConferenceCategoryLanguage]
    @ConferenceCategoryId int

AS
BEGIN
Select ConferenceCategoryId, CategoryName, ConferenceId, LanguageID, ConferenceCategoryParentID
From [Conference].[ConferenceCategoryLanguage]

WHERE [ConferenceCategoryId] = @ConferenceCategoryId
END
