CREATE PROCEDURE [dbo].[UpdateAirLineLanguage]
    @OldID int,
    @Name nvarchar(50),
    @LanguageID int,
    @AirLineParentID int
AS
UPDATE [Conference].[AirLineLanguage]
SET
    Name = @Name,
    LanguageID = @LanguageID,
    AirLineParentID = @AirLineParentID
WHERE [ID] = @OLDID
IF @@ROWCOUNT > 0
Select * From Conference.AirLineLanguage 
Where [ID] = @OLDID
