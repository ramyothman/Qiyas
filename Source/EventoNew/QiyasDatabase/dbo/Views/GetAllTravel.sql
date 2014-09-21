CREATE VIEW [dbo].[GetAllTravel]
AS
SELECT        ID, Name, TransportationTypeID, Description, ConferenceID
FROM            Conference.Travel
