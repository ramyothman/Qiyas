CREATE PROCEDURE [dbo].[UpdateConferenceCategory]
    @OldConferenceCategoryId int,
    @CategoryName nvarchar(50),
    @ConferenceId int
AS
UPDATE [Conference].[ConferenceCategory]
SET
    CategoryName = @CategoryName,
    ConferenceId = @ConferenceId
WHERE [ConferenceCategoryId] = @OLDConferenceCategoryId
IF @@ROWCOUNT > 0
Select * From Conference.ConferenceCategory 
Where [ConferenceCategoryId] = @OLDConferenceCategoryId
