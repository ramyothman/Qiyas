CREATE PROCEDURE [dbo].[GetByIDHotel]
    @ID int

AS
BEGIN
Select ID, Name, Description, Location, Star, URL, Phone, Fax, Email,ConferenceID
From [Conference].[Hotel]

WHERE [ID] = @ID
END
