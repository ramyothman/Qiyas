CREATE PROCEDURE [dbo].[GetByIDVenues]
    @ID int

AS
BEGIN
Select ID, Name, Description, Location, Star, URL, Phone, Fax, Email
From [Conference].[Venues]

WHERE [ID] = @ID
END
