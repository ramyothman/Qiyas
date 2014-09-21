CREATE PROCEDURE [dbo].[GetByIDPersonReference]
    @PersonReferenceId int

AS
BEGIN
Select PersonReferenceId, PersonId, ReferenceFullName, ReferenceEmail, ReferenceAddress, ReferenceContactNumber, ReferenceMobileNumber, ReferenceLetterPath, ReferenceLetterMessage, ReferenceAcceptedPerson, ReferenceInstitution
From [PGME].[PersonReference]

WHERE [PersonReferenceId] = @PersonReferenceId
END
