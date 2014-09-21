CREATE PROCEDURE [dbo].[GetByIDConferencesLanguage]
    @ConferenceId int

AS
BEGIN
Select ConferenceId, SiteId, ConferenceName, ConferenceLogo, StartDate, EndDate, IsActive, Location, LocationName, LocationLogo, LocationLongitude, LocationLatitude, ConferenceDomain, ConferenceParentId, LanguageID
From [Conference].[ConferencesLanguage]

WHERE [ConferenceId] = @ConferenceId
END
