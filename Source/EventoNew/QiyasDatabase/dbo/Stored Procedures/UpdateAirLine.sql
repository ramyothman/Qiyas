CREATE PROCEDURE [dbo].[UpdateAirLine]
    @OldID int,
    @Name nvarchar(50)
AS
UPDATE [Conference].[AirLine]
SET
    Name = @Name
WHERE [ID] = @OLDID
IF @@ROWCOUNT > 0
Select * From Conference.AirLine 
Where [ID] = @OLDID
