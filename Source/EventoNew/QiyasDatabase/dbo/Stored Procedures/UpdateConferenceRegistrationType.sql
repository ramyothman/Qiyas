CREATE PROCEDURE UpdateConferenceRegistrationType
    @OldConferenceRegistrationTypeId int,
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
UPDATE [Conference].[ConferenceRegistrationType]
SET
    ConferenceId = @ConferenceId,
    Name = @Name,
    Fee = @Fee,
    GroupName = @GroupName,
    StartDate = @StartDate,
    EndDate = @EndDate,
    EarlyRegistrationEndDate = @EarlyRegistrationEndDate,
    LateFee = @LateFee,
    ConferenceScheduleID = @ConferenceScheduleID,
    OfferStartDate = @OfferStartDate,
    OfferEndDate = @OfferEndDate,
    OfferFee = @OfferFee,
    HaveOffer = @HaveOffer,
    MustRegister = @MustRegister
WHERE [ConferenceRegistrationTypeId] = @OLDConferenceRegistrationTypeId
IF @@ROWCOUNT > 0
Select * From Conference.ConferenceRegistrationType 
Where [ConferenceRegistrationTypeId] = @OLDConferenceRegistrationTypeId
