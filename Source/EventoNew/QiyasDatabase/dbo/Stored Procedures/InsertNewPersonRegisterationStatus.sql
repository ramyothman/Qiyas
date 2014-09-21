CREATE PROCEDURE [dbo].[InsertNewPersonRegisterationStatus]
    @PersonRegisterationStatusId int output ,
    @Status nvarchar(50)
AS
INSERT INTO [PGME].[PersonRegisterationStatus] (
    [Status])
Values (
    @Status)
Set @PersonRegisterationStatusId = SCOPE_IDENTITY()

IF @@ROWCOUNT > 0
Select * from PGME.PersonRegisterationStatus
Where [PersonRegisterationStatusId] = @@identity
