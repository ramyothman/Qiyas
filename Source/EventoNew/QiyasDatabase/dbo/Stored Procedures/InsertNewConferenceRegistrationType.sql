CREATE PROCEDURE InsertNewConferenceRegistrationType
    @ConferenceRegistrationTypeId int output ,
    @ConferenceId int,
    @Name nvarchar(50),
    @Fee decimal(18,2),
    @GroupName nvarchar(50),
    @StartDate datetime,
    @EndDate datetime,
    @EarlyRegistrationEndDate datetime,
    @LateFee decimal(18,2),
    @ConferenceScheduleID int,
    @OfferStartDate datetime,
    @OfferEndDate datetime,
    @OfferFee decimal(18,2),
    @HaveOffer bit,
    @MustRegister bit
AS
INSERT INTO [Conference].[ConferenceRegistrationType] (
    [ConferenceId],
    [Name],
    [Fee],
    [GroupName],
    [StartDate],
    [EndDate],
    [EarlyRegistrationEndDate],
    [LateFee],
    [ConferenceScheduleID],
    [OfferStartDate],
    [OfferEndDate],
    [OfferFee],
    [HaveOffer],
    [MustRegister])
Values (
    @ConferenceId,
    @Name,
    @Fee,
    @GroupName,
    @StartDate,
    @EndDate,
    @EarlyRegistrationEndDate,
    @LateFee,
    @ConferenceScheduleID,
    @OfferStartDate,
    @OfferEndDate,
    @OfferFee,
    @HaveOffer,
    @MustRegister)
Set @ConferenceRegistrationTypeId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Conference.ConferenceRegistrationType
Where [ConferenceRegistrationTypeId] = @@identity
