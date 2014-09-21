CREATE PROCEDURE [dbo].[UpdatePersonPGMERegisteration]
    @OldPersonRegisterationId int,
    @PersonId int,
    @PersonProgramId int,
    @PersonRegisterationStatusId int,
    @RegisterationNumber nvarchar(50),
    @UniRegisterationNumber nvarchar(50)
AS
UPDATE [PGME].[PersonPGMERegisteration]
SET
    PersonId = @PersonId,
    PersonProgramId = @PersonProgramId,
    PersonRegisterationStatusId = @PersonRegisterationStatusId,
    RegisterationNumber = @RegisterationNumber,
    UniRegisterationNumber = @UniRegisterationNumber
WHERE [PersonRegisterationId] = @OLDPersonRegisterationId
IF @@ROWCOUNT > 0
Select * From PGME.PersonPGMERegisteration 
Where [PersonRegisterationId] = @OLDPersonRegisterationId
