CREATE PROCEDURE [dbo].[UpdatePersonRegisterationStatus]
    @OldPersonRegisterationStatusId int,
    @Status nvarchar(50)
AS
UPDATE [PGME].[PersonRegisterationStatus]
SET
    Status = @Status
WHERE [PersonRegisterationStatusId] = @OLDPersonRegisterationStatusId
IF @@ROWCOUNT > 0
Select * From PGME.PersonRegisterationStatus 
Where [PersonRegisterationStatusId] = @OLDPersonRegisterationStatusId
