CREATE PROCEDURE [dbo].[InsertNewTransportationTypeLanguage]
    @ID int output ,
    @TypeName nvarchar(50),
    @LanguageID int,
    @ParentID int
AS
INSERT INTO [Conference].[TransportationTypeLanguage] (
    [TypeName],
    [LanguageID],
    [ParentID])
Values (
    @TypeName,
    @LanguageID,
    @ParentID)
Set @ID = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Conference.TransportationTypeLanguage
Where [ID] = @@identity
