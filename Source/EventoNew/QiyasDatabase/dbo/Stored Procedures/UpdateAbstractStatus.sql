CREATE PROCEDURE [dbo].[UpdateAbstractStatus]
    @AbstractStatusId int,
    @OldAbstractStatusId int,
    @Name nvarchar(50),
    @NameAr nvarchar(50)
AS
UPDATE [Conference].[AbstractStatus]
SET
    AbstractStatusId = @AbstractStatusId,
    Name = @Name,
    NameAr = @NameAr
WHERE [AbstractStatusId] = @OLDAbstractStatusId
IF @@ROWCOUNT > 0
Select * From Conference.AbstractStatus 
Where [AbstractStatusId] = @AbstractStatusId

