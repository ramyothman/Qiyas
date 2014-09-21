CREATE VIEW [dbo].[GetAllConferenceMainImages]
AS
SELECT     ConferenceMainImageId, PhotoPath, ConferenceId, LanguageId, PhotoLink, PhotoTitle, PhotoDescription
FROM         Conference.ConferenceMainImages
