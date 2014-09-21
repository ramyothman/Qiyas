
CREATE PROCEDURE [dbo].[UpdateConferenceMainImages]
    @OldConferenceMainImageId int,
    @PhotoPath nvarchar(250),
    @ConferenceId int,
    @LanguageId int,
    @PhotoLink nvarchar(250),
    @PhotoTitle nvarchar(50),
    @PhotoDescription nvarchar(150)
AS
UPDATE [Conference].[ConferenceMainImages]
SET
    PhotoPath = @PhotoPath,
    ConferenceId = @ConferenceId,
    LanguageId = @LanguageId,
    PhotoLink = @PhotoLink,
    PhotoTitle = @PhotoTitle,
    PhotoDescription = @PhotoDescription
WHERE [ConferenceMainImageId] = @OLDConferenceMainImageId
IF @@ROWCOUNT > 0
Select * From Conference.ConferenceMainImages 
Where [ConferenceMainImageId] = @OLDConferenceMainImageId
