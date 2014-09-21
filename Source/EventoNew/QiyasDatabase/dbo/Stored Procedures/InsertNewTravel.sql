CREATE PROCEDURE [dbo].[InsertNewTravel]
    @ID int output ,
    @Name nvarchar(50),
    @TransportationTypeID int,
    @Description nvarchar(200),
	@ConferenceID int
AS
INSERT INTO [Conference].[Travel] (
    [Name],
    [TransportationTypeID],
    [Description],
	[ConferenceID])
Values (
    @Name,
    @TransportationTypeID,
    @Description,
	@ConferenceID)
Set @ID = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Conference.Travel
Where [ID] = @@identity
