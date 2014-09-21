CREATE PROCEDURE [dbo].[GetByIDInvitedGuestsLanguage]
    @ID int

AS
BEGIN
Select ID, PersonId, ConferenceId, DateRegistered, SpeakerImage, SpeakerPosition, SpeakerBio, FlightfromCountry, FlightFromCity, FlightToCountry, FlightToCity, FlightNO, ArrivalDate, ArrivalTime, DepratureDate, DepratureTime, AirllineID, HotelID, ResponsiblePersonID, ArrivalTimeAMorPM, DepratureTimeAMorPM, LanguageID, parentID
From [Conference].[InvitedGuestsLanguage]

WHERE [ID] = @ID
END
