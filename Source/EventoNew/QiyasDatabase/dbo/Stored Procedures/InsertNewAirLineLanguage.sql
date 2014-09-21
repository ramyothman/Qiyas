CREATE PROCEDURE [dbo].[InsertNewAirLineLanguage]
    @ID int output ,
    @Name nvarchar(50),
    @LanguageID int,
    @AirLineParentID int
AS
INSERT INTO [Conference].[AirLineLanguage] (
    [Name],
    [LanguageID],
    [AirLineParentID])
Values (
    @Name,
    @LanguageID,
    @AirLineParentID)
Set @ID = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from Conference.AirLineLanguage
Where [ID] = @@identity
