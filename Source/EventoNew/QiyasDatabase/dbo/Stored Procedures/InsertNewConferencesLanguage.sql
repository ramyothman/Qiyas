CREATE PROCEDURE [dbo].[InsertNewConferencesLanguage]
    @ConferenceId int output ,
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
INSERT INTO [Conference].[ConferencesLanguage] (
    [SiteId],
    [ConferenceName],
    [ConferenceLogo],
    [StartDate],
    [EndDate],
    [IsActive],
    [Location],
    [LocationName],
    [LocationLogo],
    [LocationLongitude],
    [LocationLatitude],
    [ConferenceDomain],
    [ConferenceParentId],
    [LanguageID])
Values (
    @SiteId,
    @ConferenceName,
    @ConferenceLogo,
    @StartDate,
    @EndDate,
    @IsActive,
    @Location,
    @LocationName,
    @LocationLogo,
    @LocationLongitude,
    @LocationLatitude,
    @ConferenceDomain,
    @ConferenceParentId,
    @LanguageID)
Set @ConferenceId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Conference.ConferencesLanguage
Where [ConferenceId] = @@identity
