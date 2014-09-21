CREATE PROCEDURE [dbo].[UpdateConferencesLanguage]
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
    @LocationLongitude decimal(18,2),
    @LocationLatitude decimal(18,2),
    @ConferenceDomain nvarchar(50),
    @ConferenceParentId int,
    @LanguageID int
AS
UPDATE [Conference].[ConferencesLanguage]
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
    ConferenceParentId = @ConferenceParentId,
    LanguageID = @LanguageID
WHERE [ConferenceId] = @OLDConferenceId
IF @@ROWCOUNT > 0
Select * From Conference.ConferencesLanguage 
Where [ConferenceId] = @OLDConferenceId
