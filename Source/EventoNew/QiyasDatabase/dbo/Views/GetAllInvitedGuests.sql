CREATE VIEW [dbo].[GetAllInvitedGuests]
AS
SELECT     ID, PersonId, ConferenceId, DateRegistered, SpeakerImage, SpeakerPosition, SpeakerBio, FlightfromCountry, FlightFromCity, FlightToCountry, FlightToCity, FlightNO, 
                      ArrivalDate, ArrivalTime, DepratureDate, DepratureTime, AirllineID, HotelID, ResponsiblePersonID, ArrivalTimeAMorPM, DepratureTimeAMorPM
FROM         Conference.InvitedGuests
