CREATE PROCEDURE [dbo].[UpdateTransportationType]
    @OldID int,
    @TypeName nvarchar(50)
AS
UPDATE [Conference].[TransportationType]
SET
    TypeName = @TypeName
WHERE [ID] = @OLDID
IF @@ROWCOUNT > 0
Select * From Conference.TransportationType 
Where [ID] = @OLDID
