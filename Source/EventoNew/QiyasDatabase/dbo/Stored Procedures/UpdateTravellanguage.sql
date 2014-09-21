CREATE PROCEDURE [dbo].[UpdateTravellanguage]
    @OldID int,
    @Name nvarchar(50),
    @TransportationTypeID int,
    @Description nvarchar(200),
    @ParentID int,
    @LanguageID int
AS
UPDATE [Conference].[Travellanguage]
SET
    Name = @Name,
    TransportationTypeID = @TransportationTypeID,
    Description = @Description,
    ParentID = @ParentID,
    LanguageID = @LanguageID
WHERE [ID] = @OLDID
IF @@ROWCOUNT > 0
Select * From Conference.Travellanguage 
Where [ID] = @OLDID
