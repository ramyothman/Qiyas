CREATE PROCEDURE [dbo].[GetByIDTravel]
    @ID int

AS
BEGIN
Select ID, Name, TransportationTypeID, Description,ConferenceID
From [Conference].[Travel]

WHERE [ID] = @ID
END
