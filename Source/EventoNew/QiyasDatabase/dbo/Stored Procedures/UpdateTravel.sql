CREATE PROCEDURE [dbo].[UpdateTravel]
    @OldID int,
    @Name nvarchar(50),
    @TransportationTypeID int,
    @Description nvarchar(200),
	@ConferenceID int
AS
UPDATE [Conference].[Travel]
SET
    Name = @Name,
    TransportationTypeID = @TransportationTypeID,
    Description = @Description,
	ConferenceID = @ConferenceID
WHERE [ID] = @OLDID
IF @@ROWCOUNT > 0
Select * From Conference.Travel 
Where [ID] = @OLDID
