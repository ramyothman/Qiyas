﻿CREATE PROCEDURE [dbo].[InsertNewConferenceSpeakers]
    @ConferenceSpeakerId int output ,
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
INSERT INTO [Conference].[ConferenceSpeakers] (
    [PersonId],
    [ConferenceId],
    [DateRegistered],
    [SpeakerImage],
    [SpeakerPosition],
    [SpeakerBio],
    [FlightfromCountry],
    [FlightFromCity],
    [FlightToCountry],
    [FlightToCity],
    [FlightNO],
    [ArrivalDate],
    [ArrivalTime],
    [DepratureDate],
    [DepratureTime],
    [AirllineID],
    [HotelID],
    [ResponsiblePersonID],
    ArrivalTimeAMorPM,
    DepratureTimeAMorPM)
Values (
    @PersonId,
    @ConferenceId,
    @DateRegistered,
    @SpeakerImage,
    @SpeakerPosition,
    @SpeakerBio,
    @FlightfromCountry,
    @FlightFromCity,
    @FlightToCountry,
    @FlightToCity,
    @FlightNO,
    @ArrivalDate,
    @ArrivalTime,
    @DepratureDate,
    @DepratureTime,
    @AirllineID,
    @HotelID,
    @ResponsiblePersonID,
    @ArrivalTimeAMorPM,
    @DepratureTimeAMorPM)
Set @ConferenceSpeakerId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Conference.ConferenceSpeakers
Where [ConferenceSpeakerId] = @@identity
