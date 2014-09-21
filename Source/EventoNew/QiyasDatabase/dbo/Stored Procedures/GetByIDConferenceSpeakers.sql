CREATE PROCEDURE [dbo].[GetByIDConferenceSpeakers]
    @ConferenceSpeakerId int

AS
BEGIN
Select ConferenceSpeakerId, PersonId, ConferenceId, DateRegistered, SpeakerImage, SpeakerPosition, SpeakerBio, FlightfromCountry, FlightFromCity, FlightToCountry, FlightToCity, FlightNO, ArrivalDate, ArrivalTime, DepratureDate, DepratureTime, AirllineID, HotelID, ResponsiblePersonID,DepratureTimeAMorPM,ArrivalTimeAMorPM
From [Conference].[ConferenceSpeakers]

WHERE [ConferenceSpeakerId] = @ConferenceSpeakerId
END
