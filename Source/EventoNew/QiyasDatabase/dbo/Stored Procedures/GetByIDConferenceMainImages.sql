
CREATE PROCEDURE [dbo].[GetByIDConferenceMainImages]
    @ConferenceMainImageId int

AS
BEGIN
Select ConferenceMainImageId, PhotoPath, ConferenceId, LanguageId, PhotoLink, PhotoTitle, PhotoDescription
From [Conference].[ConferenceMainImages]

WHERE [ConferenceMainImageId] = @ConferenceMainImageId
END
