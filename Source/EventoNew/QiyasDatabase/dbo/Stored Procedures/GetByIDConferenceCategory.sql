CREATE PROCEDURE [dbo].[GetByIDConferenceCategory]
    @ConferenceCategoryId int

AS
BEGIN
Select ConferenceCategoryId, CategoryName, ConferenceId
From [Conference].[ConferenceCategory]

WHERE [ConferenceCategoryId] = @ConferenceCategoryId
END
