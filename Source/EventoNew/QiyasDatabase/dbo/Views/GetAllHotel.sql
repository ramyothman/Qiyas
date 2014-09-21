CREATE VIEW [dbo].[GetAllHotel]
AS
SELECT        ID, Name, Description, Location, Star, URL, Phone, Fax, Email, ConferenceID
FROM            Conference.Hotel
