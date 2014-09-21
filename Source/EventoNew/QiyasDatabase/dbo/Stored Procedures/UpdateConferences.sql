CREATE PROCEDURE UpdateConferences
    @OldConferenceId int,
    @SiteId int,
    @ConferenceName nvarchar(500),
    @ConferenceLogo nvarchar(500),
    @StartDate datetime,
    @EndDate datetime,
    @IsActive bit,
    @Location nvarchar(500),
    @LocationName nvarchar(500),
    @LocationLogo nvarchar(500),
    @LocationLongitude decimal(18,6),
    @LocationLatitude decimal(18,6),
    @ConferenceDomain nvarchar(50),
    @ConferenceCode nvarchar(10),
    @ConferenceAlias nvarchar(20),
    @ConferenceVenueID int,
    @IsDefault bit,
    @AbstractSubmissionStartDate datetime,
    @AbstractSubmissionEndDate datetime,
    @AbstractSubmissionEndMessagePageID int,
    @AbstractSubmissionNotStartedPageID int
AS
UPDATE [Conference].[Conferences]
SET
    SiteId = @SiteId,
    ConferenceName = @ConferenceName,
    ConferenceLogo = @ConferenceLogo,
    StartDate = @StartDate,
    EndDate = @EndDate,
    IsActive = @IsActive,
    Location = @Location,
    LocationName = @LocationName,
    LocationLogo = @LocationLogo,
    LocationLongitude = @LocationLongitude,
    LocationLatitude = @LocationLatitude,
    ConferenceDomain = @ConferenceDomain,
    ConferenceCode = @ConferenceCode,
    ConferenceAlias = @ConferenceAlias,
    ConferenceVenueID = @ConferenceVenueID,
    IsDefault = @IsDefault,
    AbstractSubmissionStartDate = @AbstractSubmissionStartDate,
    AbstractSubmissionEndDate = @AbstractSubmissionEndDate,
    AbstractSubmissionEndMessagePageID = @AbstractSubmissionEndMessagePageID,
    AbstractSubmissionNotStartedPageID = @AbstractSubmissionNotStartedPageID
WHERE [ConferenceId] = @OLDConferenceId
IF @@ROWCOUNT > 0
Select * From Conference.Conferences 
Where [ConferenceId] = @OLDConferenceId
