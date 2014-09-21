CREATE PROCEDURE [dbo].[GetByIDInvitedGuests]

AS
BEGIN
Select ID, PersonId, ConferenceId, DateRegistered, SpeakerImage, SpeakerPosition, SpeakerBio, FlightfromCountry, FlightFromCity, FlightToCountry, FlightToCity, FlightNO, ArrivalDate, ArrivalTime, DepratureDate, DepratureTime, AirllineID, HotelID, ResponsiblePersonID,ArrivalTimeAMorPM,DepratureTimeAMorPM
From [Conference].[InvitedGuests]


END
