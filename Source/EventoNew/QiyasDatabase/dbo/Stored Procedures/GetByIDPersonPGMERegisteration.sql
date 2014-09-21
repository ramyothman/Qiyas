CREATE PROCEDURE [dbo].[GetByIDPersonPGMERegisteration]
    @PersonRegisterationId int

AS
BEGIN
Select PersonRegisterationId, PersonId, PersonProgramId, PersonRegisterationStatusId, RegisterationNumber, UniRegisterationNumber
From [PGME].[PersonPGMERegisteration]

WHERE [PersonRegisterationId] = @PersonRegisterationId
END
