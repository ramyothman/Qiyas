﻿CREATE PROCEDURE InsertNewConferences
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
INSERT INTO [Conference].[Conferences] (
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
    [ConferenceCode],
    [ConferenceAlias],
    [ConferenceVenueID],
    [IsDefault],
    [AbstractSubmissionStartDate],
    [AbstractSubmissionEndDate],
    [AbstractSubmissionEndMessagePageID],
    [AbstractSubmissionNotStartedPageID])
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
    @ConferenceCode,
    @ConferenceAlias,
    @ConferenceVenueID,
    @IsDefault,
    @AbstractSubmissionStartDate,
    @AbstractSubmissionEndDate,
    @AbstractSubmissionEndMessagePageID,
    @AbstractSubmissionNotStartedPageID)
Set @ConferenceId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Conference.Conferences
Where [ConferenceId] = @@identity
