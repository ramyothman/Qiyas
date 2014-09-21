CREATE PROCEDURE GetByIDConferences
    @ConferenceId int

AS
BEGIN
Select ConferenceId, SiteId, ConferenceName, ConferenceLogo, StartDate, EndDate, IsActive, Location, LocationName, LocationLogo, LocationLongitude, LocationLatitude, ConferenceDomain, ConferenceCode, ConferenceAlias, ConferenceVenueID, IsDefault, AbstractSubmissionStartDate, AbstractSubmissionEndDate, AbstractSubmissionEndMessagePageID, AbstractSubmissionNotStartedPageID
From [Conference].[Conferences]

WHERE [ConferenceId] = @ConferenceId
END
