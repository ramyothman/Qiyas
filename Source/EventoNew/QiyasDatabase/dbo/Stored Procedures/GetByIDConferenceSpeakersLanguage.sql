CREATE PROCEDURE [dbo].[GetByIDConferenceSpeakersLanguage]
    @ConferenceSpeakerId int

AS
BEGIN
Select ConferenceSpeakerId, PersonId, ConferenceId, DateRegistered, SpeakerImage, SpeakerPosition, SpeakerBio, FlightfromCountry, FlightFromCity, FlightToCountry, FlightToCity, FlightNO, ArrivalDate, ArrivalTime, DepratureDate, DepratureTime, AirllineID, HotelID, ResponsiblePersonID, ArrivalTimeAMorPM, DepratureTimeAMorPM, LanguageID, ConferenceSpeakerParentId
From [Conference].[ConferenceSpeakersLanguage]

WHERE [ConferenceSpeakerId] = @ConferenceSpeakerId
END
