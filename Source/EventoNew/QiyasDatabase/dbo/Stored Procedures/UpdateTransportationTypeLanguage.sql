CREATE PROCEDURE [dbo].[UpdateTransportationTypeLanguage]
    @OldID int,
    @TypeName nvarchar(50),
    @LanguageID int,
    @ParentID int
AS
UPDATE [Conference].[TransportationTypeLanguage]
SET
    TypeName = @TypeName,
    LanguageID = @LanguageID,
    ParentID = @ParentID
WHERE [ID] = @OLDID
IF @@ROWCOUNT > 0
Select * From Conference.TransportationTypeLanguage 
Where [ID] = @OLDID
