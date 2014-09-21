CREATE PROCEDURE [dbo].[UpdateConferenceSpeakers]
    @OldConferenceSpeakerId int,
    @PersonId int,
    @ConferenceId int,
    @DateRegistered datetime,
    @SpeakerImage nvarchar(150),
    @SpeakerPosition nvarchar(500),
    @SpeakerBio nvarchar(2000),
    @FlightfromCountry nvarchar(50),
    @FlightFromCity nvarchar(50),
    @FlightToCountry nvarchar(50),
    @FlightToCity nvarchar(50),
    @FlightNO nvarchar(50),
    @ArrivalDate datetime,
    @ArrivalTime nvarchar(50),
    @DepratureDate datetime,
    @DepratureTime nvarchar(50),
    @AirllineID int,
    @HotelID int,
    @ResponsiblePersonID int,
      @DepratureTimeAMorPM nvarchar(50),
    @ArrivalTimeAMorPM nvarchar(50)
AS
UPDATE [Conference].[ConferenceSpeakers]
SET
    PersonId = @PersonId,
    ConferenceId = @ConferenceId,
    DateRegistered = @DateRegistered,
    SpeakerImage = @SpeakerImage,
    SpeakerPosition = @SpeakerPosition,
    SpeakerBio = @SpeakerBio,
    FlightfromCountry = @FlightfromCountry,
    FlightFromCity = @FlightFromCity,
    FlightToCountry = @FlightToCountry,
    FlightToCity = @FlightToCity,
    FlightNO = @FlightNO,
    ArrivalDate = @ArrivalDate,
    ArrivalTime = @ArrivalTime,
    DepratureDate = @DepratureDate,
    DepratureTime = @DepratureTime,
    AirllineID = @AirllineID,
    HotelID = @HotelID,
    ResponsiblePersonID = @ResponsiblePersonID,
    DepratureTimeAMorPM=@DepratureTimeAMorPM,
    ArrivalTimeAMorPM=@ArrivalTimeAMorPM
WHERE [ConferenceSpeakerId] = @OLDConferenceSpeakerId
IF @@ROWCOUNT > 0
Select * From Conference.ConferenceSpeakers 
Where [ConferenceSpeakerId] = @OLDConferenceSpeakerId
