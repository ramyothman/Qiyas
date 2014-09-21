CREATE PROCEDURE [dbo].[InsertNewTravellanguage]
    @ID int output ,
    @Name nvarchar(50),
    @TransportationTypeID int,
    @Description nvarchar(200),
    @ParentID int,
    @LanguageID int
AS
INSERT INTO [Conference].[Travellanguage] (
    [Name],
    [TransportationTypeID],
    [Description],
    [ParentID],
    [LanguageID])
Values (
    @Name,
    @TransportationTypeID,
    @Description,
    @ParentID,
    @LanguageID)
Set @ID = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Conference.Travellanguage
Where [ID] = @@identity
